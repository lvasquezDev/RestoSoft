namespace RestoSoft
{
    partial class FrmModificarInvArticulo
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
            System.Windows.Forms.Label idProductoLabel;
            System.Windows.Forms.Label ingredientesLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label proveedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarInvArticulo));
            this.restosoftDataSetModificarInventario = new RestoSoft.RestosoftDataSetModificarInventario();
            this.inventariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventariosTableAdapter = new RestoSoft.RestosoftDataSetModificarInventarioTableAdapters.inventariosTableAdapter();
            this.tableAdapterManager = new RestoSoft.RestosoftDataSetModificarInventarioTableAdapters.TableAdapterManager();
            this.inventariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inventariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idProductoTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesTextBox = new System.Windows.Forms.TextBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.proveedorTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idProductoLabel = new System.Windows.Forms.Label();
            ingredientesLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            proveedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetModificarInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingNavigator)).BeginInit();
            this.inventariosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idProductoLabel
            // 
            idProductoLabel.AutoSize = true;
            idProductoLabel.Location = new System.Drawing.Point(7, 31);
            idProductoLabel.Name = "idProductoLabel";
            idProductoLabel.Size = new System.Drawing.Size(64, 13);
            idProductoLabel.TabIndex = 1;
            idProductoLabel.Text = "id Producto:";
            // 
            // ingredientesLabel
            // 
            ingredientesLabel.AutoSize = true;
            ingredientesLabel.Location = new System.Drawing.Point(7, 57);
            ingredientesLabel.Name = "ingredientesLabel";
            ingredientesLabel.Size = new System.Drawing.Size(67, 13);
            ingredientesLabel.TabIndex = 3;
            ingredientesLabel.Text = "ingredientes:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(7, 83);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(57, 13);
            existenciaLabel.TabIndex = 5;
            existenciaLabel.Text = "existencia:";
            // 
            // proveedorLabel
            // 
            proveedorLabel.AutoSize = true;
            proveedorLabel.Location = new System.Drawing.Point(7, 109);
            proveedorLabel.Name = "proveedorLabel";
            proveedorLabel.Size = new System.Drawing.Size(58, 13);
            proveedorLabel.TabIndex = 7;
            proveedorLabel.Text = "proveedor:";
            // 
            // restosoftDataSetModificarInventario
            // 
            this.restosoftDataSetModificarInventario.DataSetName = "RestosoftDataSetModificarInventario";
            this.restosoftDataSetModificarInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventariosBindingSource
            // 
            this.inventariosBindingSource.DataMember = "inventarios";
            this.inventariosBindingSource.DataSource = this.restosoftDataSetModificarInventario;
            // 
            // inventariosTableAdapter
            // 
            this.inventariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inventariosTableAdapter = this.inventariosTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.RestosoftDataSetModificarInventarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventariosBindingNavigator
            // 
            this.inventariosBindingNavigator.AddNewItem = null;
            this.inventariosBindingNavigator.BindingSource = this.inventariosBindingSource;
            this.inventariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventariosBindingNavigator.DeleteItem = null;
            this.inventariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.inventariosBindingNavigatorSaveItem});
            this.inventariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventariosBindingNavigator.Name = "inventariosBindingNavigator";
            this.inventariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventariosBindingNavigator.Size = new System.Drawing.Size(312, 25);
            this.inventariosBindingNavigator.TabIndex = 0;
            this.inventariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // inventariosBindingNavigatorSaveItem
            // 
            this.inventariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventariosBindingNavigatorSaveItem.Image")));
            this.inventariosBindingNavigatorSaveItem.Name = "inventariosBindingNavigatorSaveItem";
            this.inventariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventariosBindingNavigatorSaveItem.Text = "Save Data";
            this.inventariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventariosBindingNavigatorSaveItem_Click);
            // 
            // idProductoTextBox
            // 
            this.idProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "idProducto", true));
            this.idProductoTextBox.Enabled = false;
            this.idProductoTextBox.Location = new System.Drawing.Point(80, 28);
            this.idProductoTextBox.Name = "idProductoTextBox";
            this.idProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idProductoTextBox.TabIndex = 2;
            // 
            // ingredientesTextBox
            // 
            this.ingredientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "ingredientes", true));
            this.ingredientesTextBox.Enabled = false;
            this.ingredientesTextBox.Location = new System.Drawing.Point(80, 54);
            this.ingredientesTextBox.Name = "ingredientesTextBox";
            this.ingredientesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ingredientesTextBox.TabIndex = 4;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "existencia", true));
            this.existenciaTextBox.Enabled = false;
            this.existenciaTextBox.Location = new System.Drawing.Point(80, 80);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.existenciaTextBox.TabIndex = 6;
            // 
            // proveedorTextBox
            // 
            this.proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "proveedor", true));
            this.proveedorTextBox.Enabled = false;
            this.proveedorTextBox.Location = new System.Drawing.Point(80, 106);
            this.proveedorTextBox.Name = "proveedorTextBox";
            this.proveedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.proveedorTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmModificarInvArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(idProductoLabel);
            this.Controls.Add(this.idProductoTextBox);
            this.Controls.Add(ingredientesLabel);
            this.Controls.Add(this.ingredientesTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(proveedorLabel);
            this.Controls.Add(this.proveedorTextBox);
            this.Controls.Add(this.inventariosBindingNavigator);
            this.Name = "FrmModificarInvArticulo";
            this.Text = "Modificar Articulo";
            this.Load += new System.EventHandler(this.FrmModificarInvArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetModificarInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingNavigator)).EndInit();
            this.inventariosBindingNavigator.ResumeLayout(false);
            this.inventariosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestosoftDataSetModificarInventario restosoftDataSetModificarInventario;
        private System.Windows.Forms.BindingSource inventariosBindingSource;
        private RestosoftDataSetModificarInventarioTableAdapters.inventariosTableAdapter inventariosTableAdapter;
        private RestosoftDataSetModificarInventarioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventariosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inventariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idProductoTextBox;
        private System.Windows.Forms.TextBox ingredientesTextBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.TextBox proveedorTextBox;
        private System.Windows.Forms.Button button1;
    }
}