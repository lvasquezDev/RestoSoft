namespace RestoSoft
{
    partial class FrmEliminarOrden
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
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label numeroDeMesaLabel;
            System.Windows.Forms.Label numeroOrdenLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label nombreProductoLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label claveEmpleadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarOrden));
            this.restosoftDataSetOrdenesBuenas = new RestoSoft.RestosoftDataSetOrdenesBuenas();
            this.ordenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesTableAdapter = new RestoSoft.RestosoftDataSetOrdenesBuenasTableAdapters.ordenesTableAdapter();
            this.tableAdapterManager = new RestoSoft.RestosoftDataSetOrdenesBuenasTableAdapters.TableAdapterManager();
            this.ordenesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.numeroDeMesaTextBox = new System.Windows.Forms.TextBox();
            this.numeroOrdenTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.claveEmpleadoTextBox = new System.Windows.Forms.TextBox();
            nombreClienteLabel = new System.Windows.Forms.Label();
            numeroDeMesaLabel = new System.Windows.Forms.Label();
            numeroOrdenLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            nombreProductoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            claveEmpleadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetOrdenesBuenas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingNavigator)).BeginInit();
            this.ordenesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(7, 43);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(82, 13);
            nombreClienteLabel.TabIndex = 1;
            nombreClienteLabel.Text = "Nombre Cliente:";
            // 
            // numeroDeMesaLabel
            // 
            numeroDeMesaLabel.AutoSize = true;
            numeroDeMesaLabel.Location = new System.Drawing.Point(7, 69);
            numeroDeMesaLabel.Name = "numeroDeMesaLabel";
            numeroDeMesaLabel.Size = new System.Drawing.Size(93, 13);
            numeroDeMesaLabel.TabIndex = 3;
            numeroDeMesaLabel.Text = "Numero De Mesa:";
            // 
            // numeroOrdenLabel
            // 
            numeroOrdenLabel.AutoSize = true;
            numeroOrdenLabel.Location = new System.Drawing.Point(7, 95);
            numeroOrdenLabel.Name = "numeroOrdenLabel";
            numeroOrdenLabel.Size = new System.Drawing.Size(79, 13);
            numeroOrdenLabel.TabIndex = 5;
            numeroOrdenLabel.Text = "Numero Orden:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(7, 121);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 7;
            horaLabel.Text = "Hora:";
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new System.Drawing.Point(7, 147);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new System.Drawing.Size(93, 13);
            nombreProductoLabel.TabIndex = 9;
            nombreProductoLabel.Text = "Nombre Producto:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(7, 173);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(7, 199);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 13;
            subTotalLabel.Text = "Sub Total:";
            // 
            // claveEmpleadoLabel
            // 
            claveEmpleadoLabel.AutoSize = true;
            claveEmpleadoLabel.Location = new System.Drawing.Point(7, 225);
            claveEmpleadoLabel.Name = "claveEmpleadoLabel";
            claveEmpleadoLabel.Size = new System.Drawing.Size(87, 13);
            claveEmpleadoLabel.TabIndex = 15;
            claveEmpleadoLabel.Text = "Clave Empleado:";
            // 
            // restosoftDataSetOrdenesBuenas
            // 
            this.restosoftDataSetOrdenesBuenas.DataSetName = "RestosoftDataSetOrdenesBuenas";
            this.restosoftDataSetOrdenesBuenas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenesBindingSource
            // 
            this.ordenesBindingSource.DataMember = "ordenes";
            this.ordenesBindingSource.DataSource = this.restosoftDataSetOrdenesBuenas;
            // 
            // ordenesTableAdapter
            // 
            this.ordenesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ordenesTableAdapter = this.ordenesTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.RestosoftDataSetOrdenesBuenasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordenesBindingNavigator
            // 
            this.ordenesBindingNavigator.AddNewItem = null;
            this.ordenesBindingNavigator.BindingSource = this.ordenesBindingSource;
            this.ordenesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordenesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordenesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.ordenesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordenesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordenesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordenesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordenesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordenesBindingNavigator.Name = "ordenesBindingNavigator";
            this.ordenesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordenesBindingNavigator.Size = new System.Drawing.Size(331, 25);
            this.ordenesBindingNavigator.TabIndex = 0;
            this.ordenesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "nombreCliente", true));
            this.nombreClienteTextBox.Enabled = false;
            this.nombreClienteTextBox.Location = new System.Drawing.Point(104, 40);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreClienteTextBox.TabIndex = 2;
            // 
            // numeroDeMesaTextBox
            // 
            this.numeroDeMesaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "numeroDeMesa", true));
            this.numeroDeMesaTextBox.Enabled = false;
            this.numeroDeMesaTextBox.Location = new System.Drawing.Point(104, 66);
            this.numeroDeMesaTextBox.Name = "numeroDeMesaTextBox";
            this.numeroDeMesaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroDeMesaTextBox.TabIndex = 4;
            // 
            // numeroOrdenTextBox
            // 
            this.numeroOrdenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "numeroOrden", true));
            this.numeroOrdenTextBox.Enabled = false;
            this.numeroOrdenTextBox.Location = new System.Drawing.Point(104, 92);
            this.numeroOrdenTextBox.Name = "numeroOrdenTextBox";
            this.numeroOrdenTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroOrdenTextBox.TabIndex = 6;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "hora", true));
            this.horaTextBox.Enabled = false;
            this.horaTextBox.Location = new System.Drawing.Point(104, 118);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaTextBox.TabIndex = 8;
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "nombreProducto", true));
            this.nombreProductoTextBox.Enabled = false;
            this.nombreProductoTextBox.Location = new System.Drawing.Point(104, 144);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreProductoTextBox.TabIndex = 10;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "cantidad", true));
            this.cantidadTextBox.Enabled = false;
            this.cantidadTextBox.Location = new System.Drawing.Point(104, 170);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 12;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "subTotal", true));
            this.subTotalTextBox.Enabled = false;
            this.subTotalTextBox.Location = new System.Drawing.Point(104, 196);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subTotalTextBox.TabIndex = 14;
            // 
            // claveEmpleadoTextBox
            // 
            this.claveEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenesBindingSource, "claveEmpleado", true));
            this.claveEmpleadoTextBox.Enabled = false;
            this.claveEmpleadoTextBox.Location = new System.Drawing.Point(104, 222);
            this.claveEmpleadoTextBox.Name = "claveEmpleadoTextBox";
            this.claveEmpleadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveEmpleadoTextBox.TabIndex = 16;
            // 
            // FrmEliminarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 367);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(numeroDeMesaLabel);
            this.Controls.Add(this.numeroDeMesaTextBox);
            this.Controls.Add(numeroOrdenLabel);
            this.Controls.Add(this.numeroOrdenTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(nombreProductoLabel);
            this.Controls.Add(this.nombreProductoTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(claveEmpleadoLabel);
            this.Controls.Add(this.claveEmpleadoTextBox);
            this.Controls.Add(this.ordenesBindingNavigator);
            this.Name = "FrmEliminarOrden";
            this.Text = "Eliminar Orden";
            this.Load += new System.EventHandler(this.FrmEliminarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetOrdenesBuenas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesBindingNavigator)).EndInit();
            this.ordenesBindingNavigator.ResumeLayout(false);
            this.ordenesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestosoftDataSetOrdenesBuenas restosoftDataSetOrdenesBuenas;
        private System.Windows.Forms.BindingSource ordenesBindingSource;
        private RestosoftDataSetOrdenesBuenasTableAdapters.ordenesTableAdapter ordenesTableAdapter;
        private RestosoftDataSetOrdenesBuenasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordenesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox numeroDeMesaTextBox;
        private System.Windows.Forms.TextBox numeroOrdenTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox claveEmpleadoTextBox;
    }
}