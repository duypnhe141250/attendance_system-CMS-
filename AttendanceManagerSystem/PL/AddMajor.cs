using AttendanceManagerSystem.BL;
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
    public partial class AddMajor : Form
    {
        public AddMajor()
        {
            InitializeComponent();
        }

        private bool ValidMajor()
        {

            if (!Regex.IsMatch(txtMajorID.Text.Trim(), @"^[A-Z]{2}$"))
            {
                MessageBox.Show("Ma de hop le  VD: HE");
                txtMajorID.Focus();
                return false;
            }

            if (txtMajorName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Text Major Name is not null");
                txtMajorName.Focus();
                return false;
            }
            return true;
        }

        private void btnAddMajor_Click(object sender, EventArgs e)
        {
            string majorId = txtMajorID.Text.Trim();
            string majorName = txtMajorName.Text.Trim();

            ArrayList array = new ArrayList() { majorId, majorName };
            if (!ValidMajor())
            {
                return;
            }
            if(Major.AddMajor(array) > 0)
            {
                MessageBox.Show("Add successfully");               
                

            }
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();
        }
    }
}
