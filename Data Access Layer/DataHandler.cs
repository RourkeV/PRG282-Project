using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PRG282_Project.Business_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Security.Claims;
using System.Windows.Forms;

namespace PRG282_Project.Data_Access_Layer
{
    internal class DataHandler
    {


        //reading the text file and pushing the information to an array so that we can split the text, seperating the information.

        public static string filepath = @"Student_Info.txt"; // Filepath for storing student data
        public static string sumFilepath = @"Summary.txt"; // Filepath for storing summary data

        // Reads all lines from the student information file
        private string[] students = File.ReadAllLines(filepath);

        // List to temporarily hold split student data
        static List<string[]> manipList = new List<string[]>();

        // List of StudentObj to store processed student data
        public List<StudentObj> studentList = new List<StudentObj>();

        // Method to fill the student list with data from the file
        public List<StudentObj> fillList()
        {
            // Clear previous data if it exists
            if (manipList != null)
            {
                manipList.Clear();
            }
            if (studentList != null)
            {
                studentList.Clear();
            }
            // Split each line into parts and add to manipList
            foreach (var item in students)
            {
                manipList.Add(item.Split(','));
            }
            // Convert each entry in manipList into a StudentObj and add to studentList
            foreach (var item in manipList)
            {
                StudentObj newStu = new StudentObj(item[0], item[1], item[2], item[3]);
                studentList.Add(newStu);
            }
            return studentList;
        }
        // Method to add a new student to the list and append it to the file
        public void addStudent(StudentObj newStudent)
        {
            studentList.Add(newStudent); // Add new student to list

            // Format student details into a comma-separated string
            string txtStudent = $"{newStudent.Id},{newStudent.Name},{newStudent.BDate},{newStudent.Course}";

            // Append the new student information to the file
            File.AppendAllText(filepath, "\n"+txtStudent);
        }
        // Method to update a student's information based on their ID
        public void updateStudent(string ID, string Name, string Date, string Course)
        {
            // Loop through the student list to find a matching ID
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].Id == ID)
                {
                    // Update student details if ID matches
                    studentList[i].Name = Name;
                    studentList[i].BDate = Date;
                    studentList[i].Course = Course;
                }
            }
            updateTxt(); // Update the file with the modified list
        }

        // Method to write summary information to the summary file
        public void updateSummary(string sum)
        {
            File.WriteAllText(sumFilepath,sum); // Write the summary text to file
        }
        // Method to update the student information file with current student list
        public void updateTxt()
        {
            // Array to store updated student information as strings
            string[] updateString = new string[studentList.Count];

            // Convert each student object to a formatted string and add to array
            for (int i = 0; i < studentList.Count; i++)
            {
                updateString[i] = $"{studentList[i].Id},{studentList[i].Name},{studentList[i].BDate},{studentList[i].Course}";
            }

            // Write all updated student information to the file
            File.WriteAllLines(filepath, updateString);
        }
        /*S001,Alice Thompson,2001-05-12, Bachelor of Computing
S002,Brian Chen,2002-03-22, Bachelor of IT
S003,Clara Johnson,2000-11-04, Diploma in IT
S004, David Martinez,2001-09-15,IT Certificate
S005,Emily Davis,2003-02-28, Bachelor of Computing
S006,Frank Lee,2000-12-19, Bachelor of IT
S007,Grace Patel,2002-07-07, Diploma in IT
S008, Henry Robinson,2003-01-30,IT Certificate
S009,Isabella Wright,2001-06-21, Bachelor of Computing
S010,Jack Brown,2000-10-05, Bachelor of IT
3746, hella beans,2024-11-18,Diploma in IT*/
    }
}
