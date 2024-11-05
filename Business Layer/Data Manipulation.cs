using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.Data_Access_Layer;

namespace PRG282_Project.Business_Layer
{
    internal class Data_Manipulation
    {
        public DataTable display()
        {
            DataHandler dataHandler = new DataHandler();

            DataTable studentData = new DataTable();

            studentData.Columns.Add("ID", typeof(string));
            studentData.Columns.Add("Name", typeof(string));
            studentData.Columns.Add("Date", typeof(string));
            studentData.Columns.Add("Course", typeof(string));

            List<string[]> displayList = dataHandler.fillList();

            foreach (var item in displayList)
            {
                studentData.Rows.Add(item);
            }

            return studentData;
        }
    }
}
