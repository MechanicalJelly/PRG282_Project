using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    class FormValidation
    {
        public FormValidation() { }

        public bool ValidateStudent(string n, string s, string g, string p, string a)
        {
            bool flag = false;
            if (n == null || s == null || g == null || p == null || a == null)
            {
                flag = true;
                return flag;
            }
            else
                return flag;
        }

        public void ValidateModule()
        {

        }
    }
}
