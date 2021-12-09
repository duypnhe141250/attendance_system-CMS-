using AttendanceManagerSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.BL
{
    class Course
    {
        private String CourseID, Class, SubjectID, TeacherID;

        public Course()
        {
        }

        public Course(string courseID, string @class, string subjectID, string teacherID)
        {
            CourseID = courseID;
            Class = @class;
            SubjectID = subjectID;
            TeacherID = teacherID;
        }

        public string CourseID1 { get => CourseID; set => CourseID = value; }
        public string Class1 { get => Class; set => Class = value; }
        public string SubjectID1 { get => SubjectID; set => SubjectID = value; }
        public string TeacherID1 { get => TeacherID; set => TeacherID = value; }

        
        internal static List<Course> GetCourseById(string text)
        {
            List<Course> listCour = new List<Course>();
            DataTable dataTable = CourseDAL.GetCourseById(text);
            foreach (DataRow dr in dataTable.Rows)
            {
                string courId = dr["CourseID"].ToString();
                string Class = dr["Class"].ToString();
                string subId = dr["SubjectID"].ToString();
                string teachId = dr["TeacherID"].ToString();
                Course course = new Course(courId, Class, subId, teachId);
                listCour.Add(course);
            }
            return listCour;
        }

        public static int UpdateCategory(ArrayList arrayList)
        {
            int count = 0;
            count = CourseDAL.UpdateCourse(arrayList);
            return count;
        }

        internal static int AddCourse(ArrayList arrayList)
        {
            return CourseDAL.AddCourse(arrayList);
        }


        
    }
}
