namespace RestoSoft
{
    partial class FrmBajaCliente
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
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label visitasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaCliente));
            this.dataSetClientes = new RestoSoft.DataSetClientes();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new RestoSoft.DataSetClientesTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new RestoSoft.DataSetClientesTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.visitasTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            nombreClienteLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            visitasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.BackColor = System.Drawing.Color.Transparent;
            nombreClienteLabel.Location = new System.Drawing.Point(188, 175);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(82, 13);
            nombreClienteLabel.TabIndex = 8;
            nombreClienteLabel.Text = "Nombre Cliente:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel.Location = new System.Drawing.Point(188, 201);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // visitasLabel
            // 
            visitasLabel.AutoSize = true;
            visitasLabel.BackColor = System.Drawing.Color.Transparent;
            visitasLabel.Location = new System.Drawing.Point(188, 227);
            visitasLabel.Name = "visitasLabel";
            visitasLabel.Size = new System.Drawing.Size(40, 13);
            visitasLabel.TabIndex = 12;
            visitasLabel.Text = "Visitas:";
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = RestoSoft.DataSetClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 399);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.telefonoTextBox.Enabled = false;
            this.telefonoTextBox.Location = new System.Drawing.Point(274, 198);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // visitasTextBox
            // 
            this.visitasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "visitas", true));
            this.visitasTextBox.Enabled = false;
            this.visitasTextBox.Location = new System.Drawing.Point(274, 224);
            this.visitasTextBox.Name = "visitasTextBox";
            this.visitasTextBox.Size = new System.Drawing.Size(100, 20);
            this.visitasTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.dataSetClientes;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "clientes";
            this.clientesBindingSource2.DataSource = this.dataSetClientes;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientesBindingSource3;
            this.comboBox1.DisplayMember = "nombreCliente";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "nombreCliente";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataMember = "clientes";
            this.clientesBindingSource3.DataSource = this.dataSetClientes;
            // 
            // FrmBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 389);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(visitasLabel);
            this.Controls.Add(this.visitasTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmBajaCliente";
            this.Text = "Baja Cliente";
            this.Load += new System.EventHandler(this.FrmBajaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetClientes dataSetClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private DataSetClientesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox visitasTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
    }
}