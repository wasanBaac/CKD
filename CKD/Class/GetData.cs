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
        DataClassesDataContext db = new DataClassesDataContext();
        public DataTable getHN(string strSearch)
        {
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
            DataTable dt = new DataTable();

            var district = from tb in db.Districts
                          select tb;
            dt = district.ToDataTable();
            return dt;
        }

        public DataTable getStatus()
        {
            DataTable dt = new DataTable();

            var status = from tb in db.PatientStatus
                          select tb;

            dt = status.ToDataTable();
            return dt;
        }

        public DataTable getTile()
        {
            DataTable dt = new DataTable();

            var status = from tb in db.Titles
                         select tb;

            dt = status.ToDataTable();
            return dt;
        }

        public DataTable getGender()
        {
            DataTable dt = new DataTable();

            var data = from tb in db.refGenders
                         select tb;

            dt = data.ToDataTable();
            return dt;
        }

        public DataTable getPatientRecordAll()
        {
            DataTable dt = new DataTable();

            var data = from tb in db.PatientRecords
                       select tb;

            dt = data.ToDataTable();
            return dt;
        }

        public DataTable getPatientRecordByHN(Int32 _HN)
        {
            DataTable dt = new DataTable();

            var data = from tb in db.PatientRecords
                       where tb.HN == _HN
                       select tb;

            dt = data.ToDataTable();
            return dt;
        }
    }
}
