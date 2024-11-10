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
        // Create an instance of DataHandler to access data operations
        public DataHandler dataHandler = new DataHandler();
        // Method to display all students in a DataTable format
        public DataTable display()
        {

            DataTable studentData = new DataTable();

            // Define columns for student data
            studentData.Columns.Add("ID", typeof(string));
            studentData.Columns.Add("Name", typeof(string));
            studentData.Columns.Add("Date", typeof(string));
            studentData.Columns.Add("Course", typeof(string));

            // Retrieve list of students
            List<StudentObj> displayList = dataHandler.fillList();

            // Populate DataTable with student data
            foreach (var item in displayList)
            {
                studentData.Rows.Add(item.Id, item.Name, item.BDate, item.Course);
            }

            return studentData;
        }
        // Method to display data for a specific student based on student ID
        public DataTable displaySearch(string studentID)
        {
            DataTable studentData = new DataTable();

            // Define columns for search results
            studentData.Columns.Add("ID", typeof(string));
            studentData.Columns.Add("Name", typeof(string));
            studentData.Columns.Add("Date", typeof(string));
            studentData.Columns.Add("Course", typeof(string));

            // Retrieve list of students
            List<StudentObj> displayList = dataHandler.fillList();

            // Filter and add student data that matches the specified ID
            foreach (var item in displayList)
            {
                if (item.Id == studentID)
                {
                    studentData.Rows.Add(item.Id, item.Name, item.BDate, item.Course);

                }
            }

            return studentData;
        }
        // Method to delete a student based on ID
        public void studentDelete(string ID)
        {
            // Iterate through student list to find matching ID and delete
            for (int i = 0; i<dataHandler.fillList().Count(); i++)
            {
                if (dataHandler.studentList[i].Id == ID)
                {
                    dataHandler.studentList.RemoveAt(i); // Remove student
                    dataHandler.updateTxt(); // Update the text file
                } 
            }
            
        }
        // Method to add a new student record
        public void getNewDetails(string inID, string inName, string inDate, string inCourse)
        {
            // Create a new student object with provided details
            StudentObj addStu = new StudentObj(inID, inName, inDate, inCourse);

            // Add student to data handler
            dataHandler.addStudent(addStu);
        }
        // Method to check for duplicate ID before adding a new student
        public void dupeCheck(string ID, string name, string date, string course)
        {
            dataHandler.fillList(); // Refresh list of students
            // Loop through the list to check for duplicate ID
            for (int i = 0; i < dataHandler.studentList.Count; i++)
            {
                if (dataHandler.studentList[i].Id == ID)
                {
                    MessageBox.Show("This ID Already Exists!");
                    break;
                }
                else if (i == dataHandler.studentList.Count -1)
                {
                    getNewDetails(ID, name, date, course); // Add new student

                    MessageBox.Show("Student Has Been Added!");
                    break;
                }
            }
        }
        // Method to update student details based on ID
        public void updateStudentRecord(string ID, string name, string date, string course)
        {
            dataHandler.fillList(); // Refresh student list

            bool studentFound = false;
            // Loop to find and update student with matching ID
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
            // If student ID not found, show error message
            if (!studentFound) 
            {
                MessageBox.Show("Student with the specified ID does not exist. Update Failed");
            }

        }


        // Method to generate a summary of student data
        public string summary()
        {
            int nrStudents;
            double avgAge = 0;
            dataHandler.fillList(); // Refresh student list

            nrStudents = dataHandler.studentList.Count; // Total students count

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

            avgAge = avgAge / nrStudents; // Calculate average age

            // Update summary data in text file
            dataHandler.updateSummary($@"Summary
Number of Students: {nrStudents}
Average age Of Students: {avgAge}");

            return ($@"Summary
Number of Students: {nrStudents}
Average age Of Students: {avgAge}");
        }
    }
}
