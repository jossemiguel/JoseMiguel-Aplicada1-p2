namespace JoseMiguel_Aplicada1_p2
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.fechatxt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.creditotxt = new System.Windows.Forms.TextBox();
            this.telefonotxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tipotxt = new System.Windows.Forms.ComboBox();
            this.parcial2DbDataSet = new JoseMiguel_Aplicada1_p2.Parcial2DbDataSet();
            this.tiposTelefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposTelefonosTableAdapter = new JoseMiguel_Aplicada1_p2.Parcial2DbDataSetTableAdapters.TiposTelefonosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parcial2DbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposTelefonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(122, 68);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(47, 20);
            this.idtxt.TabIndex = 4;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(122, 94);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(166, 20);
            this.nombretxt.TabIndex = 5;
            // 
            // fechatxt
            // 
            this.fechatxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechatxt.Location = new System.Drawing.Point(122, 120);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(166, 20);
            this.fechatxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Limte Credito";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // creditotxt
            // 
            this.creditotxt.Location = new System.Drawing.Point(122, 157);
            this.creditotxt.Name = "creditotxt";
            this.creditotxt.Size = new System.Drawing.Size(166, 20);
            this.creditotxt.TabIndex = 8;
            // 
            // telefonotxt
            // 
            this.telefonotxt.Location = new System.Drawing.Point(122, 212);
            this.telefonotxt.Name = "telefonotxt";
            this.telefonotxt.Size = new System.Drawing.Size(166, 20);
            this.telefonotxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo";
            // 
            // tipotxt
            // 
            this.tipotxt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tiposTelefonosBindingSource, "Descripcion", true));
            this.tipotxt.DataSource = this.tiposTelefonosBindingSource;
            this.tipotxt.DisplayMember = "Descripcion";
            this.tipotxt.FormattingEnabled = true;
            this.tipotxt.Location = new System.Drawing.Point(122, 183);
            this.tipotxt.Name = "tipotxt";
            this.tipotxt.Size = new System.Drawing.Size(166, 21);
            this.tipotxt.TabIndex = 12;
            this.tipotxt.ValueMember = "TiposId";
            // 
            // parcial2DbDataSet
            // 
            this.parcial2DbDataSet.DataSetName = "Parcial2DbDataSet";
            this.parcial2DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposTelefonosBindingSource
            // 
            this.tiposTelefonosBindingSource.DataMember = "TiposTelefonos";
            this.tiposTelefonosBindingSource.DataSource = this.parcial2DbDataSet;
            // 
            // tiposTelefonosTableAdapter
            // 
            this.tiposTelefonosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 433);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tipotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefonotxt);
            this.Controls.Add(this.creditotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechatxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcial2DbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposTelefonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.DateTimePicker fechatxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox creditotxt;
        private System.Windows.Forms.TextBox telefonotxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tipotxt;
        private Parcial2DbDataSet parcial2DbDataSet;
        private System.Windows.Forms.BindingSource tiposTelefonosBindingSource;
        private Parcial2DbDataSetTableAdapters.TiposTelefonosTableAdapter tiposTelefonosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

