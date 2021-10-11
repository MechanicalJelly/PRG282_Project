using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    class FileHandler
    {
        string path = "Users.txt";
        public string checkConnection()
        {
            if (MessageBox.Show("Do you want to check the file connection?", "Connection Status.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (!File.Exists(path))
                {
                    var myFile = File.CreateText(path);
                    myFile.Close();
                }   
                else
                    return "The file already exist.";
                return path + " is created.";
            }
            return "Please continue.";
        }

        public bool UserRegister(string username, string password)
        {
            StreamReader sr = File.OpenText(path);
            string s;
            bool flag = false;

            while ((s = sr.ReadLine()) != null)
            {
                string[] user = s.Split(',');
                if (user[0] == username && user[1] == password)
                {
                    flag = true;
                    return flag;
                }
            }
            sr.Close();

            string content = username + "," + password;
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(content);
            sw.Close();

            return flag;
        }

        public bool UserLogin(string username, string password)
        {
            StreamReader sr = File.OpenText(path);
            string s = "";
            bool flag = false;
            try
            {
                while ((s = sr.ReadLine()) != null)
                {
                    string[] content = s.Split(',');
                    if (content[0] == username && content[1] == password)
                    {
                        flag = true;
                    }
                }

                sr.Close();

                if (flag == false)
                {
                    throw new Exception();
                }
                else
                {
                    Menu m = new Menu();
                    m.Show();
                    
                    return flag;
                }
            }
            catch (Exception)
            {
                return flag;
            }
        }
    }
}
