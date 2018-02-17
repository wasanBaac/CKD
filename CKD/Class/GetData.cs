using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MoreLinq;

namespace CKD.Class
{
    class GetData
    {
        public DataTable getHN(string strSearch)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            DataTable dt = new DataTable();

            var patient = from tb in db.Patients
                          where tb.HN.ToString().Contains(strSearch)
                          || tb.Name.Contains(strSearch)
                          || tb.LastName.Contains(strSearch)
                          select tb;
            dt = patient.ToDataTable();
            return dt;
        }

        public DataTable getDistrict()
        {
            DataClassesDataContext db = new DataClassesDataContext();
            DataTable dt = new DataTable();

            var district = from tb in db.Districts
                          select tb;
            dt = district.ToDataTable();
            return dt;
        }

        public DataTable getStatus()
        {
            DataClassesDataContext db = new DataClassesDataContext();
            DataTable dt = new DataTable();

            var status = from tb in db.PatientStatus
                          select tb;

            dt = status.ToDataTable();
            return dt;
        }

        public DataTable getTile()
        {
            DataClassesDataContext db = new DataClassesDataContext();
            DataTable dt = new DataTable();

            var status = from tb in db.Titles
                         select tb;

            dt = status.ToDataTable();
            return dt;
        }
    }
}
