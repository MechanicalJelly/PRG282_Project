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
        Module module = new Module();
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
            dgvModule.DataSource = module.getModuless();
        }

        private void dgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvModule.Rows[e.RowIndex];

                txtModuleCode.Text = row.Cells["ModuleCode"].Value.ToString();
                txtModuleName.Text = row.Cells["ModuleName"].Value.ToString();
                rtbDescription.Text = row.Cells["Description"].Value.ToString();
                //rtbLinks.Text = row.Cells["Module_Resources"].Value.ToString();
               
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            List<string> resources = new List<string>();
            resources.Add(rtbLinks.Text);
            string insert = module.validateModuleInfo(new Module(int.Parse(txtModuleCode.Text), txtModuleName.Text, rtbDescription.Text,resources));

            MessageBox.Show(insert,"Insert Module Info.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> resources = new List<string>();
            resources.Add(rtbLinks.Text);
            string update = module.moduleInfoChanged(new Module(int.Parse(txtModuleCode.Text), txtModuleName.Text, rtbDescription.Text, resources));

            MessageBox.Show(update, "Update Module Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(module.moduleDeleted(int.Parse(txtSearch.Text)), "Student Delete.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = module.getModuless();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = module.searchModule(int.Parse(txtSearch.Text));
        }
    }
}
