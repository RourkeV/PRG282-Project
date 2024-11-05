using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Business_Layer
{
    internal class StudentObj
    {

        private string id;
        private string name;
        private string bDate;
        private string course;
        
        public StudentObj(string ID, string name, string birthday, string course)
        {
            this.id = ID;
            this.name = name;
            this.BDate = birthday;
            this.Course = course;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string BDate { get => bDate; set => bDate = value; }
        public string Course { get => course; set => course = value; }
    }
}
