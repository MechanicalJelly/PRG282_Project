using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace PRG282_Project
{
    public class Student : IStudent
    {

        int studentNum;
        string firstName;
        string surname;
        Image imgUrl;
        DateTime dateOfBirth;
        char gender;
        string phoneNumber;
        string address;

        static DataHandler handle = new DataHandler();
        List<int> studentModules = new List<int>();
        List<Student> students = new List<Student>();

        public Student() { }

        public Student(int studentNum, string firstName, string surname, Image imgUrl, DateTime dateOfBirth, char gender, string phoneNumber, string address, List<int> modules)
        {
            this.studentNum = studentNum;
            this.firstName = firstName;
            this.surname = surname;
            this.imgUrl = imgUrl;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.studentModules = modules;
        }

        public int StudentNum { get => studentNum; set => studentNum = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Surname { get => surname; set => surname = value; }
        public Image ImgUrl { get => imgUrl; set => imgUrl = value; }//*
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public char Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public List<int> StudentModules { get => studentModules; set => studentModules = value; }

       
       //Validates all student info to ensure that entered data is in the correct format, returns a suitable message
       public string validation(string fn, string sn,Image i,DateTime dob, char g,string phone, string a)
        {

            if (string.IsNullOrEmpty(fn))
            {
                return "Empty!!Enter a firstname!!";
            }
            else if (string.IsNullOrEmpty(sn))
            {
                return "Empty!!Enter a surname!!";
            }
            else if (i.Equals(null))
            {
                return "Empty!!Import image!!";
            }
           /* else if (dob.)
            {
                return "Empty!!Enter a date!!";
            }*/
            else if (!g.Equals('M') || !g.Equals('F'))
            {
                return "Error!!Enter  M or F!!";
            }
            else if ((phone.Length != 10))
            {
                return "Error!!Enter only 10 digits!!";
            }
            else if (string.IsNullOrEmpty(a))
            {
                return "Empty!!Enter address!!";
            }
            else
            {
                return "Successful validation";
            }

        }

        //[C] Runs validation, if everything is correct, attempts to insert student and returns a suitable message
        public string validateStudentInfo(Student s)
        {

            string msg = validation(s.FirstName, s.Surname, s.ImgUrl, s.DateOfBirth, s.Gender, s.PhoneNumber, s.Address);
            if (msg[0].Equals("E"))//alles begin met e
            {
                return msg;
            }
            else
            {
                if (handle.addStudent(s.FirstName, s.Surname, s.ImgUrl, s.DateOfBirth, s.Gender, s.PhoneNumber, s.Address, s.studentModules))
                    return "New Student has been added.";
                else
                    return "Student could not be added.";
            }
                    
        }

        //[R] Reads and returns all students in the DB
        public List<Student> getStudents()
        {            
            return handle.readStudents();
        }

        //[U] Runs validation, if everything is correct, attempts to update student info and returns a suitable message
        public string studentInfoChanged(Student s)
        {
 
            string msg = validation(s.FirstName, s.Surname, s.ImgUrl, s.DateOfBirth, s.Gender, s.PhoneNumber, s.Address);
            if (msg[0].Equals("E"))//alles begin met e
            {
                return msg;
            }
            else
            {

                DataHandler handle = new DataHandler();
                if (handle.updateStudent(s.StudentNum, s.FirstName, s.Surname, s.ImgUrl, s.DateOfBirth, s.Gender, s.PhoneNumber, s.Address, s.studentModules))
                {
                    return "Student with id: " + s.StudentNum + ", has been updated.";
                }
                else
                {
                    return "fail to update";
                }
            }

        }
       
        //[D] Deletes a student in the DB based on their ID
        public string studentDeleted(int sNum)
        {
        
            DataHandler handle = new DataHandler();
            if (handle.deleteStudent(sNum))
            {
                return "Student with id: " + sNum + ", has been deleted.";
            }
            else
            {
                return "fail to delete";
            }
            
        }

       //[S] Finds a Student_Num in a list of all the students
        public List<Student> searchStudent(int studentNum)
        { 
            List<Student> allList = handle.readStudents();
            List<Student> newList = new List<Student>();

            foreach (Student s in allList)
            {
                if (s.StudentNum.Equals(studentNum))
                {
                    newList.Add(new Student(s.StudentNum, s.FirstName, s.Surname, s.ImgUrl, s.DateOfBirth, s.Gender, s.PhoneNumber, s.Address,s.studentModules));
                }
            }
            return newList;
        }


    
        public int CompareTo(Student other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }
       
    }
}
