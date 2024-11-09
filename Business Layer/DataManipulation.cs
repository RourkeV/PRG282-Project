using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        public DataTable displaySearch(string studentID)
        {
            DataTable studentData = new DataTable();

            studentData.Columns.Add("ID", typeof(string));
            studentData.Columns.Add("Name", typeof(string));
            studentData.Columns.Add("Date", typeof(string));
            studentData.Columns.Add("Course", typeof(string));

            List<StudentObj> displayList = dataHandler.fillList();

            foreach (var item in displayList)
            {
                if (item.Id == studentID)
                {
                    studentData.Rows.Add(item.Id, item.Name, item.BDate, item.Course);

                }
            }

            return studentData;
        }
        public void studentDelete(string ID)
        {

            for (int i = 0; i<dataHandler.fillList().Count(); i++)
            {
                if (dataHandler.studentList[i].Id == ID)
                {
                    dataHandler.studentList.RemoveAt(i);
                    dataHandler.updateTxt();
                }
            }
            
        }

        public void getNewDetails(string inID, string inName, string inDate, string inCourse)
        {
            StudentObj addStu = new StudentObj(inID, inName, inDate, inCourse);

            dataHandler.addStudent(addStu);
        }

        public void dupeCheck(string ID, string name, string date, string course)
        {
            dataHandler.fillList();
            for (int i = 0; i < dataHandler.studentList.Count; i++)
            {
                if (dataHandler.studentList[i].Id == ID)
                {
                    MessageBox.Show("This ID Already Exists!");
                    break;
                }
                else if (i == dataHandler.studentList.Count -1)
                {
                    getNewDetails(ID, name, date, course);

                    MessageBox.Show("Student Has Been Added!");
                    break;
                }
            }
        }

        public void updateStudentRecord(string ID, string name, string date, string course)
        {
            dataHandler.fillList();

            bool studentFound = false;
            for (int i = 0; i < dataHandler.studentList.Count; i++) 
            {
                if (dataHandler.studentList[i].Id == ID) 
                {
                    dataHandler.studentList[i].Name = name;
                    dataHandler.studentList[i].BDate = date;
                    dataHandler.studentList[i].Course = course;

                    MessageBox.Show("Student Has Been Updated!");
                    studentFound = true;
                    break;

                }  
            }
            if (!studentFound) 
            {
                MessageBox.Show("Student with the specified ID does not exist. Update Failed");
            }

        }
        

        
        public string summary()
        {
            int nrStudents;
            double avgAge = 0;
            dataHandler.fillList();

            nrStudents = dataHandler.studentList.Count;

            string dateString;

            // Define the format of the input string
            string format = "yyyy-MM-dd";

            // Convert the string to a DateTime object

            foreach (var item in dataHandler.studentList)
            {
                dateString = item.BDate;
                DateTime BirthDate = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
                avgAge += DateTime.Today.Year - BirthDate.Year;
            }

            avgAge = avgAge / nrStudents;

            dataHandler.updateSummary($@"Summary
Number of Students: {nrStudents}
Average age Of Students: {avgAge}");

            return ($@"Summary
Number of Students: {nrStudents}
Average age Of Students: {avgAge}");
        }
    }
}
