using PRG282_Project.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace PRG282_Project.UserControls
{
    public partial class ViewAllStudents : System.Windows.Forms.UserControl
    {
        public ViewAllStudents()
        {
            InitializeComponent();
        }

        private void ViewAllStudents_Load(object sender, EventArgs e)
        {
            Data_Manipulation dm = new Data_Manipulation();

            viewStudents.DataSource = dm.display();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stuID = txtStuSearch.Text;
            Data_Manipulation ds = new Data_Manipulation();
            viewStudents.DataSource = ds.displaySearch(stuID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Data_Manipulation dm = new Data_Manipulation();
            DataGridViewRow selectedRow = viewStudents.SelectedRows[0];

            string ID = selectedRow.Cells["ID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            DialogResult choice = MessageBox.Show(
                $"Do you wish to Delete {name}'s Profile", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            

            if (choice == DialogResult.Yes)
            {
                dm.studentDelete(ID);
                MessageBox.Show("Student Has been deleted");
                viewStudents.DataSource = dm.display();
            }
            
        }

        private void btnGenSum_Click(object sender, EventArgs e)
        {
            Data_Manipulation dm = new Data_Manipulation();
            MessageBox.Show(dm.summary());
        }

        private void imgRefresh_Click(object sender, EventArgs e)
        {
            Data_Manipulation dm = new Data_Manipulation();

            viewStudents.DataSource = dm.display();
        }
    }
}
