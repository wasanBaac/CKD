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
        public static string BarthelIndexDetail { get; set; }
        public static PatientRecordDetail barthelRecord { get; set; }
        private int recordID { get; set; }
        private Int32 HN { get; set; }
        private string strGender { get; set; }

        DataClassesDataContext db = new DataClassesDataContext();
        public FormPatientRecord(Int32 _HN,string _strGender)
        {
            InitializeComponent();
            HN = _HN;
            strGender = _strGender;
            setData();
            //lnklblBarthelIndex.Text = BarthelIndexValue.ToString();
        }
        public FormPatientRecord(int _recordID,Int32 _HN,string _strGender)
        {
            InitializeComponent();
            strGender = _strGender;
            setData();
            recordID = _recordID;
            HN = _HN;
            getData();
        }

        private void setData()
        {
            //Transfer
            var transfer = (from tb in db.refTransfers
                       select tb);
            if (transfer != null)
            {
                cbbTransfer.DataSource = transfer;
                cbbTransfer.ValueMember = "Id";
                cbbTransfer.DisplayMember = "Detail";
            }

            //combobox bedmobility
            var bed = (from tb in db.refBedMobilities
                                  select tb);
            if(bed != null)
            {
                cbbBedMobility.DataSource = bed;
                cbbBedMobility.ValueMember = "Id";
                cbbBedMobility.DisplayMember = "Detail";
            }

            //Ambulate with
            var ambu = (from tb in db.refAmbulates
                        select tb);
            if(ambu != null)
            {
                cbbAmbulateWith.DataSource = ambu;
                cbbAmbulateWith.ValueMember = "Id";
                cbbAmbulateWith.DisplayMember = "Detail";
            }

            //Balance
            var balance = (from tb in db.refBalances
                           select tb);
            if(balance != null)
            {
                cbbBalance.DataSource = balance;
                cbbBalance.ValueMember = "Id";
                cbbBalance.DisplayMember = "Detail";
            }

            //MMTLLE
            var MMTLLE = (from tb in db.refMMTs
                       select tb);
            if(MMTLLE != null)
            {
                cbbMMTLLE.DataSource = MMTLLE;
                cbbMMTLLE.ValueMember = "Id";
                cbbMMTLLE.DisplayMember = "Detail";
            }

            //MMTLUE
            var MMTLUE = (from tb in db.refMMTs
                          select tb);
            if (MMTLUE != null)
            {
                cbbMMTLUE.DataSource = MMTLUE;
                cbbMMTLUE.ValueMember = "Id";
                cbbMMTLUE.DisplayMember = "Detail";
            }

            //MMTRLE
            var MMTRLE = (from tb in db.refMMTs
                          select tb);
            if (MMTLUE != null)
            {
                cbbMMTRLE.DataSource = MMTRLE;
                cbbMMTRLE.ValueMember = "Id";
                cbbMMTRLE.DisplayMember = "Detail";
            }

            //MMTRUE
            var MMTRUE = (from tb in db.refMMTs
                          select tb);
            if (MMTLUE != null)
            {
                cbbMMTRUE.DataSource = MMTRUE;
                cbbMMTRUE.ValueMember = "Id";
                cbbMMTRUE.DisplayMember = "Detail";
            }
        }
        private void getData()
        {
            PatientRecord ptr = (from tb in db.PatientRecords
                                 where tb.recordID == recordID
                                 select tb).SingleOrDefault();
            if(ptr != null)
            {
                recordDate.Value = Convert.ToDateTime(ptr.recordDate);
                txteGFR.Text = ptr.eGFR.ToString();
                txtCreatinine.Text = ptr.Creatinine.ToString();
                txtWeight.Text = ptr.weight.ToString();
                txtHeight.Text = ptr.height.ToString();
                //การได้รับการรักษา
                cbTreatNone.Checked = ptr.treatNone.Value;
                cbTreatBelly.Checked = ptr.treatBelly.Value;
                cbTreatNeck.Checked = ptr.treatNeck.Value;
                cbTreatArm.Checked = ptr.treatArm.Value;
                //การออกกำลังกาย
                cbExwalk.Checked = ptr.exWalk.Value;
                cbExRun.Checked = ptr.exRun.Value;
                cbExBite.Checked = ptr.exBite.Value;
                cbExProgram.Checked = ptr.exProgram.Value;
                cbExReject.Checked = ptr.exReject.Value;
                //สุขศึกษา
                cbHealtEducation.Checked = ptr.healtEducation.Value;
                cbHealBenefit.Checked = ptr.healtBenefit.Value;
                //โปรแกรมการออกกำลังกาย
                cbProgrameEx1.Checked = ptr.programEx1.Value;
                cbProgrameEx2.Checked = ptr.programEx2.Value;
                //การประเมิน
                txtEst1.Text = ptr.estimate1.ToString();
                txtEst2.Text = ptr.estimate2.ToString();
                txtEst3.Text = ptr.estimate3.ToString();
                txtEst4.Text = ptr.estimate4.ToString();
                txtEst5.Text = ptr.estimate5.ToString();
                txtEst6.Text = ptr.estimate6.ToString();
                txtBarthelIndex.Text = ptr.BarthelIndex.ToString();
                //Other Detail
                cbbTransfer.SelectedValue = ptr.Transfer;
                cbbBedMobility.SelectedValue = ptr.BedMobility;
                cbbBalance.SelectedValue = ptr.Balance;
                cbbAmbulateWith.SelectedValue = ptr.Ambulate;
                cbbMMTRUE.SelectedValue = ptr.MMTRightUE;
                cbbMMTLUE.SelectedValue = ptr.MMTLeftUE;
                cbbMMTRLE.SelectedValue = ptr.MMTRightLE;
                cbbMMTLLE.SelectedValue = ptr.MMTLeftLE;
                txtPain.Text = ptr.Pain;
                txtEdema.Text = ptr.Edema;
                cbtired.Checked = ptr.Tired.Value;
                txtOther.Text = ptr.Other;
                txtKnowlege.Text = ptr.Knowlege.Value.ToString();
                txtExcercise.Text = ptr.excercise.Value.ToString();
            }
        }
        private void lnklblBarthelIndex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BarthelIndexForm BIF = new BarthelIndexForm(recordID,barthelRecord);
            BIF.ShowDialog();
            txtBarthelIndex.Text = BarthelIndexValue.ToString();
        }
        private bool valid()
        {
            decimal dc;
            int _int;
            if(!decimal.TryParse(txteGFR.Text.Trim(),out dc))
            {
                MessageBox.Show("eGFR ไม่ถูกต้อง");
                txteGFR.Focus();
                return true;
            }
            else if(Convert.ToDecimal(txteGFR.Text.Trim()) >= 100)
            {
                MessageBox.Show("eGFRต้องไม่เกิน 99.99");
                txteGFR.Focus();
                return true;
            }
            else if (!decimal.TryParse(txtCreatinine.Text.Trim(), out dc))
            {
                MessageBox.Show("Creatinine ไม่ถูกต้อง");
                txtWeight.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtCreatinine.Text.Trim()) >= 1000)
            {
                MessageBox.Show("Creatinine ต้องไม่เกิน 99.99");
                txtWeight.Focus();
                return true;
            }
            else if (!decimal.TryParse(txtWeight.Text.Trim(), out dc))
            {
                MessageBox.Show("น้ำหนักไม่ถูกต้อง");
                txtWeight.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtWeight.Text.Trim()) >= 1000)
            {
                MessageBox.Show("น้ำหนักต้องไม่เกิน 999.9");
                txtWeight.Focus();
                return true;
            }
            else if (!decimal.TryParse(txtHeight.Text.Trim(), out dc))
            {
                MessageBox.Show("ส่วนสูงไม่ถูกต้อง");
                txtHeight.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtHeight.Text.Trim()) >= 1000)
            {
                MessageBox.Show("ส่วนสูงต้องไม่เกิน 999.9");
                txtHeight.Focus();
                return true;
            }
            else if(!decimal.TryParse(txtEst1.Text.Trim(), out dc))
            {
                MessageBox.Show("ดัชนีมวลกล้ามเนื้อ(BMI)ไม่ถูกต้อง");
                txtEst1.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtEst1.Text.Trim()) >= 1000)
            {
                MessageBox.Show("ดัชนีมวลกล้ามเนื้อ(BMI)ต้องไม่เกิน 999.99");
                txtEst1.Focus();
                return true;
            }

            else if (!decimal.TryParse(txtEst2.Text.Trim(), out dc))
            {
                MessageBox.Show("%ไขมันในร่างกายไม่ถูกต้อง");
                txtEst2.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtEst2.Text.Trim()) >= 1000)
            {
                MessageBox.Show("%ไขมันในร่างกายต้องไม่เกิน 999.99");
                txtEst2.Focus();
                return true;
            }

            else if (!decimal.TryParse(txtEst3.Text.Trim(), out dc))
            {
                MessageBox.Show("มวลกล้ามเนื้อทั้งตัวไม่ถูกต้อง");
                txtEst3.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtEst3.Text.Trim()) >= 1000)
            {
                MessageBox.Show("มวลกล้ามเนื้อทั้งตัวต้องไม่เกิน 999.99");
                txtEst3.Focus();
                return true;
            }

            else if (!decimal.TryParse(txtEst4.Text.Trim(), out dc))
            {
                MessageBox.Show("มวลกล้ามเนื้อแขนไม่ถูกต้อง");
                txtEst4.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtEst4.Text.Trim()) >= 1000)
            {
                MessageBox.Show("มวลกล้ามเนื้อแขนต้องไม่เกิน 999.99");
                txtEst4.Focus();
                return true;
            }

            else if (!decimal.TryParse(txtEst5.Text.Trim(), out dc))
            {
                MessageBox.Show("มวลกล้ามเนื้อขาไม่ถูกต้อง");
                txtEst5.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtEst5.Text.Trim()) >= 1000)
            {
                MessageBox.Show("มวลกล้ามเนื้อขาต้องไม่เกิน 999.99");
                txtEst5.Focus();
                return true;
            }

            else if (!decimal.TryParse(txtEst6.Text.Trim(), out dc))
            {
                MessageBox.Show("6MWTไม่ถูกต้อง");
                txtEst6.Focus();
                return true;
            }
            else if (Convert.ToDecimal(txtEst6.Text.Trim()) >= 1000)
            {
                MessageBox.Show("6MWTต้องไม่เกิน 999.99");
                txtEst6.Focus();
                return true;
            }
            else if (!int.TryParse(txtKnowlege.Text.Trim(), out _int))
            {
                MessageBox.Show("คะแนนความรู้ ไม่ถูกต้อง");
                txtKnowlege.Focus();
                return true;
            }
            else if (!int.TryParse(txtExcercise.Text.Trim(), out _int))
            {
                MessageBox.Show("คะแนนการออกกำลังกาย ไม่ถูกต้อง");
                txtExcercise.Focus();
                return true;
            }
            else if (Convert.ToInt16(txtExcercise.Text.Trim()) <0 || Convert.ToInt16(txtExcercise.Text.Trim()) > 7)
            {
                MessageBox.Show("คะแนนการออกกำลังกาย ไม่ถูกต้อง");
                txtExcercise.Focus();
                return true;
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                return;
            }
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
            patientRecord.eGFR = Convert.ToDecimal(txteGFR.Text);
            patientRecord.Creatinine = Convert.ToDecimal(txtCreatinine.Text);
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
            patientRecord.programEx1 = cbProgrameEx1.Checked;
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
            //Transfer
            patientRecord.Transfer = Convert.ToInt16(cbbTransfer.SelectedValue);
            //Bed Mobility
            patientRecord.BedMobility = Convert.ToInt16(cbbBedMobility.SelectedValue);
            //Balance
            patientRecord.Balance = Convert.ToInt16(cbbBalance.SelectedValue);
            //Ambulate
            patientRecord.Ambulate = Convert.ToInt16(cbbAmbulateWith.SelectedValue);
            //MMT
            patientRecord.MMTRightUE = Convert.ToInt16(cbbMMTRUE.SelectedValue);
            patientRecord.MMTRightLE = Convert.ToInt16(cbbMMTRLE.SelectedValue);
            patientRecord.MMTLeftUE = Convert.ToInt16(cbbMMTLUE.SelectedValue);
            patientRecord.MMTLeftLE = Convert.ToInt16(cbbMMTLLE.SelectedValue);

            patientRecord.Tired = cbtired.Checked;
            patientRecord.Pain = txtPain.Text.Trim();
            patientRecord.Edema = txtEdema.Text.Trim();
            patientRecord.Other = txtOther.Text.Trim();

            patientRecord.Knowlege = Convert.ToInt16(txtKnowlege.Text);
            patientRecord.excercise = Convert.ToInt16(txtExcercise.Text);

            patientRecord.ModifiedDate = DateTime.Now;            

            db.SubmitChanges();

            PatientRecordDetail barThel = (from tb in db.PatientRecordDetails
                                           where tb.recordID == patientRecord.recordID
            select tb).SingleOrDefault();
            if(barThel == null)
            {
                barThel = new PatientRecordDetail();
                db.PatientRecordDetails.InsertOnSubmit(barThel);
                barThel.CreateDate = DateTime.Now;
            }
            barThel.recordID = patientRecord.recordID;
            barThel.Feeding = barthelRecord.Feeding;
            barThel.Transfer = barthelRecord.Transfer;
            barThel.Grooming = barthelRecord.Grooming;
            barThel.Toilet__ = barthelRecord.Toilet__;
            barThel.Bathing = barthelRecord.Bathing;
            barThel.Mobility = barthelRecord.Mobility;
            barThel.Stair = barthelRecord.Stair;
            barThel.Dressing = barthelRecord.Dressing;
            barThel.Bowels = barthelRecord.Bowels;
            barThel.Bladder = barthelRecord.Bladder;
            barThel.ModifiedDate = DateTime.Now;

            db.SubmitChanges();
            MessageBox.Show("บันทึกเสร็จสิ้น");
            this.Close();
            
        }

        private void txteGFR_TextChanged(object sender, EventArgs e)
        {
            decimal dc;
            if (decimal.TryParse(txteGFR.Text.Trim(), out dc))
            {
                if (dc < 15)
                    lblStage.Text = "5";
                else if (dc >= 15 && dc <= 30)
                    lblStage.Text = "4";
                else if (dc > 30 && dc <= 60)
                    lblStage.Text = "3";
                else if (dc > 60 && dc <= 90)
                    lblStage.Text = "2";
                else if (dc > 90 && dc < 100)
                    lblStage.Text = "1";
                else if (dc >= 100)
                    lblStage.Text = "0";
            }
        }

        private void txtCreatinine_TextChanged(object sender, EventArgs e)
        {
            //ชาย
            double dc;
            if (double.TryParse(txtCreatinine.Text.Trim(), out dc))
            {
                if (strGender == "1")
                {
                    if (dc < 0.72)
                    {
                        lblCreatinineCal.Text = "ต่ำ";
                        lblCreatinineCal.ForeColor = Color.Red;
                    }
                    else if (dc >= 0.72 && dc <= 1.18)
                    {
                        lblCreatinineCal.Text = "ปกติ";
                        lblCreatinineCal.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lblCreatinineCal.Text = "สูง";
                        lblCreatinineCal.ForeColor = Color.Red;
                    }
                }
                //หญิง
                else if (strGender == "2")
                {
                    if (dc < 0.55)
                    {
                        lblCreatinineCal.Text = "ต่ำ";
                        lblCreatinineCal.ForeColor = Color.Red;
                    }
                    else if (dc >= 0.55 && dc <= 1.02)
                    {
                        lblCreatinineCal.Text = "ปกติ";
                        lblCreatinineCal.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lblCreatinineCal.Text = "สูง";
                        lblCreatinineCal.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            double dbWeight;
            double dbHeight;
            if (double.TryParse(txtWeight.Text.Trim(), out dbWeight) && double.TryParse(txtHeight.Text.Trim(), out dbHeight))
            {
                double BMIcal = Math.Round(dbWeight / Math.Pow((dbHeight / 100),2),2);
                txtEst1.Text = BMIcal.ToString();
                if(BMIcal < 18.5)
                {
                    lblBMI.Text = "น้ำหนักตำกว่าเกณฑ์";
                    lblBMI.ForeColor = Color.Brown;
                }
                else if(BMIcal >= 18.5 && BMIcal <= 22.9)
                {
                    lblBMI.Text = "สมส่วน";
                    lblBMI.ForeColor = Color.Green;
                }
                else if (BMIcal >= 23 && BMIcal <= 24.9)
                {
                    lblBMI.Text = "น้ำหนักเกิน";
                    lblBMI.ForeColor = Color.Yellow;
                }
                else if (BMIcal >= 25 && BMIcal <= 29.9)
                {
                    lblBMI.Text = "โรคอ้วน";
                    lblBMI.ForeColor = Color.Orange;
                }
                else if (BMIcal >= 30)
                {
                    lblBMI.Text = "โรคอ้วนอันตราย";
                    lblBMI.ForeColor = Color.Red;
                }
            }
        }

        private void txtEst1_TextChanged(object sender, EventArgs e)
        {
            double dbBMI;
            if (double.TryParse(txtEst1.Text.Trim(), out dbBMI))
            {
                //if()
            }
        }

        private void txtBarthelIndex_TextChanged(object sender, EventArgs e)
        {
            lblBarthelIndex.Text = BarthelIndexDetail;
        }

        private void txtKnowlege_TextChanged(object sender, EventArgs e)
        {
            int dc;
            if (int.TryParse(txtKnowlege.Text.Trim(), out dc))
            {
                if (dc <= 2)
                    lblKnowlege.Text = "น้อย";
                else if (dc >= 3 && dc <= 4)
                    lblKnowlege.Text = "พอใช้";
                else if (dc >= 5)
                    lblKnowlege.Text = "ดีมาก";
            }
        }

        private void txtExcercise_TextChanged(object sender, EventArgs e)
        {
            int dc;
            if (int.TryParse(txtExcercise.Text.Trim(), out dc))
            {
                if (dc == 0)
                    lblExercise.Text = "ไม่ออกกำลังกาย";
                else if (dc >= 1 && dc <= 2)
                    lblExercise.Text = "ออกกำลังกายบางครั้ง";
                else if (dc >= 3 && dc <= 6)
                    lblExercise.Text = "ออกกำลังกายสม่ำเสมอ";
                else if(dc >= 7)
                    lblExercise.Text = "ออกกำลังกายทุกวัน";
            }
        }
    }
}
