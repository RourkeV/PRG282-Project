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

namespace PRG282_Project
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_Manipulation dm = new Data_Manipulation();
            string IDIn = txtID.Text;
            string nameIn = txtName.Text;
            string dateIn = $"{dtDate.Value.Year.ToString()}-{dtDate.Value.Month.ToString()}-{dtDate.Value.Day.ToString()}";
            string courseIn = cmbCourse.Text;

            dm.getNewDetails(IDIn, nameIn, dateIn, courseIn);

            MessageBox.Show("Student Has Been Added!");
            this.Close();
        }
    }
}
