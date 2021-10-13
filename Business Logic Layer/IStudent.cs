using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PRG282_Project
{
    public interface IStudent
    {
        //Returns all module Names 
        List<string> getModuleNames();

        //Validates all student info to ensure that entered data is in the correct format, returns a suitable message
        string validation(string fn, string sn,Image i,DateTime dob, char g,string phone, string a);

        //References DH to insert student if criteria is met (C)
        string validateStudentInfo(Student s);

        //Fetches all students from DH (R)
        List<Student> getStudents();


        //confirms update and sends relevant message (U)
        string studentInfoChanged(Student s);

        //Deletes student and sends relevant message (D)
        string studentDeleted(int sNum);


        //returns the new filtered source for DGV according to search 
        List<Student> searchStudent(int studentNum);
        
    }
}
