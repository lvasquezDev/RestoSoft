namespace RestoSoft
{
    partial class NuevaReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaReservacion));
            this.dataSetReservaciones = new RestoSoft.DataSetReservaciones();
            this.reservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservacionTableAdapter = new RestoSoft.DataSetReservacionesTableAdapters.reservacionTableAdapter();
            this.tableAdapterManager = new RestoSoft.DataSetReservacionesTableAdapters.TableAdapterManager();
            this.reservacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reservacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            idReservacionLabel.Location = new System.Drawing.Point(5, 42);
            idReservacionLabel.Name = "idReservacionLabel";
            idReservacionLabel.Size = new System.Drawing.Size(84, 13);
            idReservacionLabel.TabIndex = 1;
            idReservacionLabel.Text = "ID Reservacion:";
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(5, 68);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(82, 13);
            nombreClienteLabel.TabIndex = 3;
            nombreClienteLabel.Text = "Nombre Cliente:";
            // 
            // mesaLabel
            // 
            mesaLabel.AutoSize = true;
            mesaLabel.Location = new System.Drawing.Point(5, 94);
            mesaLabel.Name = "mesaLabel";
            mesaLabel.Size = new System.Drawing.Size(36, 13);
            mesaLabel.TabIndex = 5;
            mesaLabel.Text = "Mesa:";
            // 
            // fechaHoraLabel
            // 
            fechaHoraLabel.AutoSize = true;
            fechaHoraLabel.Location = new System.Drawing.Point(5, 121);
            fechaHoraLabel.Name = "fechaHoraLabel";
            fechaHoraLabel.Size = new System.Drawing.Size(74, 13);
            fechaHoraLabel.TabIndex = 7;
            fechaHoraLabel.Text = "Fecha y Hora:";
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
            this.reservacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reservacionBindingNavigator.BindingSource = this.reservacionBindingSource;
            this.reservacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservacionBindingNavigator.DeleteItem = null;
            this.reservacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorAddNewItem,
            this.reservacionBindingNavigatorSaveItem});
            this.reservacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservacionBindingNavigator.MoveFirstItem = null;
            this.reservacionBindingNavigator.MoveLastItem = null;
            this.reservacionBindingNavigator.MoveNextItem = null;
            this.reservacionBindingNavigator.MovePreviousItem = null;
            this.reservacionBindingNavigator.Name = "reservacionBindingNavigator";
            this.reservacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservacionBindingNavigator.Size = new System.Drawing.Size(304, 25);
            this.reservacionBindingNavigator.TabIndex = 0;
            this.reservacionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // reservacionBindingNavigatorSaveItem
            // 
            this.reservacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reservacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reservacionBindingNavigatorSaveItem.Image")));
            this.reservacionBindingNavigatorSaveItem.Name = "reservacionBindingNavigatorSaveItem";
            this.reservacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reservacionBindingNavigatorSaveItem.Text = "Save Data";
            this.reservacionBindingNavigatorSaveItem.Click += new System.EventHandler(this.reservacionBindingNavigatorSaveItem_Click);
            // 
            // idReservacionTextBox
            // 
            this.idReservacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservacionBindingSource, "idReservacion", true));
            this.idReservacionTextBox.Location = new System.Drawing.Point(92, 39);
            this.idReservacionTextBox.Name = "idReservacionTextBox";
            this.idReservacionTextBox.Size = new System.Drawing.Size(200, 20);
            this.idReservacionTextBox.TabIndex = 2;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservacionBindingSource, "nombreCliente", true));
            this.nombreClienteTextBox.Location = new System.Drawing.Point(92, 65);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreClienteTextBox.TabIndex = 4;
            // 
            // mesaTextBox
            // 
            this.mesaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservacionBindingSource, "mesa", true));
            this.mesaTextBox.Location = new System.Drawing.Point(92, 91);
            this.mesaTextBox.Name = "mesaTextBox";
            this.mesaTextBox.Size = new System.Drawing.Size(200, 20);
            this.mesaTextBox.TabIndex = 6;
            // 
            // fechaHoraDateTimePicker
            // 
            this.fechaHoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservacionBindingSource, "fechaHora", true));
            this.fechaHoraDateTimePicker.Location = new System.Drawing.Point(92, 117);
            this.fechaHoraDateTimePicker.Name = "fechaHoraDateTimePicker";
            this.fechaHoraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaHoraDateTimePicker.TabIndex = 8;
            // 
            // NuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 148);
            this.Controls.Add(idReservacionLabel);
            this.Controls.Add(this.idReservacionTextBox);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(mesaLabel);
            this.Controls.Add(this.mesaTextBox);
            this.Controls.Add(fechaHoraLabel);
            this.Controls.Add(this.fechaHoraDateTimePicker);
            this.Controls.Add(this.reservacionBindingNavigator);
            this.Name = "NuevaReservacion";
            this.Text = "Nueva Reservacion";
            this.Load += new System.EventHandler(this.NuevaReservacion_Load);
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton reservacionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idReservacionTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox mesaTextBox;
        private System.Windows.Forms.DateTimePicker fechaHoraDateTimePicker;
    }
}