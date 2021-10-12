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
        FormValidation validate = new FormValidation();
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

        private void dgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvModule.Rows[e.RowIndex];

                txtModuleCode.Text = row.Cells["Module_Code"].Value.ToString();
                txtModuleName.Text = row.Cells["Module_Name"].Value.ToString();
                rtbDescription.Text = row.Cells["Module_Description"].Value.ToString();
                rtbLinks.Text = row.Cells["Module_Resources"].Value.ToString();
               
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool flag = validate.ValidateModule(txtModuleName.Text, rtbDescription.Text, rtbLinks.Text);
            if (flag == true)
            {
                MessageBox.Show("Please fill in the empty boxes!", "Empty Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool flag = validate.ValidateModule(txtModuleName.Text, rtbDescription.Text, rtbLinks.Text);
            if (flag == true)
            {
                MessageBox.Show("Please fill in the empty boxes!", "Empty Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
