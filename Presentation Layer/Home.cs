using PRG282_Project.Business_Layer;
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

namespace PRG282_Project
{
    public partial class Home : UserControl
    {
        Data_Manipulation data = new Data_Manipulation();
        static string filename = "Student_Info.txt";
        public Home()
        {
            InitializeComponent();
            
        }

        
        private void Home_Load(object sender, EventArgs e)
        {
            DataTable table = data.display();
            chart1.Titles.Add("Students Per Course");
            chart1.Series["No. of Students"].Points.AddXY("BCOMP", CountStudents()[0]);
            chart1.Series["No. of Students"].Points.AddXY("BIT", CountStudents()[1]);
            chart1.Series["No. of Students"].Points.AddXY("DIT", CountStudents()[2]);
            chart1.Series["No. of Students"].Points.AddXY("ITC", CountStudents()[3]);


        }
        static int[] CountStudents()
        {
            int BCcount = 0;
            int BITcount = 0;
            int DITcount = 0;
            int ITcount = 0;
            int[] totalStudents = {0,0,0,0};

            try
            {
                foreach (string line in File.ReadLines(filename))
                {
                    if (line.Contains("Bachelor of Computing"))
                    {
                        BCcount++;
                    }
                    else if (line.Contains("Bachelor of IT"))
                    {
                        BITcount++;
                    }
                    else if (line.Contains("Diploma in IT"))
                    {
                        DITcount++;
                    }
                    else if (line.Contains("IT Certificate"))
                    {
                        ITcount++;
                    }
                }
                totalStudents[0] = BCcount;
                totalStudents[1] = BITcount;
                totalStudents[2] = DITcount;
                totalStudents[3] = ITcount;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file '{filename}' was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return totalStudents;
        }

      
    }


        
    }


