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
            //Transfer
            var transfer = (from tb in db.refTransfers
                       select tb);
            if (transfer != null)
            {
                cbTransfer.DataSource = transfer;
                cbTransfer.ValueMember = "Id";
                cbTransfer.DisplayMember = "Detail";
            }

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

            //Balance
            var balance = (from tb in db.refBalances
                           select tb);
            if(balance != null)
            {
                cbBalance.DataSource = balance;
                cbBalance.ValueMember = "Id";
                cbBalance.DisplayMember = "Detail";
            }

            //MMTLLE
            var MMTLLE = (from tb in db.refMMTs
                       select tb);
            if(MMTLLE != null)
            {
                cbMMTLLE.DataSource = MMTLLE;
                cbMMTLLE.ValueMember = "Id";
                cbMMTLLE.DisplayMember = "Detail";
            }

            //MMTLUE
            var MMTLUE = (from tb in db.refMMTs
                          select tb);
            if (MMTLUE != null)
            {
                cbMMTLUE.DataSource = MMTLUE;
                cbMMTLUE.ValueMember = "Id";
                cbMMTLUE.DisplayMember = "Detail";
            }

            //MMTRLE
            var MMTRLE = (from tb in db.refMMTs
                          select tb);
            if (MMTLUE != null)
            {
                cbMMTRLE.DataSource = MMTRLE;
                cbMMTRLE.ValueMember = "Id";
                cbMMTRLE.DisplayMember = "Detail";
            }

            //MMTRUE
            var MMTRUE = (from tb in db.refMMTs
                          select tb);
            if (MMTLUE != null)
            {
                cbMMTRUE.DataSource = MMTRUE;
                cbMMTRUE.ValueMember = "Id";
                cbMMTRUE.DisplayMember = "Detail";
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

                patientRecord.CreateDate = DateTime.Now;
            }

            patientRecord.HN = HN;
            patientRecord.recordDate = recordDate.Value;
            patientRecord.eGFR = Convert.ToInt16(txteGFR.Text);
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
            patientRecord.estimate1 = Convert.ToDecimal(txtEst1.Text);
            patientRecord.estimate2 = Convert.ToDecimal(txtEst2.Text);
            patientRecord.estimate3 = Convert.ToDecimal(txtEst3.Text);
            patientRecord.estimate4 = Convert.ToDecimal(txtEst4.Text);
            patientRecord.estimate5 = Convert.ToDecimal(txtEst5.Text);
            patientRecord.estimate6 = Convert.ToDecimal(txtEst6.Text);
            //Barthel Index
            patientRecord.BarthelIndex = BarthelIndexValue;
            //Bed Mobility
            patientRecord.BedMobility = Convert.ToInt16(cbBedMobility.SelectedValue);
            //Balance
            patientRecord.Balance = Convert.ToInt16(cbBalance.SelectedValue);
            //Ambulate
            patientRecord.Ambulate = Convert.ToInt16(cbAmbulateWith.SelectedValue);
            //MMT
            patientRecord.MMTRightUE = Convert.ToInt16(cbMMTRUE.SelectedValue);
            patientRecord.MMTRightLE = Convert.ToInt16(cbMMTRLE.SelectedValue);
            patientRecord.MMTLeftUE = Convert.ToInt16(cbMMTLUE.SelectedValue);
            patientRecord.MMTLeftLE = Convert.ToInt16(cbMMTLLE.SelectedValue);

            patientRecord.Tired = cbtired.Checked;
            patientRecord.Pain = txtPain.Text.Trim();
            patientRecord.Edema = txtEdema.Text.Trim();
            patientRecord.Other = txtOther.Text.Trim();

            patientRecord.ModifiedDate = DateTime.Now;

            db.SubmitChanges();
            MessageBox.Show("บันทึกเสร็จสิ้น");
            this.Close();
            
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }
    }
}
