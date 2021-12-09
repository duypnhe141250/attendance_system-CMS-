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
    public partial class UpdateMajor : Form
    {
        public UpdateMajor()
        {
            InitializeComponent();
        }
       
        private void btnUpdateMajor_Click(object sender, EventArgs e)
        {
            string majorId = txtMajorID1.Text.Trim();
            string majorName = txtMajorName1.Text.Trim();

            ArrayList array = new ArrayList() { majorId, majorName };
            
            if (MajorDAL.UpdateCategory(array)>0)
            {
                MessageBox.Show("Update successfully");


            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void txtMajorID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
