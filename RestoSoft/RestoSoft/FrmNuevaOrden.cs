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
    public partial class FrmNuevaOrden : Form
    {
        public static string Nombre_Cliente;
        public static string Mesa;
        public static int IntNumeroOrden = 0;
        public static string Hora;
        public static string[] Cantidad = new string[20];
        public static string[] Ordenes = new string[20];
        public static string[] Precio = new string[20];
        public static int contadorOrdenes = 0, contadorCantidad = 0, contadorPrecios;
        public FrmNuevaOrden()
        {
            InitializeComponent();
        }


        private void FrmNuevaOrden_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProductos.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dataSetProductos.producto);
            // TODO: This line of code loads data into the 'dataSetClientes.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSetClientes.clientes);
            // TODO: This line of code loads data into the 'dataSetMesas.mesa' table. You can move, or remove it, as needed.
            this.mesaTableAdapter.Fill(this.dataSetMesas.mesa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre_Cliente = comboBox1.SelectedValue.ToString();
            label4.Text = Nombre_Cliente;
            //Arreglamos la vista, para pasar al siguiente requerimiento
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            comboBox2.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            //Escondemos estos controles:
            label10.Visible = false;
            button1.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            comboBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Con este boton regresaremos a la opcion anterior
            //Primero escondemos los controles actuales:
            Nombre_Cliente = "";
            contadorCantidad = 0;
            contadorOrdenes = 0;
            contadorPrecios = 0;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label9.Visible = false;
            comboBox2.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            //Mostramos los controles Anteriores:
            button1.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
            comboBox3.Visible = true;
            label10.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultas ObjConsultas = new Consultas();
            //Ordenes:
            if (contadorOrdenes == 0)
            {
                Ordenes[0] = comboBox2.SelectedValue.ToString();
                contadorOrdenes = contadorOrdenes + 1;
            }
            else
            {
                Ordenes[contadorOrdenes] = comboBox2.SelectedValue.ToString();
                contadorOrdenes = contadorOrdenes + 1;
            }
            //Cantidades:
            if (contadorCantidad == 0)
            {
                Cantidad[0] = textBox2.Text;
                contadorCantidad = contadorCantidad + 1;
            }
            else
            {
                Cantidad[contadorCantidad] = textBox2.Text;
                contadorCantidad = contadorCantidad + 1;
            }
            //Precios:
            if (contadorPrecios == 0)
            {
                Precio[0] = ObjConsultas.ActualizarPrecios(Ordenes[0]);
                contadorPrecios = contadorPrecios + 1;
            }
            else
            {
                Precio[contadorPrecios] = ObjConsultas.ActualizarPrecios(Ordenes[contadorPrecios]);
                contadorPrecios = contadorPrecios + 1;
            }
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioSoapClient ObjServicio = new ServiceReference1.ServicioSoapClient();
            InformacionDeUsuario ObjNombreUsuario = new InformacionDeUsuario();
            string Usuario;
            IntNumeroOrden++;
            Hora = DateTime.Now.ToString();
            Usuario = ObjNombreUsuario.DesplegarNombreUsuario();
            //Llamada al webservice:
            for (int i = 0; i < Ordenes.Length; i++)
            {
                if (Ordenes[i] != null)
                {
                    //Variables Auxiliares para: Producto, Cantidad Precio.
                    string Aux1, Aux2, Aux3;
                    Aux1 = Ordenes[i];
                    Aux2 = Cantidad[i];
                    Aux3 = Precio[i];
                    textBox1.Text = ObjServicio.ingresarOrdenes(Nombre_Cliente, Mesa, IntNumeroOrden.ToString(), Hora, Aux1, Aux2, Aux3, Usuario);
                }
                else
                {
                    break;
                }
            }
            //Acontinuacion desplegamos la cuenta:
            textBox1.Text = "Orden:         Cantidad:       Precio:";
            for (int i = 0; i < Ordenes.Length; i++)
            {
                if (Ordenes[i] != null)
                {
                    textBox1.Text = textBox1.Text + "\r\n" + Ordenes[i] + "         " + Cantidad[i] + "       " + Precio[i];
                }
                else
                {
                    break;
                }
            }
            //For para calcular la cuenta:
            double AuxTotal = 0.0;
            for (int i = 0; i < Precio.Length; i++)
            {
                if (Precio[i] != null)
                {
                    AuxTotal = (double.Parse(Precio[i]) * double.Parse(Cantidad[i]));
                    AuxTotal = AuxTotal + double.Parse(Precio[i]);
                }
            }
            label8.Text = AuxTotal.ToString();
            //Mostramos los siguiente y ultimos controles.
            //label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            textBox1.Visible = true;
            button5.Visible = true;
            //Escondemos los controles actuales:
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label9.Visible = false;
            comboBox2.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Mostramos Los controles Primarios:
            button1.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
            comboBox3.Visible = true;
            label10.Visible = true;
            //Escondemos los controles Actuales, para finalizar la venta:
            //label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            contadorOrdenes = 0;
            contadorCantidad = 0;
            contadorPrecios = 0;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mesa = comboBox3.SelectedValue.ToString();
        }
    }
}
