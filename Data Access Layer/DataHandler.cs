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

        public static string filepath = @"Student_Info.txt";
        public static string sumFilepath = @"Summary.txt";


        private string[] students = File.ReadAllLines(filepath);

        static List<string[]> manipList = new List<string[]>();

        public List<StudentObj> studentList = new List<StudentObj>();

        public List<StudentObj> fillList()
        {
            if (manipList != null)
            {
                manipList.Clear();
            }
            if (studentList != null)
            {
                studentList.Clear();
            }
            foreach (var item in students)
            {
                manipList.Add(item.Split(','));
            }
            foreach (var item in manipList)
            {
                StudentObj newStu = new StudentObj(item[0], item[1], item[2], item[3]);
                studentList.Add(newStu);
            }
            return studentList;
        }

        public void addStudent(StudentObj newStudent)
        {
            studentList.Add(newStudent);

            string txtStudent = $"{newStudent.Id},{newStudent.Name},{newStudent.BDate},{newStudent.Course}";

            File.AppendAllText(filepath, "\n"+txtStudent);
        }
        public void updateStudent(string ID, string Name, string Date, string Course)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].Id == ID)
                {
                    studentList[i].Name = Name;
                    studentList[i].BDate = Date;
                    studentList[i].Course = Course;
                }
            }
            updateTxt();
        }
        
        public void updateSummary(string sum)
        {
            File.WriteAllText(sumFilepath,sum);
        }
        public void updateTxt()
        {
            string[] updateString = new string[studentList.Count];

            for (int i = 0; i < studentList.Count; i++)
            {
                updateString[i] = $"{studentList[i].Id},{studentList[i].Name},{studentList[i].BDate},{studentList[i].Course}";
            }

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
