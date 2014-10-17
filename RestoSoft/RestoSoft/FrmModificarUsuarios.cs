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
    public partial class FrmModificarUsuarios : Form
    {
        public FrmModificarUsuarios()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restosoftDataSetModificarUsuarios);
            nombreUsuarioTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            puestoTextBox.Enabled = false;
            nombreTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
        }

        private void FrmModificarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restosoftDataSetModificarUsuarios.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.restosoftDataSetModificarUsuarios.usuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreUsuarioTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            puestoTextBox.Enabled = true;
            nombreTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
        }
    }
}
