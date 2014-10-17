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
    public partial class FrmConsultaInventario : Form
    {
        public FrmConsultaInventario()
        {
            InitializeComponent();
        }

        private void inventariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSet);

        }

        private void FrmConsultaInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSet.inventarios' table. You can move, or remove it, as needed.
            this.inventariosTableAdapter.Fill(this.restosoftDataSet.inventarios);
            this.Width = 475;//Horizontal
            this.Height = 408;//Vertical

        }
        //Boton para realizar la busqueda especifica de algun articulo.
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow Row = new DataGridViewRow();
            int contador=0;
            for (int i = 0; i < inventariosDataGridView.Rows.Count - 1; i++)
            {
                Row = inventariosDataGridView.Rows[i];
                if (TxtBusqueda.Text == Row.Cells[1].Value.ToString())
                {
                    //Variables necesarias para poder desplegar los datos del producto a buscar:
                    string NombreArticulo, Proveedor, IdArticulo, Cantidad;
                    IdArticulo = Row.Cells[0].Value.ToString();
                    NombreArticulo = Row.Cells[1].Value.ToString();
                    Cantidad = Row.Cells[2].Value.ToString();
                    Proveedor = Row.Cells[3].Value.ToString();
                    label7.Text = IdArticulo;
                    label8.Text = NombreArticulo;
                    label9.Text = Cantidad;
                    label10.Text = Proveedor;
                    //Ponemos visibles las labels que necesitaremos:
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    TxtBusqueda.Text = "";
                    break;
                }
                if (contador == inventariosDataGridView.Rows.Count)
                {
                    MessageBox.Show("Articulo No Encontrado", "Error (Numero Pendiente)");
                    TxtBusqueda.Text = "";
                    TxtBusqueda.Focus();
                }
                else
                {
                    contador++;
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            TxtBusqueda.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            TxtBusqueda.Text = "";
        }


    }
}
