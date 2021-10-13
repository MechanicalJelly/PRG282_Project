using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace PRG282_Project
{
    public class DataHandler
    {
        static string connect = @"Data Source=freeseball-PC;Initial Catalog=Milestone2_DB;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connect);
        static bool success = false;

        //General Code
        public byte[] convertImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imgArr, 0, imgArr.Length);

            return imgArr;
        }

        //StudentModules DB
        //SQL query that finds all modules linked to a student Num
        public List<Module> readStudentModules(int Num)
        {
            List<Module> mList = new List<Module>();
            
            try
            {
                sqlConn.Open();
                string qModules = "SELECT * FROM Modules  WHERE Module_Code IN (SELECT Module_Code FROM StudentModules WHERE Student_Number = 1)";
                SqlCommand cmd = new SqlCommand(qModules, sqlConn);

                using (var r = cmd.ExecuteReader())
                {

                    while (r.Read())
                    {
                        //Module_Code (Used to reduce new Module size)
                        int id = int.Parse(r[0].ToString());

                        //Add current Module to list of Modules
                        mList.Add(new Module(id, r[1].ToString(), r[2].ToString(), r[3].ToString().Split(';').ToList()));
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
        //Finds a student based on their Student_Number
        public List<Student> searchStudents(int sNum)//this will send a data source for the DGV, remember to refresh DGV Source when done with search
        {
            List<Student> sList = new List<Student>();
            Image img = null;

            try
            {
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spSearchStudents", sqlConn);    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID",sNum);

                    sqlConn.Open();
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
            }
            catch(SqlException ex)
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

        //Reurns all students from the DB
        public List<Student> readStudents()
        {
            List<Student> sList = new List<Student>();
            Image img = null;

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
            catch(SqlException ex)
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
            int sID;

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
            catch (SqlException ex)
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
            catch (SqlException ex)
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
            catch (SqlException ex)
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
        //Finds Module Based on Module_Code
        public List<Student> searchStudents(int mId)//this will send a data source for the DGV, remember to refresh DGV Source when done with search
        {
            List<Module> mList = new List<Module>();

            try
            {
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spSearchModules", sqlConn);    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID",mId);

                    sqlConn.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            //student_Number (Used to reduce new studetn function size, since it is used more than once)
                            int id = int.Parse(r[0].ToString());

                            //Add current module to list of modules
                            mList.Add(new Module(id, r[1].ToString(), r[2].ToString(), r[3].ToString().Split(';').ToList()  ));
                        }
                    }                  
                }
            }
            catch(SqlException ex)
            {
                //Check returned list count in Module BL layer, if count is 0, return error message saying "ERROR connecting to server"
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

        //Reurns all moduless from the DB
        public List<Module> readModules()
        {
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
            catch(SqlException ex)
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
            try
            {
                //Adds module with parameters
                using (sqlConn)
                {
                    SqlCommand cmd = new SqlCommand("spAddModules", sqlConn);    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@N",n);
                    cmd.Parameters.AddWithValue("@DES", sn);
                    cmd.Parameters.AddWithValue("@RES", String.Join(";", res.ToArray()););

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (SqlException ex)
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
        public bool updateModule(Student s)
        {
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
            catch (SqlException ex)
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
        public bool deleteModule(string mCode)
        {
            return true;
        }

    }
}
