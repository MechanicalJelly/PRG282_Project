
namespace Group_9_Assignment_1
{
    partial class Menu
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
            this.gbxMenu = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.gbxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMenu
            // 
            this.gbxMenu.Controls.Add(this.btnLogOut);
            this.gbxMenu.Controls.Add(this.btnModule);
            this.gbxMenu.Controls.Add(this.btnStudent);
            this.gbxMenu.Location = new System.Drawing.Point(12, 12);
            this.gbxMenu.Name = "gbxMenu";
            this.gbxMenu.Size = new System.Drawing.Size(317, 188);
            this.gbxMenu.TabIndex = 0;
            this.gbxMenu.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(51, 130);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(217, 37);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnModule
            // 
            this.btnModule.Location = new System.Drawing.Point(51, 75);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(217, 37);
            this.btnModule.TabIndex = 1;
            this.btnModule.Text = "Module Details";
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(51, 19);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(217, 37);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student Details";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 212);
            this.Controls.Add(this.gbxMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.gbxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMenu;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnLogOut;
    }
}