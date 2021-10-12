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
    public partial class StudentDetails : Form
    {
        DataHandler handler = new DataHandler();
        FormValidation validate = new FormValidation();
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

                txtStudentNumber.Text = row.Cells["Student_Number"].Value.ToString();
                txtStudentName.Text = row.Cells["Student_Name"].Value.ToString();
                txtStudentSurname.Text = row.Cells["Student_Surname"].Value.ToString();
                pbxStudentImage.Image = (Image)row.Cells["Student_Image"].Value;
                dtpDOB.Value = Convert.ToDateTime(row.Cells["Student_DOB"].Value.ToString());
                txtGender.Text = row.Cells["Student_Gender"].Value.ToString();
                txtPhone.Text = row.Cells["Student_Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Student_Address"].Value.ToString();
                //clbModuleCodes.Items = row.Cells["Student_Address"].Value.ToString();
            }
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = handler.readStudents();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool flag = validate.ValidateStudent(txtStudentName.Text, txtStudentSurname.Text, txtGender.Text, txtPhone.Text, txtAddress.Text);

            if (flag == true)
            {
                MessageBox.Show("Please fill in the empty boxes!", "Empty Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           bool flag = validate.ValidateStudent(txtStudentName.Text, txtStudentSurname.Text, txtGender.Text, txtPhone.Text, txtAddress.Text);

            if (flag == true)
            {
                MessageBox.Show("Please fill in the empty boxes!","Empty Boxes",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
