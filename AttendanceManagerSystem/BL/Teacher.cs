using AttendanceManagerSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.BL
{
    class Teacher
    {

        private String TeacherID, TeacherName, MajorID;

        public Teacher()
        {
        }

        public Teacher(string teacherID, string teacherName, string majorID)
        {
            MajorID = majorID;
            TeacherID = teacherID;
            TeacherName = teacherName;
        }

        public string MajorID1 { get => MajorID; set => MajorID = value; }
        public string TeacherID1 { get => TeacherID; set => TeacherID = value; }
        public string TeacherName1 { get => TeacherName; set => TeacherName = value; }

        public static List<Teacher> GetAllTeacher()
        {
            List<Teacher> listTeacher = new List<Teacher>();
            DataTable dataTable = TeacherDAL.GetAllTeacher();
            foreach (DataRow dr in dataTable.Rows)
            {
                string teacherID = dr["TeacherID"].ToString();
                string teacherName = dr["TeacherName"].ToString();
                string majorId = dr["MajorID"].ToString();

                Teacher teacher = new Teacher(teacherID, teacherName, majorId);
                listTeacher.Add(teacher);
            }
            return listTeacher;
        }
        internal static List<Teacher> GetTeacherById(string TeacherId)
        {
            List<Teacher> listTeacher = new List<Teacher>();
            DataTable dataTable = TeacherDAL.GetTeacherById(TeacherId);
            foreach (DataRow dr in dataTable.Rows)
            {
                string teacherID = dr["TeacherID"].ToString();
                string teacherName = dr["TeacherName"].ToString();
                string majorId = dr["MajorID"].ToString();

                Teacher teacher = new Teacher(teacherID, teacherName, majorId);
                listTeacher.Add(teacher);
            }
            return listTeacher;
        }

        public static int UpdateTeacher(ArrayList arrayList)
        {
            int count = 0;
            count = TeacherDAL.UpdateTeacher(arrayList);
            return count;
        }

        internal static int AddTeacher(ArrayList arrayList)
        {
            return TeacherDAL.AddTeacher(arrayList);
        }


        internal static List<Teacher> SearchTeacherByName(string text)
        {
            List<Teacher> listTeacher = new List<Teacher>();
            DataTable dataTable = TeacherDAL.GetTeacherByName(text);
            foreach (DataRow dr in dataTable.Rows)
            {
                string teacherID = dr["TeacherID"].ToString();
                string teacherName = dr["TeacherName"].ToString();
                string majorId = dr["MajorID"].ToString();

                Teacher teacher = new Teacher(teacherID, teacherName, majorId);
                listTeacher.Add(teacher);
            }
            return listTeacher;
        }

        internal static List<Teacher> SearchTeacherByMajorId(string text)
        {
            List<Teacher> listTeacher = new List<Teacher>();
            DataTable dataTable = TeacherDAL.GetTeacherByMajorId(text);
            foreach (DataRow dr in dataTable.Rows)
            {
                string teacherID = dr["TeacherID"].ToString();
                string teacherName = dr["TeacherName"].ToString();
                string majorId = dr["MajorID"].ToString();

                Teacher teacher = new Teacher(teacherID, teacherName, majorId);
                listTeacher.Add(teacher);
            }
            return listTeacher;
        }
    }
}
