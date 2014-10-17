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
    public partial class FrmServicioDomicilio : Form
    {
        public static string StrgNombre,Telefono,Domicilio;
        public static int NoServicio = 0;
        public static string[] Platillo = new string[20];
        public static string[] Cantidad = new string[20];
        public static string[] Costo = new string[20];
        int ContadorPlatillo, ContadorCantidad, ContadorCosto;
        public FrmServicioDomicilio()
        {
            InitializeComponent();
        }

        private void FrmServicioDomicilio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProductos.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dataSetProductos.producto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inhabilitamos los controles:
            textBox4.Enabled = false;
            comboBox1.Enabled = false;
            button2.Visible = false;
            button3.Visible = false;
            //Habilitamos los demas controles:
            textBox5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button3.Visible = true;
            //Metodo Principal:
            ServiceReference1.ServicioSoapClient ObjServicio = new ServiceReference1.ServicioSoapClient();
            StrgNombre = textBox1.Text;
            Telefono = textBox2.Text;
            Domicilio = textBox3.Text;
            //Llamada al webservice:
            for (int i = 0; i < Platillo.Length; i++)
            {
                if (Platillo[i] != null)
                {
                    //Variables Auxiliares para: Producto, Cantidad Precio.
                    string Aux1, Aux2, Aux3;
                    Aux1 = Platillo[i];
                    Aux2 = Cantidad[i];
                    Aux3 = Costo[i];
                    textBox5.Text = ObjServicio.ingresarDomicilio(NoServicio.ToString(), StrgNombre, Telefono, Domicilio, Aux1, Aux2, Aux3);
                }
                else
                {
                    break;
                }
            }
            //Acontinuacion desplegamos la cuenta:
            textBox5.Text = "Orden:         Cantidad:       Precio:";
            for (int i = 0; i < Platillo.Length; i++)
            {
                if (Platillo[i] != null)
                {
                    textBox5.Text = textBox1.Text + "\r\n" + Platillo[i] + "         " + Cantidad[i] + "       " + Costo[i];
                }
                else
                {
                    break;
                }
            }
            //For para calcular la cuenta:
            double AuxTotal = 0.0;
            for (int i = 0; i < Costo.Length; i++)
            {
                if (Costo[i] != null)
                {
                    AuxTotal = (double.Parse(Costo[i]) * double.Parse(Cantidad[i]));
                    AuxTotal = AuxTotal + double.Parse(Costo[i]);
                }
            }
            label7.Text = AuxTotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Desactivamos las casillas anteriores:
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            Consultas ObjConsultas = new Consultas();
            //Platillos:
            if (ContadorPlatillo == 0)
            {
                Platillo[0] = comboBox1.SelectedValue.ToString();
                ContadorPlatillo = ContadorPlatillo + 1;
            }
            else
            {
                Platillo[ContadorPlatillo] = comboBox1.SelectedValue.ToString();
                ContadorPlatillo = ContadorPlatillo + 1;
            }
            //Cantidad:
            if (ContadorCantidad == 0)
            {
                Cantidad[0] = textBox4.Text;
                ContadorCantidad = ContadorCantidad + 1;
            }
            else
            {
                Cantidad[ContadorCantidad] = textBox4.Text;
                ContadorCantidad = ContadorCantidad + 1;
            }
            //Costo
            if (ContadorCosto == 0)
            {
                Costo[0] = ObjConsultas.ActualizarPrecios(Platillo[0]);
                ContadorCosto = ContadorCosto + 1;
            }
            else
            {
                Costo[ContadorCosto] = ObjConsultas.ActualizarPrecios(Platillo[ContadorCosto]);
                ContadorCosto = ContadorCosto + 1;
            }
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Limpiamos y habilitamos los controles anteriores:
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Enabled = true;
            button1.Visible = true;
            button2.Visible = true;
            //Escondemos los demas controles:
            textBox5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button3.Visible = false;
            textBox5.Text = "";
            label7.Text = "";
        }
    }
}
