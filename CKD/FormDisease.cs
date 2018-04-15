using CKD.Class;
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
    public partial class FormDisease : Form
    {
        GetData getData = new GetData();
        public FormDisease()
        {
            InitializeComponent();
            setData();
        }
        
        private void setData()
        {
            lbDisease.DataSource = getData.getDisease();
            lbDisease.ValueMember = "Id";
            lbDisease.DisplayMember = "Detail";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbDiseaseSelected.Items.Add(lbDisease.SelectedItem);
            lbDiseaseSelected.ValueMember = "Id";
            lbDiseaseSelected.DisplayMember = "Detail";

            int _index = lbDisease.SelectedIndex;

            lbDisease.Items.RemoveAt(_index);
        }
    }
}
