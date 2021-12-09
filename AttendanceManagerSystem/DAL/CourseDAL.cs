using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.DAL
{
    class CourseDAL
    {
       

        public static int UpdateCourse(ArrayList arrayList)
        {
            string sql = "UPDATE Course SET Class=@class, SubjectID=@subId, TeacherID=@teacherId WHERE CourseID=@courseId";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@class", SqlDbType.NVarChar),
                new SqlParameter("@subId", SqlDbType.NVarChar),
                new SqlParameter("@teacherId", SqlDbType.NVarChar),
                new SqlParameter("@courseId", SqlDbType.NVarChar)
                
            };
            // Gan gia tri cho cac tham so kieu SqlParameter
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

        internal static int AddCourse(ArrayList arrayList)
        {
            string sql = "INSERT INTO Course VALUES(@courseId, @Class, @subId, @teacherId)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@courseId", SqlDbType.NVarChar),
                new SqlParameter("@Class", SqlDbType.NVarChar),
                new SqlParameter("@subId", SqlDbType.NVarChar),
                new SqlParameter("@teacherId", SqlDbType.NVarChar)
            };
            // Gan gia tri cho cac tham so kieu SqlParameter
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

        internal static DataTable GetCourseById(string courseId)
        {
            string sql = "SELECT * FROM Course WHERE CourseID = '" + courseId + "'";
            return Database.GetDataBySQL(sql);
        }


       
       
    }
}
