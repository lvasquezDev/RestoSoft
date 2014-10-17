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
    public partial class FrmModificarPlatillo : Form
    {
        public FrmModificarPlatillo()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSetModificarPorductos);
            nombreproductoTextBox.Enabled = false;
            tipoComidaTextBox.Enabled = false;
            precioTextBox.Enabled = false;
            descripcionTextBox.Enabled = false;
            costoTextBox.Enabled = false;
        }

        private void FrmModificarPlatillo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetModificarPorductos.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.restosoftDataSetModificarPorductos.producto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreproductoTextBox.Enabled = true;
            tipoComidaTextBox.Enabled = true;
            precioTextBox.Enabled = true;
            descripcionTextBox.Enabled = true;
            costoTextBox.Enabled = true;
        }
    }
}
