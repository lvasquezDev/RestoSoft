namespace RestoSoft
{
    partial class FrmEliminarServicioDomicilio
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
            System.Windows.Forms.Label idServicioLabel;
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label ordenLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label costoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarServicioDomicilio));
            this.dataSetDomicilio = new RestoSoft.DataSetDomicilio();
            this.domicilioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domicilioTableAdapter = new RestoSoft.DataSetDomicilioTableAdapters.domicilioTableAdapter();
            this.tableAdapterManager = new RestoSoft.DataSetDomicilioTableAdapters.TableAdapterManager();
            this.domicilioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.idServicioTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.ordenTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            idServicioLabel = new System.Windows.Forms.Label();
            nombreClienteLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            ordenLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioBindingNavigator)).BeginInit();
            this.domicilioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idServicioLabel
            // 
            idServicioLabel.AutoSize = true;
            idServicioLabel.Location = new System.Drawing.Point(8, 41);
            idServicioLabel.Name = "idServicioLabel";
            idServicioLabel.Size = new System.Drawing.Size(59, 13);
            idServicioLabel.TabIndex = 1;
            idServicioLabel.Text = "id Servicio:";
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(8, 67);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(80, 13);
            nombreClienteLabel.TabIndex = 3;
            nombreClienteLabel.Text = "nombre Cliente:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(8, 93);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 5;
            telefonoLabel.Text = "telefono:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(8, 119);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(50, 13);
            domicilioLabel.TabIndex = 7;
            domicilioLabel.Text = "domicilio:";
            // 
            // ordenLabel
            // 
            ordenLabel.AutoSize = true;
            ordenLabel.Location = new System.Drawing.Point(8, 145);
            ordenLabel.Name = "ordenLabel";
            ordenLabel.Size = new System.Drawing.Size(39, 13);
            ordenLabel.TabIndex = 9;
            ordenLabel.Text = "Orden:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(8, 171);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(8, 197);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(37, 13);
            costoLabel.TabIndex = 13;
            costoLabel.Text = "Costo:";
            // 
            // dataSetDomicilio
            // 
            this.dataSetDomicilio.DataSetName = "DataSetDomicilio";
            this.dataSetDomicilio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // domicilioBindingSource
            // 
            this.domicilioBindingSource.DataMember = "domicilio";
            this.domicilioBindingSource.DataSource = this.dataSetDomicilio;
            // 
            // domicilioTableAdapter
            // 
            this.domicilioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.domicilioTableAdapter = this.domicilioTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.DataSetDomicilioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // domicilioBindingNavigator
            // 
            this.domicilioBindingNavigator.AddNewItem = null;
            this.domicilioBindingNavigator.BindingSource = this.domicilioBindingSource;
            this.domicilioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.domicilioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.domicilioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.domicilioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.domicilioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.domicilioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.domicilioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.domicilioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.domicilioBindingNavigator.Name = "domicilioBindingNavigator";
            this.domicilioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.domicilioBindingNavigator.Size = new System.Drawing.Size(315, 25);
            this.domicilioBindingNavigator.TabIndex = 0;
            this.domicilioBindingNavigator.Text = "bindingNavigator1";
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
            // idServicioTextBox
            // 
            this.idServicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domicilioBindingSource, "idServicio", true));
            this.idServicioTextBox.Enabled = false;
            this.idServicioTextBox.Location = new System.Drawing.Point(94, 38);
            this.idServicioTextBox.Name = "idServicioTextBox";
            this.idServicioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idServicioTextBox.TabIndex = 2;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domicilioBindingSource, "nombreCliente", true));
            this.nombreClienteTextBox.Enabled = false;
            this.nombreClienteTextBox.Location = new System.Drawing.Point(94, 64);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreClienteTextBox.TabIndex = 4;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domicilioBindingSource, "telefono", true));
            this.telefonoTextBox.Enabled = false;
            this.telefonoTextBox.Location = new System.Drawing.Point(94, 90);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 6;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domicilioBindingSource, "domicilio", true));
            this.domicilioTextBox.Enabled = false;
            this.domicilioTextBox.Location = new System.Drawing.Point(94, 116);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(100, 20);
            this.domicilioTextBox.TabIndex = 8;
            // 
            // ordenTextBox
            // 
            this.ordenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domicilioBindingSource, "Orden", true));
            this.ordenTextBox.Enabled = false;
            this.ordenTextBox.Location = new System.Drawing.Point(94, 142);
            this.ordenTextBox.Name = "ordenTextBox";
            this.ordenTextBox.Size = new System.Drawing.Size(100, 20);
            this.ordenTextBox.TabIndex = 10;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domicilioBindingSource, "Cantidad", true));
            this.cantidadTextBox.Enabled = false;
            this.cantidadTextBox.Location = new System.Drawing.Point(94, 168);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 12;
            // 
            // costoTextBox
            // 
            this.costoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.domicilioBindingSource, "Costo", true));
            this.costoTextBox.Enabled = false;
            this.costoTextBox.Location = new System.Drawing.Point(94, 194);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoTextBox.TabIndex = 14;
            // 
            // FrmEliminarServicioDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 331);
            this.Controls.Add(idServicioLabel);
            this.Controls.Add(this.idServicioTextBox);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.domicilioTextBox);
            this.Controls.Add(ordenLabel);
            this.Controls.Add(this.ordenTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.domicilioBindingNavigator);
            this.Name = "FrmEliminarServicioDomicilio";
            this.Text = "Cancelar Servicio Domicilio";
            this.Load += new System.EventHandler(this.FrmEliminarServicioDomicilio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioBindingNavigator)).EndInit();
            this.domicilioBindingNavigator.ResumeLayout(false);
            this.domicilioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetDomicilio dataSetDomicilio;
        private System.Windows.Forms.BindingSource domicilioBindingSource;
        private DataSetDomicilioTableAdapters.domicilioTableAdapter domicilioTableAdapter;
        private DataSetDomicilioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator domicilioBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox idServicioTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.TextBox ordenTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    }
}