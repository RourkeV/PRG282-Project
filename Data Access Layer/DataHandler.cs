using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PRG282_Project.Business_Layer;

namespace PRG282_Project.Data_Access_Layer
{
    internal class DataHandler
    {

        //reading the text file and pushing the information to an array so that we can split the text, seperating the information.

        public static string filepath = @"C:\Users\Rourke\Desktop\Belgium Campus Work\PRG282\PRG282 Project\Student_Info.txt";

        private string[] students = File.ReadAllLines(filepath);

        public List<string[]> manipList = new List<string[]>();

        List<StudentObj> studentList = new List<StudentObj>();

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
    }
}
