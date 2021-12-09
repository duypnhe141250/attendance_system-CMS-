using AttendanceManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.BL
{
    class Subject
    {
        private string SubjectID;
        private string SubjectName;
        private string MajorID;

        public Subject()
        {
        }

        public Subject(string subjectID, string subjectName, string majorID)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            MajorID = majorID;
        }

        public string SubjectID1 { get => SubjectID; set => SubjectID = value; }
        public string SubjectName1 { get => SubjectName; set => SubjectName = value; }
        public string MajorID1 { get => MajorID; set => MajorID = value; }

        internal static List<Subject> GetSubjectById(string text)
        {
            List<Subject> listSub = new List<Subject>();
            DataTable dataTable = SubjectDAL.GetSubjectById(text);
            foreach (DataRow dr in dataTable.Rows)
            {
                
                string subId = dr["SubjectID"].ToString();
                string subName = dr["SubjectName"].ToString();
                string majorId = dr["MajorID"].ToString();
                Subject subject = new Subject(subId, subName, majorId);
                listSub.Add(subject);
            }
            return listSub;
        }
    }
}
