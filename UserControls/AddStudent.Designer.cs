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
            this.btnSub = new System.Windows.Forms.Button();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.txtBday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(670, 932);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(274, 63);
            this.btnSub.TabIndex = 24;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
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
            this.cmbCourse.Location = new System.Drawing.Point(392, 777);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(354, 32);
            this.cmbCourse.TabIndex = 23;
            // 
            // datePick
            // 
            this.datePick.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Location = new System.Drawing.Point(792, 657);
            this.datePick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(352, 31);
            this.datePick.TabIndex = 22;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 718);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 605);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 466);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Student ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(392, 500);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(796, 62);
            this.txtName.TabIndex = 17;
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(392, 360);
            this.txtStuID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStuID.Multiline = true;
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(796, 62);
            this.txtStuID.TabIndex = 16;
            // 
            // txtBday
            // 
            this.txtBday.Location = new System.Drawing.Point(392, 641);
            this.txtBday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBday.Multiline = true;
            this.txtBday.Name = "txtBday";
            this.txtBday.Size = new System.Drawing.Size(368, 62);
            this.txtBday.TabIndex = 25;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBday);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStuID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1635, 1165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.TextBox txtBday;
    }
}
