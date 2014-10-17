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
    public partial class FrmNuevoServicio : Form
    {
        public static string Mesa, Hrllegada, Hrasaldia, Nombrecliente;
        public static int Id;
        public FrmNuevoServicio()
        {
            InitializeComponent();
        }

        private void FrmNuevoServicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetMesas.mesa' table. You can move, or remove it, as needed.
            this.mesaTableAdapter1.Fill(this.restosoftDataSetMesas.mesa);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Mesa = comboBox1.SelectedValue.ToString();
            Hrllegada = DateTime.Now.ToString();
            Hrasaldia = DateTime.Now.ToString();
            Nombrecliente = textBox1.Text;
            Id = Id + 1;
            ServiceReference1.ServicioSoapClient ObjServicio = new ServiceReference1.ServicioSoapClient();
            label3.Text = ObjServicio.ingresarServicio(Id.ToString(), Mesa, Hrllegada, Hrasaldia, Nombrecliente);
            textBox1.Text = "";
        }
    }
}
