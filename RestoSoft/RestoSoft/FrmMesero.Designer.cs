namespace RestoSoft
{
    partial class FrmMesero
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Realizar Pedido");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Ver Pedidos");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Eliminar Pedido");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Ordenes", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Realizar Servicio");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Ver Servicio");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Eliminar Servicio");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Servicio", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Consultar Inventario");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Inventario", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.eliminarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.servicioToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
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
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPedidoToolStripMenuItem,
            this.verPedidosToolStripMenuItem,
            this.modificarPedidosToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // realizarPedidoToolStripMenuItem
            // 
            this.realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            this.realizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            this.realizarPedidoToolStripMenuItem.Click += new System.EventHandler(this.realizarPedidoToolStripMenuItem_Click);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // modificarPedidosToolStripMenuItem
            // 
            this.modificarPedidosToolStripMenuItem.Name = "modificarPedidosToolStripMenuItem";
            this.modificarPedidosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.modificarPedidosToolStripMenuItem.Text = "Eliminar Pedidos";
            this.modificarPedidosToolStripMenuItem.Click += new System.EventHandler(this.modificarPedidosToolStripMenuItem_Click);
            // 
            // servicioToolStripMenuItem
            // 
            this.servicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarServicioToolStripMenuItem,
            this.verServicioToolStripMenuItem,
            this.eliminarServicioToolStripMenuItem});
            this.servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            this.servicioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.servicioToolStripMenuItem.Text = "Servicio";
            // 
            // realizarServicioToolStripMenuItem
            // 
            this.realizarServicioToolStripMenuItem.Name = "realizarServicioToolStripMenuItem";
            this.realizarServicioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.realizarServicioToolStripMenuItem.Text = "Realizar Servicio ";
            this.realizarServicioToolStripMenuItem.Click += new System.EventHandler(this.realizarServicioToolStripMenuItem_Click);
            // 
            // verServicioToolStripMenuItem
            // 
            this.verServicioToolStripMenuItem.Name = "verServicioToolStripMenuItem";
            this.verServicioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.verServicioToolStripMenuItem.Text = "Ver Servicio";
            this.verServicioToolStripMenuItem.Click += new System.EventHandler(this.verServicioToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // consultarInventarioToolStripMenuItem
            // 
            this.consultarInventarioToolStripMenuItem.Name = "consultarInventarioToolStripMenuItem";
            this.consultarInventarioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarInventarioToolStripMenuItem.Text = "Consultar Inventario";
            this.consultarInventarioToolStripMenuItem.Click += new System.EventHandler(this.consultarInventarioToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            treeNode21.Name = "NodoRP";
            treeNode21.Text = "Realizar Pedido";
            treeNode22.Name = "NodoVP";
            treeNode22.Text = "Ver Pedidos";
            treeNode23.Name = "NodoMP";
            treeNode23.Text = "Eliminar Pedido";
            treeNode24.Name = "NodoOrdenes";
            treeNode24.Text = "Ordenes";
            treeNode25.Name = "NodoRS";
            treeNode25.Text = "Realizar Servicio";
            treeNode26.Name = "NodoVS";
            treeNode26.Text = "Ver Servicio";
            treeNode27.Name = "NodoMS";
            treeNode27.Text = "Eliminar Servicio";
            treeNode28.Name = "NodoServicio";
            treeNode28.Text = "Servicio";
            treeNode29.Name = "NodoCI";
            treeNode29.Text = "Consultar Inventario";
            treeNode30.Name = "NodoInventario";
            treeNode30.Text = "Inventario";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode28,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(155, 523);
            this.treeView1.TabIndex = 100;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(161, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(793, 537);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://aspspider.info/yukinooh/", System.UriKind.Absolute);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(900, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 101;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // eliminarServicioToolStripMenuItem
            // 
            this.eliminarServicioToolStripMenuItem.Name = "eliminarServicioToolStripMenuItem";
            this.eliminarServicioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.eliminarServicioToolStripMenuItem.Text = "Eliminar Servicio";
            this.eliminarServicioToolStripMenuItem.Click += new System.EventHandler(this.eliminarServicioToolStripMenuItem_Click);
            // 
            // FrmMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMesero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Hacienda Del Sabor";
            this.Load += new System.EventHandler(this.FrmMesero_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarInventarioToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem eliminarServicioToolStripMenuItem;
    }
}

