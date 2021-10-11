using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG281_Project
{
    public class User: IUser
    {
        string username;
        string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        //Login Validation
        public bool userLogin(string username, string pass)
        {
            return true;
        }


        //references file handler to add user according to criteria
        public string validateRegister(string username, string pass)
        {
            return "User: "+ username + " registered.";
        }
    }
}