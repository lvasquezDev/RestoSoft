namespace RestoSoft
{
    partial class FrmNuevoServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoServicio));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSetMesas = new RestoSoft.DataSetMesas();
            this.mesaTableAdapter = new RestoSoft.DataSetMesasTableAdapters.mesaTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mesaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restosoftDataSetMesas = new RestoSoft.RestosoftDataSetMesas();
            this.mesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesaTableAdapter1 = new RestoSoft.RestosoftDataSetMesasTableAdapters.mesaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // dataSetMesas
            // 
            this.dataSetMesas.DataSetName = "DataSetMesas";
            this.dataSetMesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesaTableAdapter
            // 
            this.mesaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mesaBindingSource1, "numeroMesa", true));
            this.comboBox1.DataSource = this.mesaBindingSource;
            this.comboBox1.DisplayMember = "numeroMesa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "numeroMesa";
            // 
            // mesaBindingSource1
            // 
            this.mesaBindingSource1.DataMember = "mesa";
            this.mesaBindingSource1.DataSource = this.restosoftDataSetMesas;
            // 
            // restosoftDataSetMesas
            // 
            this.restosoftDataSetMesas.DataSetName = "RestosoftDataSetMesas";
            this.restosoftDataSetMesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesaBindingSource
            // 
            this.mesaBindingSource.DataMember = "mesa";
            this.mesaBindingSource.DataSource = this.restosoftDataSetMesas;
            // 
            // mesaTableAdapter1
            // 
            this.mesaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmNuevoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FrmNuevoServicio";
            this.Text = "Nuevo Servicio";
            this.Load += new System.EventHandler(this.FrmNuevoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restosoftDataSetMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataSetMesas dataSetMesas;
        private DataSetMesasTableAdapters.mesaTableAdapter mesaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private RestosoftDataSetMesas restosoftDataSetMesas;
        private System.Windows.Forms.BindingSource mesaBindingSource;
        private RestosoftDataSetMesasTableAdapters.mesaTableAdapter mesaTableAdapter1;
        private System.Windows.Forms.BindingSource mesaBindingSource1;
    }
}