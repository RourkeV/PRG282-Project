using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.Data_Access_Layer;

namespace PRG282_Project.Business_Layer
{
    internal class Data_Manipulation
    {
        public DataHandler dataHandler = new DataHandler();
        public DataTable display()
        {

            DataTable studentData = new DataTable();

            studentData.Columns.Add("ID", typeof(string));
            studentData.Columns.Add("Name", typeof(string));
            studentData.Columns.Add("Date", typeof(string));
            studentData.Columns.Add("Course", typeof(string));

            List<StudentObj> displayList = dataHandler.fillList();

            foreach (var item in displayList)
            {
                studentData.Rows.Add(item.Id, item.Name, item.BDate, item.Course);
            }

            return studentData;
        }

        public void getNewDetails(string inID, string inName, string inDate, string inCourse)
        {
            StudentObj addStu = new StudentObj(inID, inName, inDate, inCourse);

            dataHandler.addStudent(addStu);
        }

        
    }
}
