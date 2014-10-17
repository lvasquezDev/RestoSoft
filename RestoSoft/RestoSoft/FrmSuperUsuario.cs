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
    public partial class FrmSuperUsuario : Form
    {
        public FrmSuperUsuario()
        {
            InitializeComponent();
        }

        private void consultarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosUsuario Obj = new FrmDatosUsuario();
            Obj.Show();
        }

        private void crearUnNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario Obj = new FrmNuevoUsuario();
            Obj.Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente Obj = new FrmNuevoCliente();
            Obj.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarCliente Obj = new FrmModificarCliente();
            Obj.Show();
        }

        private void bajaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaCliente Obj = new FrmBajaCliente();
            Obj.Show();
        }

        private void darDeBajaUnUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaUsuarios Obj = new FrmBajaUsuarios();
            Obj.Show();
        }

        private void modificarInformacionDeUnUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarUsuarios Obj = new FrmModificarUsuarios();
            Obj.Show();
        }

        private void generarUnaReplicaDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string ConectionString = @"Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Replicacion ObjReplicas = new Replicacion();
            //label1.Text = ObjReplicas.GenerarBaseDeDatos();
            string NombreNuevaBD = "ReplicaRestosoft";
            string[] Tabla = ObjReplicas.BuscarTablas(ConectionString);
            foreach (string NombTabla in Tabla)
            {
                string[] Atributos = ObjReplicas.BuscarAtributos(NombTabla, @"Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True");
                string[] Tipos = new string[Atributos.Length];
                for (int i = 0; i < Tipos.Length; i++)
                {
                    Tipos[i] = "nchar(50)";
                }

                //una vez recolectados los datos, generamos las tablas.
                ObjReplicas.GeneracionTablas(NombTabla, Atributos, Tipos, @"Data Source=PAULINA-PC;Initial Catalog="+NombreNuevaBD+";Integrated Security=True");
            }
            MessageBox.Show("El archivo a sido duplicado Exitosamente en: " + @"C:\Users\Paulina\Desktop\Replicaciones", "Replicacion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarUsuarios Obj = new FrmConsultarUsuarios();
            Obj.Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarClientes Obj = new FrmConsultarClientes();
            Obj.Show();
        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaInventario Obj = new FrmConsultaInventario();
            Obj.Show();
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoArtInventario Obj = new FrmNuevoArtInventario();
            Obj.Show();
        }

        private void modiciarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarInvArticulo Obj = new FrmModificarInvArticulo();
            Obj.Show();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarInvArticulo Obj = new FrmEliminarInvArticulo();
            Obj.Show();
        }

        private void nuevoPlatilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPlatillo Obj = new FrmNuevoPlatillo();
            Obj.Show();
        }

        private void modificarPlatilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarPlatillo Obj = new FrmModificarPlatillo();
            Obj.Show();
        }

        private void consultarPlatillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPlatillos Obj = new FrmConsultarPlatillos();
            Obj.Show();
        }

        private void eliminarPlatillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarPlatillos Obj = new FrmEliminarPlatillos();
            Obj.Show();
        }

        private void FrmSuperUsuario_Load(object sender, EventArgs e)
        {
            //Mediante las siguientes lineas de codigo quitamos los botones predeterminados dela forma (Minimizar, Maximizar, Cerrar)
            //y no permitimos que el usuario pueda modificar el tama;o de la forma, con el fin de tener nuestra
            //pantalla principal de manera estatica para que los componentes contenidos en la forma mantenga su tama;o.
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 613;//Horizontal
            this.Height = 614;//Vertical
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes Obj = new FrmReportes();
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
    }
}
