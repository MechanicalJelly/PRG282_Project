using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDetails sd = new StudentDetails();
            sd.Show();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModuleDetails md = new ModuleDetails();
            md.Show();
        }
    }
}
