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

namespace CKD
{
    public partial class startForm : Form
    {
        GetData getData = new GetData();
        public Form MainForm { get; set; }
        public startForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getDataPatient();
        }

        public void getDataPatient()
        {
            DataTable dt = new DataTable();
            dt = getData.getHN(txtHN.Text);
            gvPatient.DataSource = dt;

        }

        private void gvPatient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //gvPatient.Rows[e.RowIndex].Cells[0].Value = "View";
        }

        private void gvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gvPatient.Columns[e.ColumnIndex].Name == "btnView")
            {
                string a = gvPatient.CurrentRow.Cells[1].Value.ToString();
                PatientDetail pd = new PatientDetail(gvPatient.CurrentRow.Cells[1].Value.ToString());
                pd.Show();
                //Application.Run();
                this.Hide();
            }
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            PatientDetail pd = new PatientDetail();
            pd.Show();
            //Application.Run();
            this.Hide();
        }
    }
}
