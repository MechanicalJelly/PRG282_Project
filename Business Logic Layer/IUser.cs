using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG281_Project
{
    public interface IUser
    {
        //Checks all users against input, returns a boolean
        //readUsers()
        bool userLogin(string username, string pass);

        //references file handler to add user according to criteria 
        //addUser()
        string validateRegister(string username, string pass);
        
    }
}