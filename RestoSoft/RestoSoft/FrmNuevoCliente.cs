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
    public partial class FrmNuevoCliente : Form
    {
        public static string NombreCliente,telefono,visitas;
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClientes);
            MessageBox.Show("Nuevo usuario registrado", "Registro Exitoso");
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClientes.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSetClientes.clientes);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Respuesta;
            ServiceReference1.ServicioSoapClient ObjService = new ServiceReference1.ServicioSoapClient();
            NombreCliente = textBox1.Text;
            telefono = textBox2.Text;
            visitas = textBox3.Text;
            Respuesta=ObjService.ingresarCliente(NombreCliente, telefono);
            MessageBox.Show(Respuesta, "Ingreso De Usuario Exitoso");

        }
    }
}
