﻿namespace RestoSoft
{
    partial class FrmNuevoPlatillo
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
            System.Windows.Forms.Label nombreproductoLabel;
            System.Windows.Forms.Label tipoComidaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label costoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoPlatillo));
            this.restosoftDataSetModificarPorductos = new RestoSoft.RestosoftDataSetModificarPorductos();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new RestoSoft.RestosoftDataSetModificarPorductosTableAdapters.productoTableAdapter();
            this.tableAdapterManager = new RestoSoft.RestosoftDataSetModificarPorductosTableAdapters.TableAdapterManager();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreproductoTextBox = new System.Windows.Forms.TextBox();
            this.tipoComidaTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            nombreproductoLabel = new System.Windows.Forms.Label();
            tipoComidaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetModificarPorductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreproductoLabel
            // 
            nombreproductoLabel.AutoSize = true;
            nombreproductoLabel.Location = new System.Drawing.Point(9, 57);
            nombreproductoLabel.Name = "nombreproductoLabel";
            nombreproductoLabel.Size = new System.Drawing.Size(87, 13);
            nombreproductoLabel.TabIndex = 1;
            nombreproductoLabel.Text = "nombreproducto:";
            // 
            // tipoComidaLabel
            // 
            tipoComidaLabel.AutoSize = true;
            tipoComidaLabel.Location = new System.Drawing.Point(9, 83);
            tipoComidaLabel.Name = "tipoComidaLabel";
            tipoComidaLabel.Size = new System.Drawing.Size(65, 13);
            tipoComidaLabel.TabIndex = 3;
            tipoComidaLabel.Text = "tipo Comida:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(9, 109);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 5;
            precioLabel.Text = "precio:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(9, 135);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "descripcion:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(9, 161);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(36, 13);
            costoLabel.TabIndex = 9;
            costoLabel.Text = "costo:";
            // 
            // restosoftDataSetModificarPorductos
            // 
            this.restosoftDataSetModificarPorductos.DataSetName = "RestosoftDataSetModificarPorductos";
            this.restosoftDataSetModificarPorductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.restosoftDataSetModificarPorductos;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.productoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.RestosoftDataSetModificarPorductosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = null;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.productoBindingNavigatorSaveItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(300, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
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
            // productoBindingNavigatorSaveItem
            // 
            this.productoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productoBindingNavigatorSaveItem.Image")));
            this.productoBindingNavigatorSaveItem.Name = "productoBindingNavigatorSaveItem";
            this.productoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productoBindingNavigatorSaveItem.Text = "Save Data";
            this.productoBindingNavigatorSaveItem.Click += new System.EventHandler(this.productoBindingNavigatorSaveItem_Click);
            // 
            // nombreproductoTextBox
            // 
            this.nombreproductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "nombreproducto", true));
            this.nombreproductoTextBox.Location = new System.Drawing.Point(102, 54);
            this.nombreproductoTextBox.Name = "nombreproductoTextBox";
            this.nombreproductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreproductoTextBox.TabIndex = 2;
            // 
            // tipoComidaTextBox
            // 
            this.tipoComidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "tipoComida", true));
            this.tipoComidaTextBox.Location = new System.Drawing.Point(102, 80);
            this.tipoComidaTextBox.Name = "tipoComidaTextBox";
            this.tipoComidaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoComidaTextBox.TabIndex = 4;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(102, 106);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 6;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(102, 132);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 8;
            // 
            // costoTextBox
            // 
            this.costoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "costo", true));
            this.costoTextBox.Location = new System.Drawing.Point(102, 158);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoTextBox.TabIndex = 10;
            // 
            // FrmNuevoPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 262);
            this.Controls.Add(nombreproductoLabel);
            this.Controls.Add(this.nombreproductoTextBox);
            this.Controls.Add(tipoComidaLabel);
            this.Controls.Add(this.tipoComidaTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.productoBindingNavigator);
            this.Name = "FrmNuevoPlatillo";
            this.Text = "Nuevo Platillo";
            this.Load += new System.EventHandler(this.FrmNuevoPlatillo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetModificarPorductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestosoftDataSetModificarPorductos restosoftDataSetModificarPorductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private RestosoftDataSetModificarPorductosTableAdapters.productoTableAdapter productoTableAdapter;
        private RestosoftDataSetModificarPorductosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreproductoTextBox;
        private System.Windows.Forms.TextBox tipoComidaTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
    }
}