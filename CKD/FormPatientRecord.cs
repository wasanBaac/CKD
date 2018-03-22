using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKD
{
    public partial class FormPatientRecord : Form
    {
        public static int BarthelIndexValue { get; set; }
        public static PatientRecordDetail barthelRecord { get; set; }

        private int recordID;
        private Int32 HN;

        DataClassesDataContext db = new DataClassesDataContext();
        public FormPatientRecord()
        {
            InitializeComponent();
            SetData();
            //lnklblBarthelIndex.Text = BarthelIndexValue.ToString();
        }
        public FormPatientRecord(int _recordID,Int32 _HN)
        {
            InitializeComponent();
            SetData();
            recordID = _recordID;
            HN = _HN;
        }

        private void SetData()
        {
            //combobox bedmobility
            var bed = (from tb in db.refBedMobilities
                                  select tb);
            if(bed != null)
            {
                cbBedMobility.DataSource = bed;
                cbBedMobility.ValueMember = "Id";
                cbBedMobility.DisplayMember = "Detail";
            }

            //Ambulate with
            var ambu = (from tb in db.refAmbulates
                        select tb);
            if(ambu != null)
            {
                cbAmbulateWith.DataSource = ambu;
                cbAmbulateWith.ValueMember = "Id";
                cbAmbulateWith.DisplayMember = "Detail";
            }
        }
        private void lnklblBarthelIndex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BarthelIndexForm BIF = new BarthelIndexForm();
            BIF.ShowDialog();
            lnklblBarthelIndex.Text = BarthelIndexValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientRecord patientRecord = (from tb in db.PatientRecords
                               where tb.recordID == recordID
                               select tb).SingleOrDefault();
            if(patientRecord == null)
            {
                patientRecord = new PatientRecord();
                db.PatientRecords.InsertOnSubmit(patientRecord);
            }

            patientRecord.HN = HN;
            patientRecord.recordDate = recordDate.Value;
            patientRecord.eGFRstage = Convert.ToInt16(txteGFR.Text);
            patientRecord.weight = Convert.ToDecimal(txtWeight.Text);
            patientRecord.height = Convert.ToDecimal(txtHeight.Text);
            //การได้รับการรักษา
            patientRecord.treatNone = cbTreatNone.Checked;
            patientRecord.treatBelly = cbTreatBelly.Checked;
            patientRecord.treatNeck = cbTreatNeck.Checked;
            patientRecord.treatArm = cbTreatArm.Checked;
            //การออกกำลังกายที่บ้าน
            patientRecord.exWalk = cbExwalk.Checked;
            patientRecord.exRun = cbExRun.Checked;
            patientRecord.exBite = cbExBite.Checked;
            patientRecord.exProgram = cbExProgram.Checked;
            patientRecord.exReject = cbExReject.Checked;
            //สุขศึกษา
            patientRecord.healtEducation = cbHealtEducation.Checked;
            patientRecord.healtBenefit = cbHealBenefit.Checked;
            //โปรแกรมการออกกำลังกาย
            patientRecord.progeamEx1 = cbProgrameEx1.Checked;
            patientRecord.programEx2 = cbProgrameEx2.Checked;
            //การประเมิน
            patientRecord.estimate1 = cbEstimate1.Checked;
            patientRecord.estimate2 = cbEstimate2.Checked;
            patientRecord.estimate3 = cbEstimate3.Checked;
            patientRecord.estimate4 = cbEstimate4.Checked;
            patientRecord.estimate5 = cbEstimate5.Checked;
            patientRecord.estimate6 = cbEstimate6.Checked;
            //Barthel Index
            patientRecord.BarthelIndex = BarthelIndexValue;
            //Bed Mobility
            //patientRecord.BedMobility = rdbMaximal.Checked;
            
        }
    }
}
