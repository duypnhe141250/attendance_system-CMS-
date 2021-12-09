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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }
        private bool ValidStudent()
        {
            if (StudentDAL.GetStudentById(txtStudentID.Text.Trim()).Rows.Count < 0)
            {
                MessageBox.Show("Student id doesnt exist ");
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
            if (MajorDAL.GetMajorById(txtMajor.Text.Trim()).Rows.Count < 0 || txtMajor.Text.Trim() == "")
            {
                MessageBox.Show("Major ID does not exist / text is null");
                txtMajor.Focus();
                return false;
            }
            return true;
        }
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            string studentid = txtStudentID.Text.Trim();
            string studentName = txtStudentName.Text.Trim();
            string majorid = txtMajor.Text.Trim();
            ArrayList array = new ArrayList() { studentid, studentName,majorid };

            if (Student.UpdateStudent(array) > 0)
            {
                MessageBox.Show("Update successfully");


            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
