using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PRG282_Project
{
    public class Student : IStudent
    {

        int studentNum;
        string firstName;
        string surname;
        Image imgUrl;//*
        DateTime dateOfBirth;
        char gender;
        string phoneNumber;
        string address;

        static DataHandler handle = new DataHandler();
        List<Module> studentModules = new List<Module>();
        List<Student> students = new List<Student>();

        public Student() { }
        public Student(int studentNum, string firstName, string surname, Image imgUrl, DateTime dateOfBirth, char gender, string phoneNumber, string address, List<Module> modules)
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


        //Student validation
       //public string checkphone(string phone)
       // {
       //     if (s.phonenumber.length() != 10) { return "phone number is not the correct length"; }
       // }

        //References DH to insert student (C)
        public string validateStudentInfo(Student s)
        {
            
            List<int> modules = new List<int>();
            //modules.Add(1);
            //modules.Add(3);
            //modules.Add(5);

            //do validation of student info here 
            //ex. if(s.PhoneNumber.Length() != 10){ return "Phone number is not the correct length"}

            // Do research on how to load image from local machine to add student image into DB (Gallery excercise)

            if (handle.addStudent(s.FirstName,s.Surname,s.ImgUrl,s.DateOfBirth,s.Gender,s.PhoneNumber,s.Address, modules))
                return "New Student has been added.";
            else
                return "Student could not be added.";
                    
        }

        //Fetches all students from DH (R)
        public List<Student> getStudents()
        {
            DataHandler handle = new DataHandler();
            return handle.readStudents();
        }

        //confirms update (U)
        public string studentInfoChanged(Student s)
        {
            DataHandler handle = new DataHandler();
            return "Student with id: "+", has been updated.";
        }
        //Deletes student (D)
        public string studentDeleted(int sNum)
        {
            return "Student Deleted";
        }

        //returns the new filtered source for DGV 
        public List<Student> searchStudent(int studentNum)
        {
            return new List<Student>();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}