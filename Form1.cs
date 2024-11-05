using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG282_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\matty\Desktop\PRG282-Project-master\bin\Debug\students.txt";

            string studentID = textBox1.Text;
            string name = textBox4.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            string course = comboBox1.SelectedItem.ToString();

            string studentRecord = $"{studentID},{name},{dateOfBirth:yyyy-MM-dd},{course}{Environment.NewLine}";

            File.AppendAllText(filePath, studentRecord);

            MessageBox.Show("Student record added successfully.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
