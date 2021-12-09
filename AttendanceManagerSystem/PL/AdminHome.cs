using AttendanceManagerSystem.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttendanceManagerSystem
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCourseIntoClass().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCourse().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sdssToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddStudent().ShowDialog();
            this.Close();
        }

        private void addMajorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddMajor().ShowDialog();
            this.Close();
        }

        private void updateMajorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateMajor().ShowDialog();
            this.Close();
        }

        private void createCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCourse().ShowDialog();
            this.Close();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateStudent().ShowDialog();
            this.Close();
        }
    }
}
