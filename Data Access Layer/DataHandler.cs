using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.Data_Access_Layer
{
    internal class DataHandler
    {
        public static string filepath = @"C:\Users\Rourke\Desktop\Belgium Campus Work\PRG282\PRG282 Project\Student_Info.txt";

        private string[] students = File.ReadAllLines(filepath);

        public List<string[]> manipList = new List<string[]>();

        public List<string[]> fillList()
        {
            manipList.Clear();
            foreach (var item in students)
            {
                manipList.Add(item.Split(','));
            }
            return manipList;
        }
    }
}
