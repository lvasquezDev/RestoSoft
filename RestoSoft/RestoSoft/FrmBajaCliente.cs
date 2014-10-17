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
    public partial class FrmBajaCliente : Form
    {
        public static string Nombre;
        public static string Telefono;
        public FrmBajaCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetClientes);

        }

        private void FrmBajaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClientes.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSetClientes.clientes);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro eliminado correctamente", "Eliminacion");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Nombre = comboBox1.SelectedValue.ToString();
            Consultas Obj = new Consultas();
            telefonoTextBox.Text = Obj.ActualizarDatosCliente(Nombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Respuesta;
            Nombre=comboBox1.SelectedValue.ToString();
            Telefono=telefonoTextBox.Text;
            ServiceReference1.ServicioSoapClient ObjServicio = new ServiceReference1.ServicioSoapClient();
            Respuesta = ObjServicio.eliminarCliente(Nombre, Telefono);
            MessageBox.Show(Respuesta,"Registro Eliminado");
            Nombre = "";
            Telefono = "";
            comboBox1.Text = "";
            telefonoTextBox.Text = "";
            visitasTextBox.Text = "";
        }
    }
}
