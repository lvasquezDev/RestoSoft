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
    public partial class FrmBajaUsuarios : Form
    {
        public static string Nombre,Puesto,Pass;
        public FrmBajaUsuarios()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetUsuarios);

        }

        private void FrmBajaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsuarios.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSetUsuarios.usuario);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Respuesta;
            Nombre = comboBox1.SelectedValue.ToString();
            ServiceReference1.ServicioSoapClient ObjWebService = new ServiceReference1.ServicioSoapClient();
            Respuesta=ObjWebService.eliminarUsuario(Nombre, Pass, Puesto);
            MessageBox.Show(Respuesta, "Registro Eliminado");
            Nombre = "";
            Pass = "";
            Puesto = "";
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nombre = comboBox1.SelectedValue.ToString();
            Consultas Obj = new Consultas();
            Pass = Obj.ActualizarDatosUsuario(Nombre);
            Puesto = Obj.ActualizarDatosUsuarioPuesto(Nombre);
        }
    }
}
