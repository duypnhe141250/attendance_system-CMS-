using AttendanceManagerSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.BL
{
    class Student
    {
        private string StudentID, StudentName, MajorID;

        public Student()
        {
        }

        public Student(string studentID, string studentName, string majorID)
        {
            StudentID = studentID;
            StudentName = studentName;
            MajorID = majorID;
        }

        public string StudentID1 { get => StudentID; set => StudentID = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public string MajorID1 { get => MajorID; set => MajorID = value; }


        internal static int AddStudent(ArrayList arrayList)
        {
            return StudentDAL.AddStudent(arrayList);
        }

        public static int UpdateStudent(ArrayList arrayList)
        {
            int count = 0;
            count = StudentDAL.UpdateStudent(arrayList);
            return count;
        }
    }
}
