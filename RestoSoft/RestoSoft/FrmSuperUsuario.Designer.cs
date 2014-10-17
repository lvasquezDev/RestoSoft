namespace RestoSoft
{
    partial class FrmSuperUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuperUsuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUnNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaUnUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInformacionDeUnUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modiciarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPlatilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPlatilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPlatillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPlatillosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoDeInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarUnaReplicaDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.platillosToolStripMenuItem,
            this.respaldoDeInformacionToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCuentaToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // consultarCuentaToolStripMenuItem
            // 
            this.consultarCuentaToolStripMenuItem.Name = "consultarCuentaToolStripMenuItem";
            this.consultarCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.consultarCuentaToolStripMenuItem.Text = "Consultar Cuenta";
            this.consultarCuentaToolStripMenuItem.Click += new System.EventHandler(this.consultarCuentaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUnNuevoUsuarioToolStripMenuItem,
            this.darDeBajaUnUsuarioToolStripMenuItem,
            this.modificarInformacionDeUnUsuarioToolStripMenuItem,
            this.consultarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUnNuevoUsuarioToolStripMenuItem
            // 
            this.crearUnNuevoUsuarioToolStripMenuItem.Name = "crearUnNuevoUsuarioToolStripMenuItem";
            this.crearUnNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.crearUnNuevoUsuarioToolStripMenuItem.Text = "Crear Un Nuevo Usuario";
            this.crearUnNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUnNuevoUsuarioToolStripMenuItem_Click);
            // 
            // darDeBajaUnUsuarioToolStripMenuItem
            // 
            this.darDeBajaUnUsuarioToolStripMenuItem.Name = "darDeBajaUnUsuarioToolStripMenuItem";
            this.darDeBajaUnUsuarioToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.darDeBajaUnUsuarioToolStripMenuItem.Text = "Dar De Baja Un Usuario";
            this.darDeBajaUnUsuarioToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaUnUsuarioToolStripMenuItem_Click);
            // 
            // modificarInformacionDeUnUsuarioToolStripMenuItem
            // 
            this.modificarInformacionDeUnUsuarioToolStripMenuItem.Name = "modificarInformacionDeUnUsuarioToolStripMenuItem";
            this.modificarInformacionDeUnUsuarioToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.modificarInformacionDeUnUsuarioToolStripMenuItem.Text = "Modificar Informacion De Un Usuario";
            this.modificarInformacionDeUnUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarInformacionDeUnUsuarioToolStripMenuItem_Click);
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            this.consultarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.bajaClienteToolStripMenuItem,
            this.consultarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // bajaClienteToolStripMenuItem
            // 
            this.bajaClienteToolStripMenuItem.Name = "bajaClienteToolStripMenuItem";
            this.bajaClienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bajaClienteToolStripMenuItem.Text = "Baja Cliente";
            this.bajaClienteToolStripMenuItem.Click += new System.EventHandler(this.bajaClienteToolStripMenuItem_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem,
            this.modiciarArticuloToolStripMenuItem,
            this.consultarInventarioToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.comprasToolStripMenuItem.Text = "Inventario";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Articulo";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // modiciarArticuloToolStripMenuItem
            // 
            this.modiciarArticuloToolStripMenuItem.Name = "modiciarArticuloToolStripMenuItem";
            this.modiciarArticuloToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modiciarArticuloToolStripMenuItem.Text = "Modicar Articulo";
            this.modiciarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modiciarArticuloToolStripMenuItem_Click);
            // 
            // consultarInventarioToolStripMenuItem
            // 
            this.consultarInventarioToolStripMenuItem.Name = "consultarInventarioToolStripMenuItem";
            this.consultarInventarioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarInventarioToolStripMenuItem.Text = "Consultar Inventario";
            this.consultarInventarioToolStripMenuItem.Click += new System.EventHandler(this.consultarInventarioToolStripMenuItem_Click);
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            this.eliminarArticuloToolStripMenuItem.Click += new System.EventHandler(this.eliminarArticuloToolStripMenuItem_Click);
            // 
            // platillosToolStripMenuItem
            // 
            this.platillosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPlatilloToolStripMenuItem,
            this.modificarPlatilloToolStripMenuItem,
            this.consultarPlatillosToolStripMenuItem,
            this.eliminarPlatillosToolStripMenuItem});
            this.platillosToolStripMenuItem.Name = "platillosToolStripMenuItem";
            this.platillosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.platillosToolStripMenuItem.Text = "Platillos";
            // 
            // nuevoPlatilloToolStripMenuItem
            // 
            this.nuevoPlatilloToolStripMenuItem.Name = "nuevoPlatilloToolStripMenuItem";
            this.nuevoPlatilloToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nuevoPlatilloToolStripMenuItem.Text = "Nuevo Platillo";
            this.nuevoPlatilloToolStripMenuItem.Click += new System.EventHandler(this.nuevoPlatilloToolStripMenuItem_Click);
            // 
            // modificarPlatilloToolStripMenuItem
            // 
            this.modificarPlatilloToolStripMenuItem.Name = "modificarPlatilloToolStripMenuItem";
            this.modificarPlatilloToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modificarPlatilloToolStripMenuItem.Text = "Modificar Platillo";
            this.modificarPlatilloToolStripMenuItem.Click += new System.EventHandler(this.modificarPlatilloToolStripMenuItem_Click);
            // 
            // consultarPlatillosToolStripMenuItem
            // 
            this.consultarPlatillosToolStripMenuItem.Name = "consultarPlatillosToolStripMenuItem";
            this.consultarPlatillosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consultarPlatillosToolStripMenuItem.Text = "Consultar Platillos";
            this.consultarPlatillosToolStripMenuItem.Click += new System.EventHandler(this.consultarPlatillosToolStripMenuItem_Click);
            // 
            // eliminarPlatillosToolStripMenuItem
            // 
            this.eliminarPlatillosToolStripMenuItem.Name = "eliminarPlatillosToolStripMenuItem";
            this.eliminarPlatillosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarPlatillosToolStripMenuItem.Text = "Eliminar Platillos";
            this.eliminarPlatillosToolStripMenuItem.Click += new System.EventHandler(this.eliminarPlatillosToolStripMenuItem_Click);
            // 
            // respaldoDeInformacionToolStripMenuItem
            // 
            this.respaldoDeInformacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarUnaReplicaDeBaseDeDatosToolStripMenuItem});
            this.respaldoDeInformacionToolStripMenuItem.Name = "respaldoDeInformacionToolStripMenuItem";
            this.respaldoDeInformacionToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.respaldoDeInformacionToolStripMenuItem.Text = "Respaldo De Informacion";
            // 
            // generarUnaReplicaDeBaseDeDatosToolStripMenuItem
            // 
            this.generarUnaReplicaDeBaseDeDatosToolStripMenuItem.Name = "generarUnaReplicaDeBaseDeDatosToolStripMenuItem";
            this.generarUnaReplicaDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.generarUnaReplicaDeBaseDeDatosToolStripMenuItem.Text = "Generar Una Replica De Base De Datos";
            this.generarUnaReplicaDeBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.generarUnaReplicaDeBaseDeDatosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReportesToolStripMenuItem
            // 
            this.generarReportesToolStripMenuItem.Name = "generarReportesToolStripMenuItem";
            this.generarReportesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.generarReportesToolStripMenuItem.Text = "Generar Reportes";
            this.generarReportesToolStripMenuItem.Click += new System.EventHandler(this.generarReportesToolStripMenuItem_Click);
            // 
            // FrmSuperUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 576);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSuperUsuario";
            this.Text = "FrmSuperUsuario";
            this.Load += new System.EventHandler(this.FrmSuperUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUnNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaUnUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInformacionDeUnUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldoDeInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarUnaReplicaDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modiciarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platillosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPlatilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPlatilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPlatillosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPlatillosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReportesToolStripMenuItem;
    }
}