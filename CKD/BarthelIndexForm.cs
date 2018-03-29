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
    public partial class BarthelIndexForm : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        private int recordID { get; set; }
        private PatientRecordDetail barthelRecord { get; set; }
        public BarthelIndexForm()
        {
            InitializeComponent();
        }

        public BarthelIndexForm(int _recordID,PatientRecordDetail _barthelRecord)
        {
            InitializeComponent();
            recordID = _recordID;
            barthelRecord = _barthelRecord;
            getData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormPatientRecord.BarthelIndexValue = Convert.ToInt16(lblTotal.Text);

            PatientRecordDetail PRD = new PatientRecordDetail();
            PRD.Feeding = Convert.ToInt16(label1.Text);
            PRD.Transfer = Convert.ToInt16(label2.Text);
            PRD.Grooming = Convert.ToInt16(label3.Text);
            PRD.Toilet__ = Convert.ToInt16(label4.Text);
            PRD.Bathing = Convert.ToInt16(label5.Text);
            PRD.Mobility = Convert.ToInt16(label6.Text);
            PRD.Stair = Convert.ToInt16(label7.Text);
            PRD.Dressing = Convert.ToInt16(label8.Text);
            PRD.Bowels = Convert.ToInt16(label9.Text);
            PRD.Bladder = Convert.ToInt16(label10.Text);
            FormPatientRecord.barthelRecord = PRD;
            this.Close();
        }

        private void getData()
        {
            PatientRecordDetail PRD = new PatientRecordDetail();
            if (barthelRecord != null)
            {
                PRD = barthelRecord;
            }
            else
            {
                PRD = (from tb in db.PatientRecordDetails
                       where tb.recordID == recordID
                       select tb).SingleOrDefault();
            }
            if (PRD != null)
            {
                //1.Feeding
                if (PRD.Feeding == 1)
                    rdb11.Checked = true;
                else if (PRD.Feeding == 2)
                    rdb12.Checked = true;
                else
                    rdb10.Checked = true;
                //2.Transfer
                if (PRD.Transfer == 1)
                    rdb21.Checked = true;
                else if (PRD.Transfer == 2)
                    rdb22.Checked = true;
                else if (PRD.Transfer == 3)
                    rdb23.Checked = true;
                else
                    rdb30.Checked = true;
                //3.Grooming
                if (PRD.Grooming == 1)
                    rdb31.Checked = true;
                else
                    rdb30.Checked = true;
                //4.Toilet
                if (PRD.Toilet__ == 1)
                    rdb41.Checked = true;
                else if (PRD.Toilet__ == 2)
                    rdb42.Checked = true;
                else
                    rdb40.Checked = true;
                //5.Bathing
                if (PRD.Bathing == 1)
                    rdb51.Checked = true;
                else
                    rdb50.Checked = true;
                //6.Mobility
                if (PRD.Mobility == 1)
                    rdb61.Checked = true;
                else if (PRD.Mobility == 2)
                    rdb62.Checked = true;
                else if (PRD.Mobility == 3)
                    rdb63.Checked = true;
                else
                    rdb60.Checked = true;
                //7.Stair
                if (PRD.Stair == 1)
                    rdb71.Checked = true;
                else if (PRD.Stair == 2)
                    rdb72.Checked = true;
                else
                    rdb70.Checked = true;
                //8.Dressing
                if (PRD.Dressing == 1)
                    rdb81.Checked = true;
                else if (PRD.Dressing == 2)
                    rdb82.Checked = true;
                else
                    rdb80.Checked = true;
                //9.Bowels
                if (PRD.Bowels == 1)
                    rdb91.Checked = true;
                else if (PRD.Bowels == 2)
                    rdb92.Checked = true;
                else
                    rdb90.Checked = true;
                //10.Bladder
                if (PRD.Bladder == 1)
                    rdb101.Checked = true;
                else if (PRD.Bladder == 2)
                    rdb102.Checked = true;
                else
                    rdb100.Checked = true;

            }
        }

        private void setTotal()
        {
            try
            {
                int _total = Convert.ToInt16(label1.Text)
                    + Convert.ToInt16(label2.Text)
                    + Convert.ToInt16(label3.Text)
                    + Convert.ToInt16(label4.Text)
                    + Convert.ToInt16(label5.Text)
                    + Convert.ToInt16(label6.Text)
                    + Convert.ToInt16(label7.Text)
                    + Convert.ToInt16(label8.Text)
                    + Convert.ToInt16(label9.Text)
                    + Convert.ToInt16(label10.Text);

                lblTotal.Text = _total.ToString();
                if (_total <= 4)
                {
                    lblTotalDetail.Text = "Severe disable / Dependent";
                    lblTotalDetail.ForeColor = Color.Red;
                }
                else if (_total <= 9)
                {
                    lblTotalDetail.Text = "Maximum assistance";
                    lblTotalDetail.ForeColor = Color.Orange;
                }
                else if (_total <= 14)
                {
                    lblTotalDetail.Text = "Moderate assistance";
                    lblTotalDetail.ForeColor = Color.Yellow;
                }
                else if (_total <= 19)
                {
                    lblTotalDetail.Text = "Minimal assistance";
                    lblTotalDetail.ForeColor = Color.Blue;
                }
                else
                {
                    lblTotalDetail.Text = "Independent";
                    lblTotalDetail.ForeColor = Color.Green;
                }
            }
            catch
            {

            }
        }
        #region RadioButton Event
        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb10.Checked)
                label1.Text = "0";
            else if (rdb11.Checked)
                label1.Text = "1";
            else if (rdb12.Checked)
                label1.Text = "2";

            setTotal();
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb20.Checked)
                label2.Text = "0";
            else if (rdb21.Checked)
                label2.Text = "1";
            else if (rdb22.Checked)
                label2.Text = "2";
            else if (rdb23.Checked)
                label2.Text = "3";

            setTotal();
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb30.Checked)
                label3.Text = "0";
            else if (rdb31.Checked)
                label3.Text = "1";

            setTotal();
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb40.Checked)
                label4.Text = "0";
            else if (rdb41.Checked)
                label4.Text = "1";
            else if (rdb42.Checked)
                label4.Text = "2";

            setTotal();
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb50.Checked)
                label5.Text = "0";
            else if (rdb51.Checked)
                label5.Text = "1";

            setTotal();
        }

        private void rdb6_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb60.Checked)
                label6.Text = "0";
            else if (rdb61.Checked)
                label6.Text = "1";
            else if (rdb62.Checked)
                label6.Text = "2";
            else if (rdb63.Checked)
                label6.Text = "3";

            setTotal();
        }

        private void rdb7_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb70.Checked)
                label7.Text = "0";
            else if (rdb71.Checked)
                label7.Text = "1";
            else if (rdb72.Checked)
                label7.Text = "2";

            setTotal();
        }

        private void rdb8_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb80.Checked)
                label8.Text = "0";
            else if (rdb81.Checked)
                label8.Text = "1";
            else if (rdb82.Checked)
                label8.Text = "2";

            setTotal();
        }

        private void rdb9_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb90.Checked)
                label9.Text = "0";
            else if (rdb91.Checked)
                label9.Text = "1";
            else if (rdb92.Checked)
                label9.Text = "2";

            setTotal();
        }

        private void rdb10_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb100.Checked)
                label10.Text = "0";
            else if (rdb101.Checked)
                label10.Text = "1";
            else if (rdb102.Checked)
                label10.Text = "2";

            setTotal();
        }
        #endregion
    }
}
