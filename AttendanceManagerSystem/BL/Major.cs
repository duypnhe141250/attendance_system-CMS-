using AttendanceManagerSystem.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AttendanceManagerSystem.BL
{
    class Major
    {
        private string MajorID, MajorName;

        public Major()
        {
        }

        public Major(string majorID, string majorName)
        {
            MajorID = majorID;
            MajorName = majorName;
        }

        public string MajorID1 { get => MajorID; set => MajorID = value; }
        public string MajorName1 { get => MajorName; set => MajorName = value; }


        public static List<Major> GetAllMajor()
        {
            List<Major> listMajor = new List<Major>();
            DataTable dataTable = MajorDAL.GetAllMajor();
            foreach (DataRow dr in dataTable.Rows)
            {
                string majorId = dr["MajorID"].ToString();
                string majorName = dr["MajorName"].ToString();

                Major major = new Major(majorId, majorName);
                listMajor.Add(major);
            }
            return listMajor;
        }
        internal static List<Major> GetMajorById(string MajorId)
        {
            List<Major> listMajor = new List<Major>();
            DataTable dataTable = MajorDAL.GetMajorById(MajorId);
            foreach (DataRow dr in dataTable.Rows)
            {
                string majorId = dr["MajorID"].ToString();
                string majorName = dr["MajorName"].ToString();

                Major major = new Major(majorId, majorName);
                listMajor.Add(major);
            }
            return listMajor;
        }

        

        internal static int AddMajor(ArrayList arrayList)
        {
            return MajorDAL.AddMajor(arrayList);
        }


       
    }
}
