using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace PRG282_Project
{
    public class DataHandler
    {
        static string connect = @"Data Source=freeseball-PC;Initial Catalog=Milestone2_DB;Integrated Security=True";
        
        

        //General Code
        public byte[] convertImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
            //ms.Position = 0;
            //ms.Read(imgArr, 0, imgArr.Length);

            //return imgArr;
        }

        //StudentModules DB
        //SQL query that finds all modules linked to a student Num
        public List<int> readStudentModules(int Num)
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            List<int> mList = new List<int>();
            
            try
            {
                sqlConn.Open();
                string qModules = "SELECT Module_Code FROM Modules  WHERE Module_Code IN (SELECT Module_Code FROM StudentModules WHERE Student_Number = 1)";
                SqlCommand cmd = new SqlCommand(qModules, sqlConn);

                using (var r = cmd.ExecuteReader())
                {

                    while (r.Read())
                    {
                        //Add current Module to list of Modules
                        mList.Add(int.Parse(r[0].ToString()));
                    }
                }
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return mList;

        }

        //Add a Student-Module Pair to the joining table "StudentModules"
        public void addStudentModules(int sID, int mID)
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            try
            {
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spAddStudentModules", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@STUDENTID", sID);
                    cmd.Parameters.AddWithValue("@MODULEID", mID);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }


        //Student DB access
        //Reurns all students from the DB
        public List<Student> readStudents()
        {
            List<Student> sList = new List<Student>();
            Image img = null;
            SqlConnection sqlConn = new SqlConnection(connect);

            try
            {
                sqlConn.Open();
                string qSelect = "Select * from Students";
                SqlCommand cmd = new SqlCommand(qSelect, sqlConn);

                using (var r = cmd.ExecuteReader())
                {
                   
                    while (r.Read())
                    {
                        //student_Number (Used to reduce new studetn function size, since it is used more than once)
                        int id = int.Parse(r[0].ToString());

                        //Converts image in DB into a usable Image for Student Class
                        byte[] imgData = (byte[])r[3];
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            img = Image.FromStream(ms);
                        }
                        
                        //Add current student to list of students
                        sList.Add(new Student(id, r[1].ToString(), r[2].ToString(), img, DateTime.Parse(r[4].ToString()),r[5].ToString()[0],r[6].ToString(),r[7].ToString(), readStudentModules(id)));
                    }
                }
            }
            catch(SqlException)
            {
                //Check returned list count in Student BL layer, if count is 0, return error message saying "ERROR connecting to server"
                sList.Clear();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
            return sList;

        }

        //adds student to DB and returns confirmation
        public bool addStudent(string n, string sn, Image img, DateTime dob, char g, string p, string a, List<int> mId )//*
        {
            bool success = false;
            int sID;
            SqlConnection sqlConn = new SqlConnection(connect);

            try
            {
                //Adds student with parameters
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spAddStudents", sqlConn);    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@N",n);
                    cmd.Parameters.AddWithValue("@SN", sn);
                    cmd.Parameters.AddWithValue("@IMG", convertImage(img));
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@G", g);
                    cmd.Parameters.AddWithValue("@P", p);
                    cmd.Parameters.AddWithValue("@A", a);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                    sqlConn.Close();
                }

                //Gets the Student_Number of the latest (previously inserted) student
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spGetLastId", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    sqlConn.Open();
                    sID = cmd.ExecuteNonQuery();
                }

                //Adds all modules acosiated with the student
                foreach (int m in mId){
                    addStudentModules(sID, m);
                }
                success = true;

            }
            catch (SqlException)
            {
                success = false;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return success;
        }

        //updates student to DB and returns confirmation
        public bool updateStudent(int id, string n, string sn, Image img, DateTime dob, char g, string p, string a, List<int> mId)
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            bool success = false;

            try
            {
                //Adds student with parameters
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spUpdateStudents", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@N", n);
                    cmd.Parameters.AddWithValue("@SN", sn);
                    cmd.Parameters.AddWithValue("@IMG", convertImage(img));
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@G", g);
                    cmd.Parameters.AddWithValue("@P", p);
                    cmd.Parameters.AddWithValue("@A", a);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }

                //Not sure how to update student modules, I'll take a look at it.
                //foreach (int m in mId)
                //{
                //    addStudentModules(sID, m);
                //}

                success = true;

            }
            catch (SqlException)
            {
                success = false;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return success;
        }

        //deletes student and returns confirmation
        public bool deleteStudent(int sNum)
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            bool success = false;

            try
            {
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spDeleteStudents", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@STUDENTID", sNum);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (SqlException)
            {
                success = false;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return success;
        }

        //Module DB access 
        
        //Reurns all moduless from the DB
        public List<Module> readModules()
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            List<Module> mList = new List<Module>();

            try
            {
                sqlConn.Open();
                string qSelect = "Select * from Modules";
                SqlCommand cmd = new SqlCommand(qSelect, sqlConn);

                using (var r = cmd.ExecuteReader())
                {                  
                    while (r.Read())
                    {
                        //Module_Code (Used to reduce new Module() function size, since it is used more than once)
                        int id = int.Parse(r[0].ToString());                       
                        
                        //Add current Module to list of Modules
                        mList.Add(new Module(id, r[1].ToString(), r[2].ToString(),r[3].ToString().Split(';').ToList() ));
                    }
                }
            }
            catch(SqlException)
            {
                //Check returned list count in Student BL layer, if count is 0, return error message saying "ERROR connecting to server"
                mList.Clear();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
            return mList;
        }

        //adds Module to DB and returns confirmation
        public bool addModule(int id, string n, string des, List<string> res)
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            bool success = false;

            try
            {
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spAddModules", sqlConn);    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@N",n);
                    cmd.Parameters.AddWithValue("@DES", des);
                    cmd.Parameters.AddWithValue("@RES", String.Join(";", res.ToArray()));

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (SqlException)
            {
                success = false;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return success;
        }

        //updates module to DB and returns confirmation
        public bool updateModule(int id, string n, string des, List<string> res)
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            bool success = false;

            try
            {
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spUpdateModules", sqlConn);    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@N",n);
                    cmd.Parameters.AddWithValue("@DES", des);
                    cmd.Parameters.AddWithValue("@RES", String.Join(";", res.ToArray()));

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (SqlException)
            {
                success = false;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return success;
        }

        //deletes module and returns confirmation
        public bool deleteModule(int mCode)
        {
            SqlConnection sqlConn = new SqlConnection(connect);
            bool success = false;

            try
            {
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spDeleteModules", sqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", mCode);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (SqlException)
            {
                success = false;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return success;
        }

    }
}
