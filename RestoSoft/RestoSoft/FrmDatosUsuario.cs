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
    public partial class FrmDatosUsuario : Form
    {
        public FrmDatosUsuario()
        {
            InitializeComponent();
        }

        private void FrmDatosUsuario_Load(object sender, EventArgs e)
        {
            InformacionDeUsuario Obj = new InformacionDeUsuario();
            string Nombre = Obj.DesplegarNombreUsuario();
            string Pass = Obj.DesplegarPass();
            string Puesto = Obj.DesplegarPuesto();
            string NombreReal = Obj.DesplegarNombre();
            string Dir = Obj.DesplegarDir();
            string Telefono = Obj.DesplegarNumero();
            textBox1.Text = Nombre;
            textBox2.Text = Pass;
            textBox3.Text = Puesto;
            textBox4.Text = NombreReal;
            textBox5.Text = Dir;
            textBox6.Text = Telefono;
        }
    }
}
