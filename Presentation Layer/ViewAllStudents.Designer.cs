namespace PRG282_Project.UserControls
{
    partial class ViewAllStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllStudents));
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStuSearch = new System.Windows.Forms.TextBox();
            this.viewStudents = new System.Windows.Forms.DataGridView();
            this.btnGenSum = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.imgRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStudentID.Location = new System.Drawing.Point(872, 71);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(90, 19);
            this.lblStudentID.TabIndex = 43;
            this.lblStudentID.Text = "Student ID";
            // 
            // txtStuSearch
            // 
            this.txtStuSearch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuSearch.Location = new System.Drawing.Point(854, 107);
            this.txtStuSearch.Multiline = true;
            this.txtStuSearch.Name = "txtStuSearch";
            this.txtStuSearch.Size = new System.Drawing.Size(142, 31);
            this.txtStuSearch.TabIndex = 42;
            // 
            // viewStudents
            // 
            this.viewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStudents.Location = new System.Drawing.Point(162, 56);
            this.viewStudents.Name = "viewStudents";
            this.viewStudents.RowHeadersWidth = 62;
            this.viewStudents.Size = new System.Drawing.Size(667, 399);
            this.viewStudents.TabIndex = 38;
            // 
            // btnGenSum
            // 
            this.btnGenSum.BorderColor = System.Drawing.Color.Gold;
            this.btnGenSum.BorderThickness = 2;
            this.btnGenSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenSum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenSum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenSum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenSum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenSum.ForeColor = System.Drawing.Color.Gold;
            this.btnGenSum.Location = new System.Drawing.Point(595, 500);
            this.btnGenSum.Name = "btnGenSum";
            this.btnGenSum.Size = new System.Drawing.Size(234, 41);
            this.btnGenSum.TabIndex = 48;
            this.btnGenSum.Text = "Generate Summary";
            this.btnGenSum.Click += new System.EventHandler(this.btnGenSum_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.Gold;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Gold;
            this.btnDelete.Location = new System.Drawing.Point(162, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(234, 41);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.Gold;
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Gold;
            this.btnSearch.Location = new System.Drawing.Point(854, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 41);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imgRefresh
            // 
            this.imgRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));
            this.imgRefresh.Location = new System.Drawing.Point(1013, 105);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Size = new System.Drawing.Size(32, 33);
            this.imgRefresh.TabIndex = 51;
            this.imgRefresh.TabStop = false;
            this.imgRefresh.Click += new System.EventHandler(this.imgRefresh_Click);
            // 
            // ViewAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGenSum);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStuSearch);
            this.Controls.Add(this.viewStudents);
            this.Name = "ViewAllStudents";
            this.Size = new System.Drawing.Size(1090, 580);
            this.Load += new System.EventHandler(this.ViewAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStuSearch;
        private System.Windows.Forms.DataGridView viewStudents;
        private Guna.UI2.WinForms.Guna2Button btnGenSum;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.PictureBox imgRefresh;
    }
}
