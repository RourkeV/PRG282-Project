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
            this.button8 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStuSearch = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnGenSum = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.viewStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(255, 905);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(213, 63);
            this.button8.TabIndex = 45;
            this.button8.Text = "Add Student";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1293, 380);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(213, 63);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1320, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 31);
            this.label9.TabIndex = 43;
            this.label9.Text = "Student ID";
            // 
            // txtStuSearch
            // 
            this.txtStuSearch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuSearch.Location = new System.Drawing.Point(1293, 292);
            this.txtStuSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStuSearch.Multiline = true;
            this.txtStuSearch.Name = "txtStuSearch";
            this.txtStuSearch.Size = new System.Drawing.Size(211, 46);
            this.txtStuSearch.TabIndex = 42;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(514, 906);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 63);
            this.button6.TabIndex = 41;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnGenSum
            // 
            this.btnGenSum.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenSum.Location = new System.Drawing.Point(1042, 906);
            this.btnGenSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenSum.Name = "btnGenSum";
            this.btnGenSum.Size = new System.Drawing.Size(213, 63);
            this.btnGenSum.TabIndex = 40;
            this.btnGenSum.Text = "Generate Summary";
            this.btnGenSum.UseVisualStyleBackColor = true;
            this.btnGenSum.Click += new System.EventHandler(this.btnGenSum_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(783, 905);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 63);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // viewStudents
            // 
            this.viewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStudents.Location = new System.Drawing.Point(255, 214);
            this.viewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewStudents.Name = "viewStudents";
            this.viewStudents.RowHeadersWidth = 62;
            this.viewStudents.Size = new System.Drawing.Size(1000, 614);
            this.viewStudents.TabIndex = 38;
            // 
            // ViewAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStuSearch);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnGenSum);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.viewStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewAllStudents";
            this.Size = new System.Drawing.Size(1635, 1165);
            this.Load += new System.EventHandler(this.ViewAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStuSearch;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnGenSum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView viewStudents;
    }
}
