using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKD.Class;
using System.Threading;
using System.Globalization;
namespace CKD
{
    public partial class PatientDetail : Form
    {        
        Cal cal = new Cal();
        GetData getData = new GetData();
        //new patient
        public PatientDetail()
        {
            InitializeComponent();
            setData();
        }
        //exist patient
        public PatientDetail(string HN)
        {
            InitializeComponent();
            setData();
            setDataEdit(HN);
        }

        private void dateBirthDate_ValueChanged(object sender, EventArgs e)
        {
            lblAge.Text = "อายุ " + cal.calAge(dateBirthDate.Value) + "ปี";
        }

        private void setData()
        {
            cbDistrict.DataSource = getData.getDistrict();
            cbDistrict.ValueMember = "DistrictID";
            cbDistrict.DisplayMember = "DistrictName";

            cbStatus.DataSource = getData.getStatus();
            cbStatus.ValueMember = "StatusID";
            cbStatus.DisplayMember = "StatusDesc";

            cbTitle.DataSource = getData.getTile();
            cbTitle.ValueMember = "TitleID";
            cbTitle.DisplayMember = "TitleName";

        }

        private void setDataEdit(string strHN)
        {
            
            DataClassesDataContext db = new DataClassesDataContext();
            Patient patient = (from tb in db.Patients
                               where tb.HN.ToString() == strHN
                               select tb).SingleOrDefault();

            txtHN.Text = patient.HN.ToString();
            txtNumber.Text = patient.Number.ToString();
            cbTitle.SelectedValue = patient.TitleID;
            txtName.Text = patient.Name;
            txtLastName.Text = patient.LastName;

            //System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("en-US");

            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

            //DateTime dt = DateTime.Parse(date, cultureinfo);
            //var dutchCulture = CultureInfo.CreateSpecificCulture("th-TH");


            DateTime dt = Convert.ToDateTime(patient.BirthDate, currentCulture);

            dateBirthDate.Value = dt;//dt.Year+dt.Month+dt.Day;

            cbDistrict.SelectedValue = patient.DistrictID;
            cbStatus.SelectedValue = patient.StatusID;
            txtHN.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(validInput())
            {
                MessageBox.Show("กรุณาระบุข้อมูลให้ครบถ้วน");
                return;
            }
            
            DataClassesDataContext db = new DataClassesDataContext();
            DataTable dt = new DataTable();

            Patient patient = (from tb in db.Patients
                          where tb.HN.ToString() == txtHN.Text.Trim()
                          select tb).SingleOrDefault();
            
            if(patient == null)
            {
                patient = new Patient();
                db.Patients.InsertOnSubmit(patient);
            }
            else if(txtHN.Enabled == true)
            {
                Patient patientHN = (from tb in db.Patients
                                   where tb.Number.ToString() == txtNumber.Text.Trim()
                                   select tb).SingleOrDefault();
                if (patientHN != null)
                {
                    MessageBox.Show("HN ซ้ำกับที่มีอยู่");
                    return;
                }
            }

            patient.HN = Convert.ToInt32(txtHN.Text.Trim());
            patient.Number = Convert.ToInt16(txtNumber.Text.Trim());
            patient.TitleID = Convert.ToInt16(cbTitle.SelectedValue);
            patient.Name = txtName.Text.Trim();
            patient.LastName = txtLastName.Text.Trim();
            patient.BirthDate = dateBirthDate.Value;
            patient.DistrictID = Convert.ToInt16(cbDistrict.SelectedValue);
            patient.StatusID = Convert.ToInt16(cbStatus.SelectedValue);

            db.SubmitChanges();
            
            MessageBox.Show("บันทึกเสร็จสิ้น");

            this.Close();            
        }

        private bool validInput()
        {
            if (txtHN.Text.Trim() == string.Empty)
                return true;
            else if (txtNumber.Text.Trim() == string.Empty)
                return true;
            else if (txtName.Text.Trim() == string.Empty)
                return true;
            else if (txtLastName.Text.Trim() == string.Empty)
                return true;

            return false;
        }
    }
}
