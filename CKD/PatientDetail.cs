﻿using System;
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
        private string strHN;
        private List<refDisease> lsDisease = new List<refDisease>();
        private List<LinkLabel> lsllb = new List<LinkLabel>();
        //new patient
        public PatientDetail()
        {
            InitializeComponent();
            setData();
            strHN = string.Empty;
            btnAddrecordDetail.Visible = false;
        }
        //exist patient
        public PatientDetail(string HN)
        {
            InitializeComponent();
            setData();
            strHN = HN;
            btnAddrecordDetail.Visible = true;
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

            cbGender.DataSource = getData.getGender();
            cbGender.ValueMember = "Id";
            cbGender.DisplayMember = "Detail";

            dateBirthDate.Format = DateTimePickerFormat.Custom;
            dateBirthDate.CustomFormat = "dd-MM-yyyy";

        }

        private void setDataEdit(string _strHN)
        {
            
            DataClassesDataContext db = new DataClassesDataContext();
            Patient patient = (from tb in db.Patients
                               where tb.HN.ToString() == _strHN
                               select tb).SingleOrDefault();

            txtHN.Text = patient.HN.ToString();
            txtNumber.Text = patient.Number.ToString();
            cbGender.SelectedValue = patient.Gender;
            cbTitle.SelectedValue = patient.TitleID;
            txtName.Text = patient.Name;
            txtLastName.Text = patient.LastName;
            cbDDM.Checked = patient.DiseaseDM.Value;
            cbDHT.Checked = patient.DiseaseHT.Value;
            cbDFat.Checked = patient.DiseaseFat.Value;
            cbDHeart.Checked = patient.DiseaseHeart.Value;
            cbDStroke.Checked = patient.DiseaseStroke.Value;
            cbDTB.Checked = patient.DiseaseTB.Value;
            cbDARV.Checked = patient.DiseaseARV.Value;
            cbDOther.Checked = patient.DiseaseOther.Value;
            cbDReject.Checked = patient.DiseaseReject.Value;

            //System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("en-US");

            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

            DateTime dt = Convert.ToDateTime(patient.BirthDate, currentCulture);

            dateBirthDate.Value = dt;//dt.Year+dt.Month+dt.Day;

            cbDistrict.SelectedValue = patient.DistrictID;
            cbStatus.SelectedValue = patient.StatusID;
            txtHN.Enabled = false;

            getDataPatientRecord();
        }

        private void getDataPatientRecord()
        {
            gvPatientRecord.DataSource = getData.getPatientRecordByHN(Convert.ToInt32(txtHN.Text));
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
            patient.Gender = cbGender.SelectedValue.ToString();
            patient.TitleID = Convert.ToInt16(cbTitle.SelectedValue);
            patient.Name = txtName.Text.Trim();
            patient.LastName = txtLastName.Text.Trim();
            patient.BirthDate = dateBirthDate.Value;
            patient.DistrictID = Convert.ToInt16(cbDistrict.SelectedValue);
            patient.StatusID = Convert.ToInt16(cbStatus.SelectedValue);
            patient.DiseaseDM = cbDDM.Checked;
            patient.DiseaseHT = cbDHT.Checked;
            patient.DiseaseFat = cbDFat.Checked;
            patient.DiseaseHeart = cbDHeart.Checked;
            patient.DiseaseStroke = cbDStroke.Checked;
            patient.DiseaseTB = cbDTB.Checked;
            patient.DiseaseARV = cbDARV.Checked;
            patient.DiseaseOther = cbDOther.Checked;
            patient.DiseaseReject = cbDReject.Checked;

            db.SubmitChanges();
            
            MessageBox.Show("บันทึกเสร็จสิ้น");
            btnAddrecordDetail.Visible = true;
            //startForm start = new startForm();
            //this.Close();      
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddrecordDetail_Click(object sender, EventArgs e)
        {
            FormPatientRecord fpr = new FormPatientRecord(Convert.ToInt32(txtHN.Text),cbGender.SelectedValue.ToString());
            fpr.ShowDialog();
            getDataPatientRecord();
        }

        private void gvPatientRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvPatientRecord.Columns[e.ColumnIndex].Name == "clmBtnEdit")
            {
                string a = gvPatientRecord.CurrentRow.Cells[1].Value.ToString();

                FormPatientRecord fpr = new FormPatientRecord(Convert.ToInt16(gvPatientRecord.CurrentRow.Cells[1].Value.ToString()),Convert.ToInt32(txtHN.Text),cbGender.SelectedValue.ToString());
                fpr.ShowDialog();

                getDataPatientRecord();
            }
        }

    }
}
