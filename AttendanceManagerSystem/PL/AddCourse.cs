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
using System.Windows.Forms;

namespace AttendanceManagerSystem
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private bool checkValidCourse()
        {
            if (CourseDAL.GetCourseById(txtCourseID.Text.Trim()).Rows.Count >0 || txtCourseID.Text.Trim() == "")
            {
                MessageBox.Show("CourseID is existed or text is empty");
                txtCourseID.Focus();
                return false;
            }
            if (txtClass.Text.Trim() == null)
            {
                MessageBox.Show("Class is empty");
                txtClass.Focus();
                return false;
            }
            if(SubjectDAL.GetSubjectById(txtSubjectID.Text.Trim()).Rows.Count<0|| txtSubjectID.Text.Trim()==null)
            {
                MessageBox.Show("Subject ID not existed or text is empty");
                txtSubjectID.Focus();
                return false;
            }
            if (TeacherDAL.GetTeacherById(txtTeacherID.Text.Trim()).Rows.Count <0 || txtTeacherID.Text.Trim() == null){

                MessageBox.Show("Teacher ID  not existed or text is empty");
                txtTeacherID.Focus();
                return false;
            }
            return true;
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courId = txtCourseID.Text.Trim();
            string Class = txtClass.Text.Trim();
            string subId = txtSubjectID.Text.Trim();
            string teacherId = txtTeacherID.Text.Trim();

            ArrayList array = new ArrayList() { courId, Class, subId, teacherId };
            if (!checkValidCourse())
            {
                return;
            }
            if (Course.AddCourse(array) > 0)
            {
                MessageBox.Show("Add successfully");


            }
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();


        }
    }
}
