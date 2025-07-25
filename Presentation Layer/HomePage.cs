﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.Data_Access_Layer;
using PRG282_Project.Business_Layer;
using System.Web.UI.Design.WebControls;
using System.Xml.Linq;
using PRG282_Project.UserControls;

namespace PRG282_Project
{
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            InitializeComponent();
            Home uc = new Home();
            addUserControl(uc);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            handler.fillList();
        }

        private void imgIcon_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addUserControl(uc);
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addUserControl(uc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent uc = new AddStudent();
            addUserControl(uc);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAllStudents uc = new ViewAllStudents();
            addUserControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateStudent uc = new UpdateStudent();
            addUserControl(uc);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
