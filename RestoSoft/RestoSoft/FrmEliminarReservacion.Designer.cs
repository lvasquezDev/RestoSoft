namespace RestoSoft
{
    partial class FrmEliminarReservacion
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
            System.Windows.Forms.Label idReservacionLabel;
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label mesaLabel;
            System.Windows.Forms.Label fechaHoraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarReservacion));
            this.dataSetReservaciones = new RestoSoft.DataSetReservaciones();
            this.reservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservacionTableAdapter = new RestoSoft.DataSetReservacionesTableAdapters.reservacionTableAdapter();
            this.tableAdapterManager = new RestoSoft.DataSetReservacionesTableAdapters.TableAdapterManager();
            this.reservacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.idReservacionTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.mesaTextBox = new System.Windows.Forms.TextBox();
            this.fechaHoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idReservacionLabel = new System.Windows.Forms.Label();
            nombreClienteLabel = new System.Windows.Forms.Label();
            mesaLabel = new System.Windows.Forms.Label();
            fechaHoraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionBindingNavigator)).BeginInit();
            this.reservacionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idReservacionLabel
            // 
            idReservacionLabel.AutoSize = true;
            idReservacionLabel.Location = new System.Drawing.Point(12, 42);
            idReservacionLabel.Name = "idReservacionLabel";
            idReservacionLabel.Size = new System.Drawing.Size(81, 13);
            idReservacionLabel.TabIndex = 1;
            idReservacionLabel.Text = "id Reservacion:";
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(12, 68);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(80, 13);
            nombreClienteLabel.TabIndex = 3;
            nombreClienteLabel.Text = "nombre Cliente:";
            // 
            // mesaLabel
            // 
            mesaLabel.AutoSize = true;
            mesaLabel.Location = new System.Drawing.Point(12, 94);
            mesaLabel.Name = "mesaLabel";
            mesaLabel.Size = new System.Drawing.Size(35, 13);
            mesaLabel.TabIndex = 5;
            mesaLabel.Text = "mesa:";
            // 
            // fechaHoraLabel
            // 
            fechaHoraLabel.AutoSize = true;
            fechaHoraLabel.Location = new System.Drawing.Point(12, 121);
            fechaHoraLabel.Name = "fechaHoraLabel";
            fechaHoraLabel.Size = new System.Drawing.Size(63, 13);
            fechaHoraLabel.TabIndex = 7;
            fechaHoraLabel.Text = "fecha Hora:";
            // 
            // dataSetReservaciones
            // 
            this.dataSetReservaciones.DataSetName = "DataSetReservaciones";
            this.dataSetReservaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservacionBindingSource
            // 
            this.reservacionBindingSource.DataMember = "reservacion";
            this.reservacionBindingSource.DataSource = this.dataSetReservaciones;
            // 
            // reservacionTableAdapter
            // 
            this.reservacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.reservacionTableAdapter = this.reservacionTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.DataSetReservacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reservacionBindingNavigator
            // 
            this.reservacionBindingNavigator.AddNewItem = null;
            this.reservacionBindingNavigator.BindingSource = this.reservacionBindingSource;
            this.reservacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reservacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reservacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservacionBindingNavigator.Name = "reservacionBindingNavigator";
            this.reservacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservacionBindingNavigator.Size = new System.Drawing.Size(400, 25);
            this.reservacionBindingNavigator.TabIndex = 0;
            this.reservacionBindingNavigator.Text = "bindingNavigator1";
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
            // idReservacionTextBox
            // 
            this.idReservacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservacionBindingSource, "idReservacion", true));
            this.idReservacionTextBox.Enabled = false;
            this.idReservacionTextBox.Location = new System.Drawing.Point(99, 39);
            this.idReservacionTextBox.Name = "idReservacionTextBox";
            this.idReservacionTextBox.Size = new System.Drawing.Size(200, 20);
            this.idReservacionTextBox.TabIndex = 2;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservacionBindingSource, "nombreCliente", true));
            this.nombreClienteTextBox.Enabled = false;
            this.nombreClienteTextBox.Location = new System.Drawing.Point(99, 65);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreClienteTextBox.TabIndex = 4;
            // 
            // mesaTextBox
            // 
            this.mesaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservacionBindingSource, "mesa", true));
            this.mesaTextBox.Enabled = false;
            this.mesaTextBox.Location = new System.Drawing.Point(99, 91);
            this.mesaTextBox.Name = "mesaTextBox";
            this.mesaTextBox.Size = new System.Drawing.Size(200, 20);
            this.mesaTextBox.TabIndex = 6;
            // 
            // fechaHoraDateTimePicker
            // 
            this.fechaHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservacionBindingSource, "fechaHora", true));
            this.fechaHoraDateTimePicker.Enabled = false;
            this.fechaHoraDateTimePicker.Location = new System.Drawing.Point(99, 117);
            this.fechaHoraDateTimePicker.Name = "fechaHoraDateTimePicker";
            this.fechaHoraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaHoraDateTimePicker.TabIndex = 8;
            // 
            // FrmEliminarReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(idReservacionLabel);
            this.Controls.Add(this.idReservacionTextBox);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(mesaLabel);
            this.Controls.Add(this.mesaTextBox);
            this.Controls.Add(fechaHoraLabel);
            this.Controls.Add(this.fechaHoraDateTimePicker);
            this.Controls.Add(this.reservacionBindingNavigator);
            this.Name = "FrmEliminarReservacion";
            this.Text = "Eliminar Reservacion";
            this.Load += new System.EventHandler(this.FrmEliminarReservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionBindingNavigator)).EndInit();
            this.reservacionBindingNavigator.ResumeLayout(false);
            this.reservacionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetReservaciones dataSetReservaciones;
        private System.Windows.Forms.BindingSource reservacionBindingSource;
        private DataSetReservacionesTableAdapters.reservacionTableAdapter reservacionTableAdapter;
        private DataSetReservacionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reservacionBindingNavigator;
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
        private System.Windows.Forms.TextBox idReservacionTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox mesaTextBox;
        private System.Windows.Forms.DateTimePicker fechaHoraDateTimePicker;
    }
}