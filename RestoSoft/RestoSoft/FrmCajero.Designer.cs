namespace RestoSoft
{
    partial class FrmCajero
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Registrar Nuevo Cliente");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Eliminar Cliente");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Consultar Clientes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Clientes", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Realizar Reservacion");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Eliminar Reservacion");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Consultar Reservaciones");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Reservaciones", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nuevo Servicio");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Cancelar Servicio");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Consultar Pedidos");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Servicio A Domicilio", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Consultar Inventario");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Inventario", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCajero));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUnNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInformacionDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoServicioADomicilioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetOrdenes = new RestoSoft.DataSetOrdenes();
            this.ordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesTableAdapter = new RestoSoft.DataSetOrdenesTableAdapters.ordenesTableAdapter();
            this.tableAdapterManager = new RestoSoft.DataSetOrdenesTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Mesa1 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.mesaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMesas = new RestoSoft.DataSetMesas();
            this.mesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new RestoSoft.DataSetProductos();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClientes = new RestoSoft.DataSetClientes();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ordenesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new RestoSoft.DataSetClientesTableAdapters.clientesTableAdapter();
            this.dataSetProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new RestoSoft.DataSetProductosTableAdapters.productoTableAdapter();
            this.mesaTableAdapter = new RestoSoft.DataSetMesasTableAdapters.mesaTableAdapter();
            this.ordenesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.consultarReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Mesa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.reservacionesToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
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
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarReservacionToolStripMenuItem,
            this.eliminarReservacionToolStripMenuItem,
            this.consultarReservacionesToolStripMenuItem});
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // realizarReservacionToolStripMenuItem
            // 
            this.realizarReservacionToolStripMenuItem.Name = "realizarReservacionToolStripMenuItem";
            this.realizarReservacionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.realizarReservacionToolStripMenuItem.Text = "Realizar Reservacion";
            this.realizarReservacionToolStripMenuItem.Click += new System.EventHandler(this.realizarReservacionToolStripMenuItem_Click);
            // 
            // eliminarReservacionToolStripMenuItem
            // 
            this.eliminarReservacionToolStripMenuItem.Name = "eliminarReservacionToolStripMenuItem";
            this.eliminarReservacionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.eliminarReservacionToolStripMenuItem.Text = "Eliminar Reservacion";
            this.eliminarReservacionToolStripMenuItem.Click += new System.EventHandler(this.eliminarReservacionToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUnNuevoClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.modificarInformacionDeClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // registrarUnNuevoClienteToolStripMenuItem
            // 
            this.registrarUnNuevoClienteToolStripMenuItem.Name = "registrarUnNuevoClienteToolStripMenuItem";
            this.registrarUnNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.registrarUnNuevoClienteToolStripMenuItem.Text = "Registrar Un Nuevo Cliente";
            this.registrarUnNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarUnNuevoClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // modificarInformacionDeClienteToolStripMenuItem
            // 
            this.modificarInformacionDeClienteToolStripMenuItem.Name = "modificarInformacionDeClienteToolStripMenuItem";
            this.modificarInformacionDeClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.modificarInformacionDeClienteToolStripMenuItem.Text = "Consultar Clientes";
            this.modificarInformacionDeClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarInformacionDeClienteToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoServicioADomicilioToolStripMenuItem,
            this.cancelarServicioToolStripMenuItem,
            this.consultarPedidosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.ayudaToolStripMenuItem.Text = "Servicio A Domicilio";
            // 
            // nuevoServicioADomicilioToolStripMenuItem
            // 
            this.nuevoServicioADomicilioToolStripMenuItem.Name = "nuevoServicioADomicilioToolStripMenuItem";
            this.nuevoServicioADomicilioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.nuevoServicioADomicilioToolStripMenuItem.Text = "Nuevo Servicio A Domicilio";
            this.nuevoServicioADomicilioToolStripMenuItem.Click += new System.EventHandler(this.nuevoServicioADomicilioToolStripMenuItem_Click);
            // 
            // cancelarServicioToolStripMenuItem
            // 
            this.cancelarServicioToolStripMenuItem.Name = "cancelarServicioToolStripMenuItem";
            this.cancelarServicioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cancelarServicioToolStripMenuItem.Text = "Cancelar Servicio";
            this.cancelarServicioToolStripMenuItem.Click += new System.EventHandler(this.cancelarServicioToolStripMenuItem_Click);
            // 
            // consultarPedidosToolStripMenuItem
            // 
            this.consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            this.consultarPedidosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.consultarPedidosToolStripMenuItem.Text = "Consultar Pedidos";
            this.consultarPedidosToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarInventarioToolStripMenuItem});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.ayudaToolStripMenuItem1.Text = "Inventario";
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
            treeNode1.Name = "Node1";
            treeNode1.Text = "Registrar Nuevo Cliente";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Eliminar Cliente";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Consultar Clientes";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Clientes";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Realizar Reservacion";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Eliminar Reservacion";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Consultar Reservaciones";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Reservaciones";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Nuevo Servicio";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Cancelar Servicio";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Consultar Pedidos";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Servicio A Domicilio";
            treeNode13.Name = "Node4";
            treeNode13.Text = "Consultar Inventario";
            treeNode14.Name = "Node3";
            treeNode14.Text = "Inventario";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(177, 527);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // dataSetOrdenes
            // 
            this.dataSetOrdenes.DataSetName = "DataSetOrdenes";
            this.dataSetOrdenes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenesBindingSource
            // 
            this.ordenesBindingSource.DataMember = "ordenes";
            this.ordenesBindingSource.DataSource = this.dataSetOrdenes;
            // 
            // ordenesTableAdapter
            // 
            this.ordenesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ordenesTableAdapter = this.ordenesTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.DataSetOrdenesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mesa1);
            this.tabControl1.Location = new System.Drawing.Point(183, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 527);
            this.tabControl1.TabIndex = 3;
            // 
            // Mesa1
            // 
            this.Mesa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mesa1.BackgroundImage")));
            this.Mesa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mesa1.Controls.Add(this.comboBox3);
            this.Mesa1.Controls.Add(this.label10);
            this.Mesa1.Controls.Add(this.textBox2);
            this.Mesa1.Controls.Add(this.label9);
            this.Mesa1.Controls.Add(this.button5);
            this.Mesa1.Controls.Add(this.label8);
            this.Mesa1.Controls.Add(this.label7);
            this.Mesa1.Controls.Add(this.textBox1);
            this.Mesa1.Controls.Add(this.label6);
            this.Mesa1.Controls.Add(this.button4);
            this.Mesa1.Controls.Add(this.button3);
            this.Mesa1.Controls.Add(this.button2);
            this.Mesa1.Controls.Add(this.comboBox2);
            this.Mesa1.Controls.Add(this.label5);
            this.Mesa1.Controls.Add(this.label4);
            this.Mesa1.Controls.Add(this.label3);
            this.Mesa1.Controls.Add(this.button1);
            this.Mesa1.Controls.Add(this.comboBox1);
            this.Mesa1.Controls.Add(this.label2);
            this.Mesa1.Location = new System.Drawing.Point(4, 22);
            this.Mesa1.Name = "Mesa1";
            this.Mesa1.Padding = new System.Windows.Forms.Padding(3);
            this.Mesa1.Size = new System.Drawing.Size(773, 501);
            this.Mesa1.TabIndex = 0;
            this.Mesa1.Text = "Ordenes";
            this.Mesa1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mesaBindingSource1, "numeroMesa", true));
            this.comboBox3.DataSource = this.mesaBindingSource;
            this.comboBox3.DisplayMember = "numeroMesa";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(71, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "numeroMesa";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // mesaBindingSource1
            // 
            this.mesaBindingSource1.DataMember = "mesa";
            this.mesaBindingSource1.DataSource = this.dataSetMesas;
            // 
            // dataSetMesas
            // 
            this.dataSetMesas.DataSetName = "DataSetMesas";
            this.dataSetMesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesaBindingSource
            // 
            this.mesaBindingSource.DataMember = "mesa";
            this.mesaBindingSource.DataSource = this.dataSetMesas;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mesa:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(524, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cantidad:";
            this.label9.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(289, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Fin De La Orden";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(307, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 17;
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(260, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total:";
            this.label7.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(263, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 90);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Orden:";
            this.label6.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Total";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Agregar A Cuenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource1, "nombreproducto", true));
            this.comboBox2.DataSource = this.productoBindingSource;
            this.comboBox2.DisplayMember = "nombreproducto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(524, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "nombreproducto";
            this.comboBox2.Visible = false;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "producto";
            this.productoBindingSource1.DataSource = this.dataSetProductos;
            // 
            // dataSetProductos
            // 
            this.dataSetProductos.DataSetName = "DataSetProductos";
            this.dataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.dataSetProductos;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Platillo:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Del Cliente:";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientesBindingSource1, "nombreCliente", true));
            this.comboBox1.DataSource = this.clientesBindingSource;
            this.comboBox1.DisplayMember = "nombreCliente";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "nombreCliente";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.dataSetClientes;
            // 
            // dataSetClientes
            // 
            this.dataSetClientes.DataSetName = "DataSetClientes";
            this.dataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataSetClientes;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // ordenesBindingSource2
            // 
            this.ordenesBindingSource2.DataMember = "ordenes";
            this.ordenesBindingSource2.DataSource = this.dataSetOrdenes;
            // 
            // ordenesBindingSource1
            // 
            this.ordenesBindingSource1.DataMember = "ordenes";
            this.ordenesBindingSource1.DataSource = this.dataSetOrdenes;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetProductosBindingSource
            // 
            this.dataSetProductosBindingSource.DataSource = this.dataSetProductos;
            this.dataSetProductosBindingSource.Position = 0;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // mesaTableAdapter
            // 
            this.mesaTableAdapter.ClearBeforeFill = true;
            // 
            // ordenesBindingSource3
            // 
            this.ordenesBindingSource3.DataMember = "ordenes";
            this.ordenesBindingSource3.DataSource = this.dataSetOrdenes;
            // 
            // ordenesBindingSource4
            // 
            this.ordenesBindingSource4.DataMember = "ordenes";
            this.ordenesBindingSource4.DataSource = this.dataSetOrdenes;
            // 
            // consultarReservacionesToolStripMenuItem
            // 
            this.consultarReservacionesToolStripMenuItem.Name = "consultarReservacionesToolStripMenuItem";
            this.consultarReservacionesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultarReservacionesToolStripMenuItem.Text = "Consultar Reservaciones";
            this.consultarReservacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarReservacionesToolStripMenuItem_Click);
            // 
            // FrmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCajero";
            this.Text = "FrmCajero";
            this.Load += new System.EventHandler(this.FrmCajero_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Mesa1.ResumeLayout(false);
            this.Mesa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem consultarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUnNuevoClienteToolStripMenuItem;
        private DataSetOrdenes dataSetOrdenes;
        private System.Windows.Forms.BindingSource ordenesBindingSource;
        private DataSetOrdenesTableAdapters.ordenesTableAdapter ordenesTableAdapter;
        private DataSetOrdenesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Mesa1;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInformacionDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarReservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReservacionToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private DataSetClientes dataSetClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource dataSetProductosBindingSource;
        private DataSetProductos dataSetProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DataSetProductosTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private DataSetMesas dataSetMesas;
        private System.Windows.Forms.BindingSource mesaBindingSource;
        private DataSetMesasTableAdapters.mesaTableAdapter mesaTableAdapter;
        private System.Windows.Forms.BindingSource mesaBindingSource1;
        private System.Windows.Forms.BindingSource ordenesBindingSource4;
        private System.Windows.Forms.BindingSource ordenesBindingSource3;
        private System.Windows.Forms.BindingSource ordenesBindingSource2;
        private System.Windows.Forms.BindingSource ordenesBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem nuevoServicioADomicilioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservacionesToolStripMenuItem;
    }
}