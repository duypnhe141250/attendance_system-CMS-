using AttendanceManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.BL
{
    class Account
    {
        private int AccountID;
        private String username, password;
        private int RoleID;

        public Account()
        {
        }

        public Account(String username, String password)
        {
            this.username = username;
            this.password = password;

        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int RoleID1 { get => RoleID; set => RoleID = value; }


        internal static int GetRoleId(string username,string password)
        {
            List<Course> listCour = new List<Course>();
            DataTable dataTable = AccountDAO.GetRoleIdByAccount(username,password);
            foreach (DataRow dr in dataTable.Rows)
            {
                int roleId = Convert.ToInt32(dr["RoleID"].ToString());

                return roleId;
            }
            return 0;
        }

        
    }
}
