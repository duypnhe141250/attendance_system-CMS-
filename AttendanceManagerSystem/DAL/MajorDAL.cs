using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.DAL
{
    class MajorDAL
    {
        public static DataTable GetAllMajor()
        {
            string sql = "SELECT * FROM Major";
            return Database.GetDataBySQL(sql);
        }

        internal static int UpdateCategory(ArrayList array)
        {
            string sql = "UPDATE Major SET  MajorName = @name WHERE MajorID = @id";
            SqlParameter[] para = new SqlParameter[] {
            new SqlParameter("@name", SqlDbType.NVarChar),
            new SqlParameter("@id", SqlDbType.NVarChar)
        };

            for (int i = 0; i < array.Count; i++)
            {
                para[i].Value = array[i];
            }

            return Database.ExecuteSQL(sql, para);
        }

        internal static int AddMajor(ArrayList arrayList)
        {
            string sql = "INSERT INTO Major VALUES(@majorId, @majorName)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@majorId", SqlDbType.NVarChar),
                new SqlParameter("@majorName", SqlDbType.NVarChar)
               
            };
            // Gan gia tri cho cac tham so kieu SqlParameter
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

        internal static DataTable GetMajorById(string majorId)
        {
            string sql = "SELECT * FROM Major WHERE MajorID = '" + majorId + "'";
            return Database.GetDataBySQL(sql);
        }



        internal static DataTable GetMajorByName(string majorName)
        {
            string sql = "SELECT * FROM Major WHERE MajorName LIKE '" + majorName + "%'";
            return Database.GetDataBySQL(sql);
        }
    }
}
