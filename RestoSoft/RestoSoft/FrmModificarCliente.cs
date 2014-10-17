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
    public partial class FrmModificarCliente : Form
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSetModificarClientes);
            nombreClienteTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            visitasTextBox.Enabled = false;
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetModificarClientes.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.restosoftDataSetModificarClientes.clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreClienteTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            visitasTextBox.Enabled = true;
        }
    }
}
