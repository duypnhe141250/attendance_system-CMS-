using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.DAL
{
    class TeacherDAL
    {
        public static DataTable GetAllTeacher()
        {
            string sql = "SELECT * FROM Teacher";
            return Database.GetDataBySQL(sql);
        }

        public static int UpdateTeacher(ArrayList arrayList)
        {
            string sql = "UPDATE Teacher SET TeacherName=@teacherName,MajorID=@majorId WHERE TeacherID=@teacherId";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@teacherId", SqlDbType.NVarChar),
                new SqlParameter("@teacherName", SqlDbType.NVarChar),
                new SqlParameter("@majorId", SqlDbType.NVarChar)

            };
            // Gan gia tri cho cac tham so kieu SqlParameter
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

        internal static int AddTeacher(ArrayList arrayList)
        {
            string sql = "INSERT INTO Teacher VALUES(@teacherId, @teacherName, @majorId)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@majorId", SqlDbType.NVarChar),
                new SqlParameter("@teacherId", SqlDbType.NVarChar),
                new SqlParameter("@teacherName", SqlDbType.NVarChar)

            };
            // Gan gia tri cho cac tham so kieu SqlParameter
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

        internal static DataTable GetTeacherById(string teacherId)
        {
            string sql = "SELECT * FROM Teacher WHERE TeacherID = '" + teacherId + "'";
            return Database.GetDataBySQL(sql);
        }



        internal static DataTable GetTeacherByName(string teacherName)
        {
            string sql = "SELECT * FROM Teacher WHERE TeacherName LIKE '" + teacherName + "%'";
            return Database.GetDataBySQL(sql);
        }

        internal static DataTable GetTeacherByMajorId(string majorId)
        {
            string sql = "SELECT * FROM Teacher WHERE MajorID LIKE '" + majorId + "%'";
            return Database.GetDataBySQL(sql);
        }
    }
}

