using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestoSoft
{
    public partial class FrmConsultaDomicilio : Form
    {
        public FrmConsultaDomicilio()
        {
            InitializeComponent();
        }

        private void domicilioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.domicilioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetDomicilio);

        }

        private void FrmConsultaDomicilio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDomicilio.domicilio' table. You can move, or remove it, as needed.
            this.domicilioTableAdapter.Fill(this.dataSetDomicilio.domicilio);

        }
    }
}
