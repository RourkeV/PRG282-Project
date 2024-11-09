using PRG282_Project.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using PRG282_Project.Data_Access_Layer;

namespace PRG282_Project.UserControls
{
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            txtBday.Text = $"{datePick.Value.Year.ToString()}-{datePick.Value.Month.ToString()}-{datePick.Value.Day.ToString()}";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return; 
            }
            Data_Manipulation dm = new Data_Manipulation();
            string IDIn = txtStuID.Text;
            string nameIn = txtName.Text;
            string dateIn = txtBday.Text;
            string courseIn = cmbCourse.Text;

            if (IDIn == "" || nameIn == "" || dateIn == "" || courseIn == "")
            {
                MessageBox.Show("Please Make Sure that All Elements are Filled In!");
            }
            else
            {
                dm.dupeCheck(IDIn, nameIn, dateIn, courseIn);   
            }

 
        }
        private bool ValidateForm() 
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student's name.");
                txtName.Focus();
                return false;
            }
            return true;

        }
    }
}
