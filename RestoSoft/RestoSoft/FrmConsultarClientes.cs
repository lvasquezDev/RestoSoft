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
    public partial class FrmConsultarClientes : Form
    {
        public FrmConsultarClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClientes);

        }

        private void FrmConsultarClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClientes.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSetClientes.clientes);

        }
    }
}
