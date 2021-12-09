using AttendanceManagerSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AttendanceManagerSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["abc"].ToString();
            return new SqlConnection(strCon);
        }
        public DataTable GetAccount(string user)
        {
            string sql = "select * from Account where username='" + user + "'";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public bool validAccount()
        {
            //neu username or password rong


            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                return false;
            Regex reg = new Regex(@"^[a-zA-Z0-9]*(@fpt.edu.vn){1}$");
            if (!reg.IsMatch(txtUsername.Text.Trim()))
                return false;
            return true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtUsername.Text.Trim();
            String password = txtPassword.Text.Trim();
            if (validAccount())
            {
                if (GetAccount(user).Rows.Count > 0)
                {
                    if (Account.GetRoleId(user,password) == 1)
                    {
                        this.Hide();
                        new AdminHome().ShowDialog();
                        this.Close();
                    }
                    if (Account.GetRoleId(user, password) == 2)
                    {
                        this.Hide();
                        MessageBox.Show("2");
                        this.Close();
                    }
                    if (Account.GetRoleId(user, password) == 1)
                    {
                        this.Hide();
                        MessageBox.Show("3");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid account format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid account format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
