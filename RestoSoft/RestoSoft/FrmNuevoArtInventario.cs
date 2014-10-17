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
    public partial class FrmNuevoArtInventario : Form
    {
        public FrmNuevoArtInventario()
        {
            InitializeComponent();
        }

        private void inventariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSetModificarInventario);

        }

        private void FrmNuevoArtInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetModificarInventario.inventarios' table. You can move, or remove it, as needed.
            this.inventariosTableAdapter.Fill(this.restosoftDataSetModificarInventario.inventarios);

        }
    }
}
