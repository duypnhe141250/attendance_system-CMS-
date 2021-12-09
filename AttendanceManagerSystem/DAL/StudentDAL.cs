using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.DAL
{
    class StudentDAL
    {

        internal static int AddStudent(ArrayList arrayList)
        {
            string sql = "INSERT INTO Student VALUES(@id, @name, @majorId)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@id", SqlDbType.NVarChar),
                new SqlParameter("@name", SqlDbType.NVarChar),
                new SqlParameter("@majorId", SqlDbType.NVarChar)

            };
            // Gan gia tri cho cac tham so kieu SqlParameter
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

        internal static DataTable GetStudentById(string studentId)
        {
            string sql = "SELECT * FROM Student WHERE StudentID = '" + studentId + "'";
            return Database.GetDataBySQL(sql);
        }


        public static int UpdateStudent(ArrayList arrayList)
        {
            string sql = "UPDATE Student SET StudentName=@name,MajorID=@majorId WHERE StudentID=@id";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", SqlDbType.NVarChar),
                new SqlParameter("@majorId", SqlDbType.NVarChar),
                new SqlParameter("@id", SqlDbType.NVarChar)

            };
            // Gan gia tri cho cac tham so kieu SqlParameter
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

    }
}
