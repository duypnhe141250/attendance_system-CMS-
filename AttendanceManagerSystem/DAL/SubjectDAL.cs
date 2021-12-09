using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.DAL
{
    class SubjectDAL
    {
        internal static DataTable GetSubjectById(string text)
        {
                string sql = "SELECT * FROM Subject WHERE SubjectID = '" + text + "'";
                return Database.GetDataBySQL(sql);
           
        }
    }
}
