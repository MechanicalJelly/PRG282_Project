
namespace Group_9_Assignment_1
{
    partial class ModuleDetails
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
            this.gbxModule = new System.Windows.Forms.GroupBox();
            this.rtbLinks = new System.Windows.Forms.RichTextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblUpdateDelete = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblLinks = new System.Windows.Forms.Label();
            this.lblModuleDescription = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.gbxModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxModule
            // 
            this.gbxModule.Controls.Add(this.rtbLinks);
            this.gbxModule.Controls.Add(this.rtbDescription);
            this.gbxModule.Controls.Add(this.lblUpdateDelete);
            this.gbxModule.Controls.Add(this.lblSearch);
            this.gbxModule.Controls.Add(this.txtSearch);
            this.gbxModule.Controls.Add(this.btnSearch);
            this.gbxModule.Controls.Add(this.btnBack);
            this.gbxModule.Controls.Add(this.btnRead);
            this.gbxModule.Controls.Add(this.btnDelete);
            this.gbxModule.Controls.Add(this.btnUpdate);
            this.gbxModule.Controls.Add(this.txtStudentName);
            this.gbxModule.Controls.Add(this.lblLinks);
            this.gbxModule.Controls.Add(this.lblModuleDescription);
            this.gbxModule.Controls.Add(this.lblModuleName);
            this.gbxModule.Controls.Add(this.txtModuleCode);
            this.gbxModule.Controls.Add(this.lblModuleCode);
            this.gbxModule.Controls.Add(this.btnInsert);
            this.gbxModule.Controls.Add(this.dgvModule);
            this.gbxModule.Location = new System.Drawing.Point(13, 13);
            this.gbxModule.Name = "gbxModule";
            this.gbxModule.Size = new System.Drawing.Size(752, 564);
            this.gbxModule.TabIndex = 0;
            this.gbxModule.TabStop = false;
            this.gbxModule.Text = "Module Details";
            // 
            // rtbLinks
            // 
            this.rtbLinks.Location = new System.Drawing.Point(164, 397);
            this.rtbLinks.Name = "rtbLinks";
            this.rtbLinks.Size = new System.Drawing.Size(236, 64);
            this.rtbLinks.TabIndex = 77;
            this.rtbLinks.Text = "";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(164, 327);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(236, 64);
            this.rtbDescription.TabIndex = 76;
            this.rtbDescription.Text = "";
            // 
            // lblUpdateDelete
            // 
            this.lblUpdateDelete.AutoSize = true;
            this.lblUpdateDelete.Location = new System.Drawing.Point(32, 531);
            this.lblUpdateDelete.Name = "lblUpdateDelete";
            this.lblUpdateDelete.Size = new System.Drawing.Size(482, 13);
            this.lblUpdateDelete.TabIndex = 75;
            this.lblUpdateDelete.Text = "Use the boxes above to update and insert module details and use the search box to" +
    " delete a module.";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(132, 505);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(160, 13);
            this.lblSearch.TabIndex = 74;
            this.lblSearch.Text = "Use Module Code for the search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(143, 482);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 20);
            this.txtSearch.TabIndex = 73;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(35, 481);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 20);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Search Module";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(505, 372);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 35);
            this.btnBack.TabIndex = 71;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(576, 242);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(124, 35);
            this.btnRead.TabIndex = 70;
            this.btnRead.Text = "Read Module";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(576, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 35);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Delete Module";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(417, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 35);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update Module";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(164, 288);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(150, 20);
            this.txtStudentName.TabIndex = 65;
            // 
            // lblLinks
            // 
            this.lblLinks.AutoSize = true;
            this.lblLinks.Location = new System.Drawing.Point(32, 394);
            this.lblLinks.Name = "lblLinks";
            this.lblLinks.Size = new System.Drawing.Size(126, 13);
            this.lblLinks.TabIndex = 64;
            this.lblLinks.Text = "Links to Online resources";
            // 
            // lblModuleDescription
            // 
            this.lblModuleDescription.AutoSize = true;
            this.lblModuleDescription.Location = new System.Drawing.Point(30, 330);
            this.lblModuleDescription.Name = "lblModuleDescription";
            this.lblModuleDescription.Size = new System.Drawing.Size(98, 13);
            this.lblModuleDescription.TabIndex = 63;
            this.lblModuleDescription.Text = "Module Description";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(30, 291);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(73, 13);
            this.lblModuleName.TabIndex = 62;
            this.lblModuleName.Text = "Module Name";
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(164, 250);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(150, 20);
            this.txtModuleCode.TabIndex = 61;
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(30, 253);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(70, 13);
            this.lblModuleCode.TabIndex = 60;
            this.lblModuleCode.Text = "Module Code";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(417, 242);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(124, 35);
            this.btnInsert.TabIndex = 59;
            this.btnInsert.Text = "Insert Module";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // dgvModule
            // 
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Location = new System.Drawing.Point(15, 19);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.Size = new System.Drawing.Size(721, 196);
            this.dgvModule.TabIndex = 58;
            // 
            // ModuleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 586);
            this.Controls.Add(this.gbxModule);
            this.Name = "ModuleDetails";
            this.Text = "Module Details";
            this.gbxModule.ResumeLayout(false);
            this.gbxModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxModule;
        private System.Windows.Forms.Label lblUpdateDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblLinks;
        private System.Windows.Forms.Label lblModuleDescription;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.RichTextBox rtbLinks;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}