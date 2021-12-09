using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.DAL
{
    class AccountDAO
    {
        internal static DataTable GetRoleIdByAccount(string username,string password)
        {
            string sql = "select RoleID from Account where username='" + username + "' and password='" + password + "'";
            return Database.GetDataBySQL(sql);
        }
    }
}
