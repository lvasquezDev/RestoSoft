using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace RestoSoft
{
    public partial class FrmSesion : Form
    {
        public FrmSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow Row = new DataGridViewRow();
            InformacionDeUsuario ObjetoInfo = new InformacionDeUsuario();
            int contador=0; //Variable necesaria para poder marcar error.
            for (int i = 0; i < usuarioDataGridView.Rows.Count - 1; i++) //para recorrer todas las filas que tiene el datagridview
            {
                Row = usuarioDataGridView.Rows[i]; //para asignarle la fila al row
                if (textBox1.Text == Row.Cells[0].Value.ToString() && textBox2.Text == Row.Cells[1].Value.ToString()) //verificador de usuarios del sistema, verifica mediante la celda que contiene la contraseña y el usuario si existe
                {
                    string Puesto;//Creamos Una Variable Temporal para poder guaradar el puesto encontrado
                    Puesto = Row.Cells[2].Value.ToString();
                    if (Puesto == "Mesero")
                    {
                        FrmMesero Obj = new FrmMesero();
                        //Almacenamos los datos del usuario que accedera al sistema en una clase externa para su posterior uso
                        ObjetoInfo.AlmacenarDatos(Row.Cells[0].Value.ToString(), Row.Cells[1].Value.ToString(), Puesto,Row.Cells[3].Value.ToString(),Row.Cells[4].Value.ToString(),Row.Cells[5].Value.ToString());
                        Obj.Show();
                        this.Hide();
                        break;
                    }
                    else if (Puesto == "Cajero")
                    {
                        FrmCajero Obj = new FrmCajero();
                        //Almacenamos los datos del usuario que accedera al sistema en una clase externa para su posterior uso
                        ObjetoInfo.AlmacenarDatos(Row.Cells[0].Value.ToString(), Row.Cells[1].Value.ToString(), Puesto, Row.Cells[3].Value.ToString(), Row.Cells[4].Value.ToString(), Row.Cells[5].Value.ToString());
                        Obj.Show();
                        this.Hide();
                        break;
                    }

                    else if (Puesto == "Supusuario")
                    {
                        FrmSuperUsuario Obj = new FrmSuperUsuario();
                        ObjetoInfo.AlmacenarDatos(Row.Cells[0].Value.ToString(), Row.Cells[1].Value.ToString(), Puesto, Row.Cells[3].Value.ToString(), Row.Cells[4].Value.ToString(), Row.Cells[5].Value.ToString());
                        Obj.Show();
                        this.Hide();
                        break;
                    }
                    
                }
                else if ((textBox1.Text == Row.Cells[0].Value.ToString() && textBox2.Text != Row.Cells[1].Value.ToString()) || (textBox1.Text != Row.Cells[0].Value.ToString() && textBox2.Text == Row.Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Password o Nombre de usuario no validos", "Error (Numero Pendiente)");
                    break;
                }
                else
                {
                }
                if (contador == usuarioDataGridView.Rows.Count)
                {
                    MessageBox.Show("Usuario No Existente", "Error (Numero Pendiente)");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                else 
                { 
                    contador++; 
                }
            }
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetUsuarios);

        }

        private void FrmSesion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsuarios.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSetUsuarios.usuario);
            // TODO: This line of code loads data into the 'restosoftDataSet1.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSetUsuarios.usuario);
            // TODO: This line of code loads data into the 'restosoftDataSet1.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSetUsuarios.usuario);
            //Mediante las siguientes lineas de codigo quitamos los botones predeterminados dela forma (Minimizar, Maximizar, Cerrar)
            //y no permitimos que el usuario pueda modificar el tama;o de la forma, con el fin de tener nuestra
            //pantalla principal de manera estatica para que los componentes contenidos en la forma mantenga su tama;o.
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 677;//Horizontal
            this.Height = 469;//Vertical
        }

        private void usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetUsuarios);

        }

        private void usuarioBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetUsuarios);

        }
    }
}
