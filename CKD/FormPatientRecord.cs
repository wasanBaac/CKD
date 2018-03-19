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
        public static double BarthelIndexValue { get; set; }
        public FormPatientRecord()
        {
            InitializeComponent();
            lnklblBarthelIndex.Text = BarthelIndexValue.ToString();
        }

        private void lnklblBarthelIndex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BarthelIndexForm BIF = new BarthelIndexForm();
            BIF.ShowDialog();
            lnklblBarthelIndex.Text = BarthelIndexValue.ToString();
        }
    }
}
