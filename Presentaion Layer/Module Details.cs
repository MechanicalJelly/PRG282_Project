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
            dgvModule.DataSource = module.getModules();
        }

        private void dgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvModule.Rows[e.RowIndex];

                txtModuleCode.Text = row.Cells["ModuleCode"].Value.ToString();
                txtModuleName.Text = row.Cells["ModuleName"].Value.ToString();
                rtbDescription.Text = row.Cells["Description"].Value.ToString();

                List<string> res = (row.Cells["Resources"].Value.ToString()).Split(';').ToList();
                foreach(string r in res)
                {
                    rtbLinks.Text += Environment.NewLine + r;
                }
               
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] resourceList = rtbLinks.Lines;
            string res =  string.Join(";", resourceList);

            string insert = module.validateModuleInfo(new Module(int.Parse(txtModuleCode.Text), txtModuleName.Text, rtbDescription.Text, res));

            MessageBox.Show(insert,"Insert Module Info.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] resourceList = rtbLinks.Lines;
            string res =  string.Join(";", resourceList);
            
            string update = module.moduleInfoChanged(new Module(int.Parse(txtModuleCode.Text), txtModuleName.Text, rtbDescription.Text, res));

            MessageBox.Show(update, "Update Module Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(module.moduleDeleted(int.Parse(txtSearch.Text)), "Student Delete.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = module.getModules();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = module.searchModule(int.Parse(txtSearch.Text));
        }
    }
}
