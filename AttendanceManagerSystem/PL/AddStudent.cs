using AttendanceManagerSystem.BL;
using AttendanceManagerSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AttendanceManagerSystem.PL
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidStudent()
        {
            if (StudentDAL.GetStudentById(txtStudentID.Text.Trim()).Rows.Count > 0)
            {
                MessageBox.Show("Student id exist ");
                txtStudentID.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtStudentID.Text.Trim(), @"^[A-Z]{2}[0-9]{3}$"))
            {
                MessageBox.Show("Ma sinh vien khong hop le  VD: H003");
                txtStudentID.Focus();
                return false;
            }

            if (txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student Name is not null");
                txtStudentName.Focus();
                return false;
            }
            if (MajorDAL.GetMajorById(txtMajorID.Text.Trim()).Rows.Count < 0||txtMajorID.Text.Trim()=="")
            {
                MessageBox.Show("Major ID is exist / text is null");
                txtMajorID.Focus();
                return false;
            }
            return true;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentid = txtStudentID.Text.Trim();
            string studentname = txtStudentID.Text.Trim();
            string majorid = txtMajorID.Text.Trim();

            ArrayList array = new ArrayList() { studentid, studentname,majorid };
            if (!ValidStudent())
            {
                return;
            }
            if (Student.AddStudent(array)>0)
            {
                MessageBox.Show("Add successfully");


            }
        }
    }
}
