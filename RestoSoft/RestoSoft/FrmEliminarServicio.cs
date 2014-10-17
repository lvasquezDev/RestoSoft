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
    public partial class FrmEliminarServicio : Form
    {
        public FrmEliminarServicio()
        {
            InitializeComponent();
        }

        private void servicioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSetServicio);

        }

        private void FrmEliminarServicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetServicio.servicio' table. You can move, or remove it, as needed.
            this.servicioTableAdapter.Fill(this.restosoftDataSetServicio.servicio);

        }
    }
}
