using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class StudentDetails : Form
    {
        Student student = new Student();
        Module module = new Module();
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudent.Rows[e.RowIndex];

                txtStudentNumber.Text = row.Cells["StudentNum"].Value.ToString();
                txtStudentName.Text = row.Cells["Firstname"].Value.ToString();
                txtStudentSurname.Text = row.Cells["Surname"].Value.ToString();
                pbxStudentImage.Image = (Image)row.Cells["ImgUrl"].Value;
                dtpDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value.ToString());
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                //clbModuleCodes.Items.Add(row.Cells["StudentModules"].Value.ToString());

                foreach (int mi in student.getStudentModules(int.Parse(txtStudentNumber.Text)))
                {
                    MessageBox.Show(mi.ToString());
                    if (clbModuleCodes.Items.Contains(mi))
                    {
                        clbModuleCodes.SetItemChecked(mi, true);
                    }
                }
            }
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {           
            dgvStudent.DataSource = student.getStudents();
            clbModuleCodes.Items.Clear();

            foreach (string mn in student.getModuleNames())
            {
                clbModuleCodes.Items.Add(mn);
            }

            this.dgvStudent.Columns["ImgUrl"].Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            List<int> modules = new List<int>(clbModuleCodes.CheckedItems.Cast<int>());
            string insert = student.validateStudentInfo(new Student(int.Parse(txtStudentNumber.Text), txtStudentName.Text, txtStudentSurname.Text, pbxStudentImage.Image, dtpDOB.Value, Convert.ToChar(txtGender.Text), txtPhone.Text, txtAddress.Text, modules));

            MessageBox.Show(insert, "Insert Student Info.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = student.getStudents();
            foreach (var module1 in module.getModules())
            {
                clbModuleCodes.Items.Add(module1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<int> modules = new List<int>(clbModuleCodes.CheckedItems.Cast<int>());
            string update = student.studentInfoChanged(new Student(int.Parse(txtStudentNumber.Text), txtStudentName.Text, txtStudentSurname.Text, pbxStudentImage.Image, dtpDOB.Value, Convert.ToChar(txtGender.Text), txtPhone.Text, txtAddress.Text,modules));

            MessageBox.Show(update, "Update Student Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           MessageBox.Show(student.studentDeleted(int.Parse(txtSearch.Text)),"Student Delete.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           dgvStudent.DataSource = student.searchStudent(int.Parse(txtSearch.Text));
        }

        private void btnStudentImage_Click(object sender, EventArgs e)
        {
            string filename;
            using (OpenFileDialog odf = new OpenFileDialog() { Filter = "Images|*.jpg;*.png;*.jpeg", ValidateNames = true, Multiselect = false })
            {
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    filename = odf.FileName;
                    pbxStudentImage.Image = Image.FromFile(filename);
                    string name = Path.GetFileName(filename);
                    pbxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
