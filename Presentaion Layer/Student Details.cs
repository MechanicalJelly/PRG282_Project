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

        //Please remove or edit as you see fit De Wet
        public void checkStudentModules(List<int> ml)
        {
            for (int i = 0; i< clbModuleCodes.Items.Count; i++)
            {
                 clbModuleCodes.SetItemChecked(i, false);
            }
            foreach (int mi in ml)
            {
                clbModuleCodes.SetItemChecked(mi, true);
            }   
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

                checkStudentModules(student.getStudentModules(int.Parse(txtStudentNumber.Text)));
                
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
            List<int> indexList = new List<int>();

            for (int i = 0; i < clbModuleCodes.Items.Count; i++)
            {
                if (this.clbModuleCodes.GetItemCheckState(i) == CheckState.Checked)
                {
                    indexList.Add(i+1);
                }
            }

            string insert = student.validateStudentInfo(new Student(int.Parse(txtStudentNumber.Text), txtStudentName.Text, txtStudentSurname.Text, pbxStudentImage.Image, dtpDOB.Value, Convert.ToChar(txtGender.Text), txtPhone.Text, txtAddress.Text, indexList));
            
            int lastID = int.Parse(dgvStudent.Rows[dgvStudent.Rows.Count-1].Cells["StudentNum"].Value.ToString());
                        MessageBox.Show(lastID.ToString());
            student.addStudentModules((lastID +1),indexList);

            MessageBox.Show(insert, "Insert Student Info.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = student.getStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<int> indexList = new List<int>();

            for (int i = 0; i < clbModuleCodes.Items.Count; i++)
            {
                if (this.clbModuleCodes.GetItemCheckState(i) == CheckState.Checked)
                {
                    indexList.Add(i+1);
                }
            }
            string update = student.studentInfoChanged(new Student(int.Parse(txtStudentNumber.Text), txtStudentName.Text, txtStudentSurname.Text, pbxStudentImage.Image, dtpDOB.Value, Convert.ToChar(txtGender.Text), txtPhone.Text, txtAddress.Text,indexList));

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
