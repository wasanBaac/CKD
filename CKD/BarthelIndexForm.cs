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
        public BarthelIndexForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormPatientRecord.BarthelIndexValue = 2.5;
            //FormPatientRecord.
            this.Close();
            
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
                    lblTotalDetail.Text = "Maximum assistance";
                    lblTotalDetail.ForeColor = Color.YellowGreen;
                }
                else
                {
                    lblTotalDetail.Text = "Maximum assistance";
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
