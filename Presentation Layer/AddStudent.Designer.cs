namespace PRG282_Project.UserControls
{
    partial class AddStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.txtBday = new System.Windows.Forms.TextBox();
            this.btnSub = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cmbCourse
            // 
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Bachelors of IT",
            "Bachelors of Computing",
            "Diploma in IT",
            "IT Certificate"});
            this.cmbCourse.Location = new System.Drawing.Point(276, 374);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(237, 25);
            this.cmbCourse.TabIndex = 23;
            // 
            // datePick
            // 
            this.datePick.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Location = new System.Drawing.Point(543, 296);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(236, 23);
            this.datePick.TabIndex = 22;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourse.Location = new System.Drawing.Point(273, 336);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(61, 19);
            this.lblCourse.TabIndex = 21;
            this.lblCourse.Text = "Course";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDOB.Location = new System.Drawing.Point(273, 262);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(107, 19);
            this.lblDOB.TabIndex = 20;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(273, 172);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStudentID.Location = new System.Drawing.Point(273, 78);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(90, 19);
            this.lblStudentID.TabIndex = 18;
            this.lblStudentID.Text = "Student ID";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(276, 194);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(532, 34);
            this.txtName.TabIndex = 17;
            // 
            // txtStuID
            // 
            this.txtStuID.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuID.Location = new System.Drawing.Point(276, 103);
            this.txtStuID.Multiline = true;
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(532, 34);
            this.txtStuID.TabIndex = 16;
            // 
            // txtBday
            // 
            this.txtBday.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBday.Location = new System.Drawing.Point(276, 286);
            this.txtBday.Multiline = true;
            this.txtBday.Name = "txtBday";
            this.txtBday.Size = new System.Drawing.Size(247, 34);
            this.txtBday.TabIndex = 25;
            // 
            // btnSub
            // 
            this.btnSub.BorderColor = System.Drawing.Color.Gold;
            this.btnSub.BorderThickness = 2;
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSub.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSub.ForeColor = System.Drawing.Color.Gold;
            this.btnSub.Location = new System.Drawing.Point(456, 453);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(183, 41);
            this.btnSub.TabIndex = 48;
            this.btnSub.Text = "Submit";
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtBday);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStuID);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1090, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.TextBox txtBday;
        private Guna.UI2.WinForms.Guna2Button btnSub;
    }
}
