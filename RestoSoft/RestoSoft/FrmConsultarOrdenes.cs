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
    public partial class FrmConsultarOrdenes : Form
    {
        public FrmConsultarOrdenes()
        {
            InitializeComponent();
        }

        private void ordenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSetOrdenesBuenas);

        }

        private void FrmConsultarOrdenes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetOrdenesBuenas.ordenes' table. You can move, or remove it, as needed.
            this.ordenesTableAdapter.Fill(this.restosoftDataSetOrdenesBuenas.ordenes);

        }
    }
}
