namespace RestoSoft
{
    partial class FrmEliminarServicio
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
            System.Windows.Forms.Label numeroDeMesaLabel;
            System.Windows.Forms.Label horaDeLlegadaLabel;
            System.Windows.Forms.Label horaDeSalidaLabel;
            System.Windows.Forms.Label nombreClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarServicio));
            this.restosoftDataSetServicio = new RestoSoft.RestosoftDataSetServicio();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioTableAdapter = new RestoSoft.RestosoftDataSetServicioTableAdapters.servicioTableAdapter();
            this.tableAdapterManager = new RestoSoft.RestosoftDataSetServicioTableAdapters.TableAdapterManager();
            this.servicioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.numeroDeMesaTextBox = new System.Windows.Forms.TextBox();
            this.horaDeLlegadaTextBox = new System.Windows.Forms.TextBox();
            this.horaDeSalidaTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            idServicioLabel = new System.Windows.Forms.Label();
            numeroDeMesaLabel = new System.Windows.Forms.Label();
            horaDeLlegadaLabel = new System.Windows.Forms.Label();
            horaDeSalidaLabel = new System.Windows.Forms.Label();
            nombreClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingNavigator)).BeginInit();
            this.servicioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idServicioLabel
            // 
            idServicioLabel.AutoSize = true;
            idServicioLabel.Location = new System.Drawing.Point(5, 41);
            idServicioLabel.Name = "idServicioLabel";
            idServicioLabel.Size = new System.Drawing.Size(60, 13);
            idServicioLabel.TabIndex = 1;
            idServicioLabel.Text = "Id Servicio:";
            // 
            // numeroDeMesaLabel
            // 
            numeroDeMesaLabel.AutoSize = true;
            numeroDeMesaLabel.Location = new System.Drawing.Point(5, 67);
            numeroDeMesaLabel.Name = "numeroDeMesaLabel";
            numeroDeMesaLabel.Size = new System.Drawing.Size(93, 13);
            numeroDeMesaLabel.TabIndex = 3;
            numeroDeMesaLabel.Text = "Numero De Mesa:";
            // 
            // horaDeLlegadaLabel
            // 
            horaDeLlegadaLabel.AutoSize = true;
            horaDeLlegadaLabel.Location = new System.Drawing.Point(5, 93);
            horaDeLlegadaLabel.Name = "horaDeLlegadaLabel";
            horaDeLlegadaLabel.Size = new System.Drawing.Size(91, 13);
            horaDeLlegadaLabel.TabIndex = 5;
            horaDeLlegadaLabel.Text = "Hora De Llegada:";
            // 
            // horaDeSalidaLabel
            // 
            horaDeSalidaLabel.AutoSize = true;
            horaDeSalidaLabel.Location = new System.Drawing.Point(5, 119);
            horaDeSalidaLabel.Name = "horaDeSalidaLabel";
            horaDeSalidaLabel.Size = new System.Drawing.Size(82, 13);
            horaDeSalidaLabel.TabIndex = 7;
            horaDeSalidaLabel.Text = "Hora De Salida:";
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(5, 145);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(82, 13);
            nombreClienteLabel.TabIndex = 9;
            nombreClienteLabel.Text = "Hombre Cliente:";
            // 
            // restosoftDataSetServicio
            // 
            this.restosoftDataSetServicio.DataSetName = "RestosoftDataSetServicio";
            this.restosoftDataSetServicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "servicio";
            this.servicioBindingSource.DataSource = this.restosoftDataSetServicio;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.servicioTableAdapter = this.servicioTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.RestosoftDataSetServicioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicioBindingNavigator
            // 
            this.servicioBindingNavigator.AddNewItem = null;
            this.servicioBindingNavigator.BindingSource = this.servicioBindingSource;
            this.servicioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicioBindingNavigator.Name = "servicioBindingNavigator";
            this.servicioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicioBindingNavigator.Size = new System.Drawing.Size(315, 25);
            this.servicioBindingNavigator.TabIndex = 0;
            this.servicioBindingNavigator.Text = "bindingNavigator1";
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
            this.idServicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioBindingSource, "idServicio", true));
            this.idServicioTextBox.Enabled = false;
            this.idServicioTextBox.Location = new System.Drawing.Point(102, 38);
            this.idServicioTextBox.Name = "idServicioTextBox";
            this.idServicioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idServicioTextBox.TabIndex = 2;
            // 
            // numeroDeMesaTextBox
            // 
            this.numeroDeMesaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioBindingSource, "numeroDeMesa", true));
            this.numeroDeMesaTextBox.Enabled = false;
            this.numeroDeMesaTextBox.Location = new System.Drawing.Point(102, 64);
            this.numeroDeMesaTextBox.Name = "numeroDeMesaTextBox";
            this.numeroDeMesaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroDeMesaTextBox.TabIndex = 4;
            // 
            // horaDeLlegadaTextBox
            // 
            this.horaDeLlegadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioBindingSource, "horaDeLlegada", true));
            this.horaDeLlegadaTextBox.Enabled = false;
            this.horaDeLlegadaTextBox.Location = new System.Drawing.Point(102, 90);
            this.horaDeLlegadaTextBox.Name = "horaDeLlegadaTextBox";
            this.horaDeLlegadaTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaDeLlegadaTextBox.TabIndex = 6;
            // 
            // horaDeSalidaTextBox
            // 
            this.horaDeSalidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioBindingSource, "horaDeSalida", true));
            this.horaDeSalidaTextBox.Enabled = false;
            this.horaDeSalidaTextBox.Location = new System.Drawing.Point(102, 116);
            this.horaDeSalidaTextBox.Name = "horaDeSalidaTextBox";
            this.horaDeSalidaTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaDeSalidaTextBox.TabIndex = 8;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicioBindingSource, "nombreCliente", true));
            this.nombreClienteTextBox.Enabled = false;
            this.nombreClienteTextBox.Location = new System.Drawing.Point(102, 142);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreClienteTextBox.TabIndex = 10;
            // 
            // FrmEliminarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 255);
            this.Controls.Add(idServicioLabel);
            this.Controls.Add(this.idServicioTextBox);
            this.Controls.Add(numeroDeMesaLabel);
            this.Controls.Add(this.numeroDeMesaTextBox);
            this.Controls.Add(horaDeLlegadaLabel);
            this.Controls.Add(this.horaDeLlegadaTextBox);
            this.Controls.Add(horaDeSalidaLabel);
            this.Controls.Add(this.horaDeSalidaTextBox);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(this.servicioBindingNavigator);
            this.Name = "FrmEliminarServicio";
            this.Text = "Eliminar Servicio";
            this.Load += new System.EventHandler(this.FrmEliminarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingNavigator)).EndInit();
            this.servicioBindingNavigator.ResumeLayout(false);
            this.servicioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestosoftDataSetServicio restosoftDataSetServicio;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private RestosoftDataSetServicioTableAdapters.servicioTableAdapter servicioTableAdapter;
        private RestosoftDataSetServicioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicioBindingNavigator;
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
        private System.Windows.Forms.TextBox idServicioTextBox;
        private System.Windows.Forms.TextBox numeroDeMesaTextBox;
        private System.Windows.Forms.TextBox horaDeLlegadaTextBox;
        private System.Windows.Forms.TextBox horaDeSalidaTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
    }
}