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
    }
}
