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
    public partial class FrmMesero : Form
    {

        public FrmMesero()
        {
            InitializeComponent();
        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaInventario ObjCI = new FrmConsultaInventario();
            ObjCI.Show();
        }

        private void FrmMesero_Load(object sender, EventArgs e)
        {
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node.Text == "Consultar Inventario") 
            {
                FrmConsultaInventario ObjCI = new FrmConsultaInventario();
                ObjCI.Show();
            }
            if (node.Text == "Realizar Servicio")
            {
                FrmNuevoServicio Obj = new FrmNuevoServicio();
                Obj.Show();
            }
            if (node.Text == "Ver Pedidos")
            {
                FrmConsultarOrdenes Obj = new FrmConsultarOrdenes();
                Obj.Show();
            }
            if (node.Text == "Realizar Pedido")
            {
                FrmNuevaOrden Obj = new FrmNuevaOrden();
                Obj.Show();
            }
            if (node.Text == "Eliminar Pedido")
            {
                FrmEliminarOrden Obj = new FrmEliminarOrden();
                Obj.Show();
            }
            if (node.Text == "Eliminar Servicio")
            {
                FrmEliminarServicio Obj = new FrmEliminarServicio();
                Obj.Show();
            }
            if (node.Text == "Ver Servicio")
            {
                FrmVerServicios Obj = new FrmVerServicios();
                Obj.Show();
            }
        }

        private void consultarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosUsuario obj = new FrmDatosUsuario();
            obj.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSesion obj = new FrmSesion();
            InformacionDeUsuario ObjInfo = new InformacionDeUsuario();
            ObjInfo.CerrarSesion();
            obj.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaOrden obj = new FrmNuevaOrden();
            obj.Show();
        }

        private void verTemasDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void realizarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoServicio Obj = new FrmNuevoServicio();
            Obj.Show();
        }

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarOrdenes Obj = new FrmConsultarOrdenes();
            Obj.Show();
        }

        private void modificarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarOrden Obj = new FrmEliminarOrden();
            Obj.Show();
        }

        private void eliminarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarServicio Obj = new FrmEliminarServicio();
            Obj.Show();
        }

        private void verServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerServicios Obj = new FrmVerServicios();
            Obj.Show();
        }
    }
}
