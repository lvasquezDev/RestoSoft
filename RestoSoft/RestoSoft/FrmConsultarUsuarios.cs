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
    public partial class FrmConsultarUsuarios : Form
    {
        public FrmConsultarUsuarios()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSetModificarUsuarios);

        }

        private void FrmConsultarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetModificarUsuarios.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.restosoftDataSetModificarUsuarios.usuario);

        }
    }
}
