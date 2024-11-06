using PRG282_Project.Business_Layer;
using PRG282_Project.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG282_Project.UserControls
{
    public partial class UpdateStudent : UserControl
    {
        Data_Manipulation dm = new Data_Manipulation();
        public UpdateStudent()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStuID.Text != "" || txtName.Text != "" || txtBDate.Text != "")
            {
                handler.updateStudent(txtStuID.Text, txtName.Text, txtBDate.Text, cmbCourse.Text);
            }
            else
            {
                MessageBox.Show("Please Make Sure All Inputs are Filled");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            handler.fillList();

            if (txtStuID.Text != "")
            {
                foreach (var item in handler.studentList)
                {
                    if (item.Id == txtStuID.Text)
                    {
                        txtName.Text = item.Name;
                        txtBDate.Text = item.BDate;
                        cmbCourse.Text = item.Course;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Students ID");
            }
            
        }

        private void dateBday_ValueChanged(object sender, EventArgs e)
        {
            txtBDate.Text = $"{dateBday.Value.Year.ToString()}-{dateBday.Value.Month.ToString()}-{dateBday.Value.Day.ToString()}";
        }
    }
}
