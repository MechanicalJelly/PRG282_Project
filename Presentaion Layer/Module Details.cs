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
    public partial class ModuleDetails : Form
    {
        DataHandler handler = new DataHandler();
        public ModuleDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void ModuleDetails_Load(object sender, EventArgs e)
        {
            dgvModule.DataSource = handler.readModules();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvModule.Rows[e.RowIndex];

                txtModuleCode.Text = row.Cells["Module_Code"].Value.ToString();
                txtStudentName.Text = row.Cells["Module_Name"].Value.ToString();
                rtbDescription.Text = row.Cells["Module_Description"].Value.ToString();
                rtbLinks.Text = row.Cells["Module_Resources"].Value.ToString();
            }
        }
    }
}
