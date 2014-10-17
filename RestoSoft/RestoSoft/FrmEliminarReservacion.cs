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
    public partial class FrmEliminarReservacion : Form
    {
        public FrmEliminarReservacion()
        {
            InitializeComponent();
        }

        private void reservacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetReservaciones);

        }

        private void FrmEliminarReservacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReservaciones.reservacion' table. You can move, or remove it, as needed.
            this.reservacionTableAdapter.Fill(this.dataSetReservaciones.reservacion);

        }
    }
}
