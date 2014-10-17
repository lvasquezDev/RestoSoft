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
    public partial class FrmCajero : Form
    {
        public static string Nombre_Cliente;
        public static string Mesa;
        public static int IntNumeroOrden=0;
        public static string Hora;
        public static string[] Cantidad=new string[20];
        public static string[] Ordenes=new string[20];
        public static string[] Precio = new string[20];
        public static int contadorOrdenes=0,contadorCantidad=0,contadorPrecios;
        public FrmCajero()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmCajero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMesas.mesa' table. You can move, or remove it, as needed.
            this.mesaTableAdapter.Fill(this.dataSetMesas.mesa);
            // TODO: This line of code loads data into the 'dataSetProductos.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dataSetProductos.producto);
            // TODO: This line of code loads data into the 'dataSetClientes.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSetClientes.clientes);
            // TODO: This line of code loads data into the 'dataSetOrdenes.ordenes' table. You can move, or remove it, as needed.
            this.ordenesTableAdapter.Fill(this.dataSetOrdenes.ordenes);
            //Mediante las siguientes lineas de codigo quitamos los botones predeterminados dela forma (Minimizar, Maximizar, Cerrar)
            //y no permitimos que el usuario pueda modificar el tama;o de la forma, con el fin de tener nuestra
            //pantalla principal de manera estatica para que los componentes contenidos en la forma mantenga su tama;o.
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 972;//Horizontal
            this.Height = 588;//Vertical
            timer1.Enabled = true;
        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaInventario Obj = new FrmConsultaInventario();
            Obj.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSesion obj = new FrmSesion();
            InformacionDeUsuario ObjInfo = new InformacionDeUsuario();
            ObjInfo.CerrarSesion();
            obj.Show();
            this.Hide();
        }

        private void registrarUnNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente Obj = new FrmNuevoCliente();
            Obj.Show();
        }

        private void consultarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosUsuario Obj = new FrmDatosUsuario();
            Obj.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node.Text == "Consultar Inventario")
            {
                FrmConsultaInventario obj = new FrmConsultaInventario();
                obj.Show();
            }
            if (node.Text == "Eliminar Cliente")
            {
                FrmBajaCliente obj = new FrmBajaCliente();
                obj.Show();
            }
            if (node.Text == "Registrar Nuevo Cliente")
            {
                FrmNuevoCliente obj = new FrmNuevoCliente();
                obj.Show();
            }
            if (node.Text == "Consultar Clientes")
            {
                FrmConsultarClientes Obj = new FrmConsultarClientes();
                Obj.Show();
            }
            if (node.Text == "Realizar Reservacion")
            {
                NuevaReservacion Obj = new NuevaReservacion();
                Obj.Show();
            }
            if (node.Text == "Nuevo Servicio")
            {
                FrmServicioDomicilio Obj = new FrmServicioDomicilio();
                Obj.Show();
            }
            if (node.Text == "Cancelar Servicio")
            {
                FrmEliminarServicioDomicilio Obj = new FrmEliminarServicioDomicilio();
                Obj.Show();
            }
            if (node.Text == "Consultar Pedidos")
            {
                FrmConsultaDomicilio Obj = new FrmConsultaDomicilio();
                Obj.Show();
            }
            if (node.Text == "Eliminar Reservacion")
            {
                FrmEliminarReservacion Obj = new FrmEliminarReservacion();
                Obj.Show();
            }
            if (node.Text == "Consultar Reservaciones")
            {
                FrmConsultarReservaciones Obj = new FrmConsultarReservaciones();
                Obj.Show();
            }
        }

        private void ordenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetOrdenes);

        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaCliente obj = new FrmBajaCliente();
            obj.Show();
        }

        private void modificarInformacionDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarClientes Obj = new FrmConsultarClientes();
            Obj.Show();
        }

        private void realizarReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaReservacion Obj = new NuevaReservacion();
            Obj.Show();
        }

        private void eliminarReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarReservacion Obj = new FrmEliminarReservacion();
            Obj.Show();
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
                    textBox1.Text= ObjServicio.ingresarOrdenes(Nombre_Cliente, Mesa, IntNumeroOrden.ToString(), Hora, Aux1, Aux2, Aux3, Usuario);
                }
                else
                {
                    break;
                }
            }
            //Acontinuacion desplegamos la cuenta:
            textBox1.Text="Orden:         Cantidad:       Precio:";
            for (int i = 0; i < Ordenes.Length; i++)
            {
                 if (Ordenes[i] != null)
                 {
                     textBox1.Text = textBox1.Text + "\r\n" + Ordenes[i] + "         " + Cantidad[i] + "       "+Precio[i];
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
            label6.Visible = true;
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
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            contadorOrdenes=0;
            contadorCantidad = 0;
            contadorPrecios = 0;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mesa = comboBox3.SelectedValue.ToString();
        }

        private void nuevoServicioADomicilioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicioDomicilio Obj = new FrmServicioDomicilio();
            Obj.Show();
        }

        private void cancelarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarServicioDomicilio Obj = new FrmEliminarServicioDomicilio();
            Obj.Show();
        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaDomicilio Obj = new FrmConsultaDomicilio();
            Obj.Show();
        }

        private void consultarReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarReservaciones Obj = new FrmConsultarReservaciones();
            Obj.Show();
        }



        
    }
}