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
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetUsuarios);

        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsuarios.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSetUsuarios.usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NombreU, Pass, Puesto, Nombre, Direccion, Telefono;
            string Respuesta;
            ServiceReference1.ServicioSoapClient ObjService = new ServiceReference1.ServicioSoapClient();
            NombreU = textBox1.Text;
            Pass = textBox2.Text;
            Puesto = textBox3.Text;
            Nombre = textBox4.Text;
            Direccion = textBox5.Text;
            Telefono = textBox6.Text;
            Respuesta=ObjService.ingresarUsuario(NombreU, Pass, Puesto, Nombre, Direccion, Telefono);
            MessageBox.Show(Respuesta, "Registro De Usuario");
        }

    }
}
