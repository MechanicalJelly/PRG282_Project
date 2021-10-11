
namespace Group_9_Assignment_1
{
    partial class StudentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetails));
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateDelete = new System.Windows.Forms.Label();
            this.btnStudentImage = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblModuleCodes = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentDOB = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.clbModuleCodes = new System.Windows.Forms.CheckedListBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pbxStudentImage = new System.Windows.Forms.PictureBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.gbxStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStudent
            // 
            this.gbxStudent.Controls.Add(this.dtpDOB);
            this.gbxStudent.Controls.Add(this.lblUpdateDelete);
            this.gbxStudent.Controls.Add(this.btnStudentImage);
            this.gbxStudent.Controls.Add(this.lblSearch);
            this.gbxStudent.Controls.Add(this.txtSearch);
            this.gbxStudent.Controls.Add(this.btnSearch);
            this.gbxStudent.Controls.Add(this.btnBack);
            this.gbxStudent.Controls.Add(this.btnRead);
            this.gbxStudent.Controls.Add(this.btnDelete);
            this.gbxStudent.Controls.Add(this.btnUpdate);
            this.gbxStudent.Controls.Add(this.lblModuleCodes);
            this.gbxStudent.Controls.Add(this.txtAddress);
            this.gbxStudent.Controls.Add(this.txtPhone);
            this.gbxStudent.Controls.Add(this.txtGender);
            this.gbxStudent.Controls.Add(this.lblAddress);
            this.gbxStudent.Controls.Add(this.lblPhone);
            this.gbxStudent.Controls.Add(this.lblGender);
            this.gbxStudent.Controls.Add(this.txtStudentSurname);
            this.gbxStudent.Controls.Add(this.txtStudentName);
            this.gbxStudent.Controls.Add(this.lblStudentDOB);
            this.gbxStudent.Controls.Add(this.lblStudentSurname);
            this.gbxStudent.Controls.Add(this.lblStudentName);
            this.gbxStudent.Controls.Add(this.clbModuleCodes);
            this.gbxStudent.Controls.Add(this.txtStudentNumber);
            this.gbxStudent.Controls.Add(this.lblStudentNumber);
            this.gbxStudent.Controls.Add(this.btnInsert);
            this.gbxStudent.Controls.Add(this.pbxStudentImage);
            this.gbxStudent.Controls.Add(this.dgvStudent);
            this.gbxStudent.Location = new System.Drawing.Point(13, 12);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(872, 511);
            this.gbxStudent.TabIndex = 0;
            this.gbxStudent.TabStop = false;
            this.gbxStudent.Text = "Student Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(141, 372);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(150, 20);
            this.dtpDOB.TabIndex = 58;
            this.dtpDOB.Value = new System.DateTime(2021, 11, 2, 0, 0, 0, 0);
            // 
            // lblUpdateDelete
            // 
            this.lblUpdateDelete.AutoSize = true;
            this.lblUpdateDelete.Location = new System.Drawing.Point(30, 490);
            this.lblUpdateDelete.Name = "lblUpdateDelete";
            this.lblUpdateDelete.Size = new System.Drawing.Size(435, 13);
            this.lblUpdateDelete.TabIndex = 57;
            this.lblUpdateDelete.Text = "Use the boxes above to update student details and use the search box to delete a " +
    "student.";
            // 
            // btnStudentImage
            // 
            this.btnStudentImage.Location = new System.Drawing.Point(696, 206);
            this.btnStudentImage.Name = "btnStudentImage";
            this.btnStudentImage.Size = new System.Drawing.Size(93, 27);
            this.btnStudentImage.TabIndex = 56;
            this.btnStudentImage.Text = "Upload Image";
            this.btnStudentImage.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(412, 392);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(172, 13);
            this.lblSearch.TabIndex = 55;
            this.lblSearch.Text = "Use Student number for the search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(423, 369);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 20);
            this.txtSearch.TabIndex = 54;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(321, 368);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 20);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(720, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 35);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(208, 435);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(124, 35);
            this.btnRead.TabIndex = 51;
            this.btnRead.Text = "Read Student";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(555, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 35);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(384, 435);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 35);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblModuleCodes
            // 
            this.lblModuleCodes.AutoSize = true;
            this.lblModuleCodes.Location = new System.Drawing.Point(616, 253);
            this.lblModuleCodes.Name = "lblModuleCodes";
            this.lblModuleCodes.Size = new System.Drawing.Size(75, 13);
            this.lblModuleCodes.TabIndex = 48;
            this.lblModuleCodes.Text = "Module Codes";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(423, 330);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 20);
            this.txtAddress.TabIndex = 47;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(423, 288);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 46;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(423, 250);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(150, 20);
            this.txtGender.TabIndex = 45;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(336, 333);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 44;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(336, 291);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(336, 253);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 42;
            this.lblGender.Text = "Gender";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(141, 330);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(150, 20);
            this.txtStudentSurname.TabIndex = 40;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(141, 288);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(150, 20);
            this.txtStudentName.TabIndex = 39;
            // 
            // lblStudentDOB
            // 
            this.lblStudentDOB.AutoSize = true;
            this.lblStudentDOB.Location = new System.Drawing.Point(30, 372);
            this.lblStudentDOB.Name = "lblStudentDOB";
            this.lblStudentDOB.Size = new System.Drawing.Size(68, 13);
            this.lblStudentDOB.TabIndex = 38;
            this.lblStudentDOB.Text = "Date Of Birth";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Location = new System.Drawing.Point(30, 333);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(89, 13);
            this.lblStudentSurname.TabIndex = 37;
            this.lblStudentSurname.Text = "Student Surname";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(30, 291);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 36;
            this.lblStudentName.Text = "Student Name";
            // 
            // clbModuleCodes
            // 
            this.clbModuleCodes.FormattingEnabled = true;
            this.clbModuleCodes.Items.AddRange(new object[] {
            "PRG281",
            "PRG282",
            "PRG283"});
            this.clbModuleCodes.Location = new System.Drawing.Point(707, 250);
            this.clbModuleCodes.Name = "clbModuleCodes";
            this.clbModuleCodes.Size = new System.Drawing.Size(156, 94);
            this.clbModuleCodes.TabIndex = 35;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(141, 250);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(150, 20);
            this.txtStudentNumber.TabIndex = 34;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(30, 253);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNumber.TabIndex = 33;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(33, 435);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 35);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Insert Student";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // pbxStudentImage
            // 
            this.pbxStudentImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxStudentImage.Image")));
            this.pbxStudentImage.Location = new System.Drawing.Point(635, 19);
            this.pbxStudentImage.Name = "pbxStudentImage";
            this.pbxStudentImage.Size = new System.Drawing.Size(228, 181);
            this.pbxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStudentImage.TabIndex = 31;
            this.pbxStudentImage.TabStop = false;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(15, 19);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(569, 196);
            this.dgvStudent.TabIndex = 30;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 534);
            this.Controls.Add(this.gbxStudent);
            this.Name = "StudentDetails";
            this.Text = "Student Details";
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudent;
        private System.Windows.Forms.Label lblUpdateDelete;
        private System.Windows.Forms.Button btnStudentImage;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblModuleCodes;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentDOB;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.CheckedListBox clbModuleCodes;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.PictureBox pbxStudentImage;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}