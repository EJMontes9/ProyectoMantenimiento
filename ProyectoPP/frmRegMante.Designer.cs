namespace ProyectoPP
{
    partial class frmRegMante
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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMecanico = new System.Windows.Forms.ComboBox();
            this.mecanicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoTableAdapter = new ProyectoPP.ProyectoPPDataSet1TableAdapters.mantenimientoTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.rtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtTrabajos = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbRepuestos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mecanicosBindingSource)).BeginInit();
            this.gbVehiculo.SuspendLayout();
            this.gbRepuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar mantenimiento";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(89, 71);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(169, 25);
            this.cbCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(296, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mecanico:";
            // 
            // cbMecanico
            // 
            this.cbMecanico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMecanico.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMecanico.FormattingEnabled = true;
            this.cbMecanico.Location = new System.Drawing.Point(379, 71);
            this.cbMecanico.Name = "cbMecanico";
            this.cbMecanico.Size = new System.Drawing.Size(169, 25);
            this.cbMecanico.TabIndex = 10;
            // 
            // mantenimientoTableAdapter
            // 
            this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(521, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 21);
            this.button4.TabIndex = 12;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(89, 122);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(169, 24);
            this.dtpFecha.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha:";
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.Controls.Add(this.label8);
            this.gbVehiculo.Controls.Add(this.txtColor);
            this.gbVehiculo.Controls.Add(this.label7);
            this.gbVehiculo.Controls.Add(this.txtMarca);
            this.gbVehiculo.Controls.Add(this.label6);
            this.gbVehiculo.Controls.Add(this.txtModelo);
            this.gbVehiculo.Controls.Add(this.label5);
            this.gbVehiculo.Controls.Add(this.txtPlaca);
            this.gbVehiculo.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.gbVehiculo.ForeColor = System.Drawing.Color.White;
            this.gbVehiculo.Location = new System.Drawing.Point(16, 171);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(548, 138);
            this.gbVehiculo.TabIndex = 15;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(303, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(363, 76);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(169, 26);
            this.txtColor.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(303, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(363, 31);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(169, 26);
            this.txtMarca.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(7, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(73, 79);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(169, 26);
            this.txtModelo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(73, 31);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(169, 26);
            this.txtPlaca.TabIndex = 16;
            // 
            // rtDiagnostico
            // 
            this.rtDiagnostico.Location = new System.Drawing.Point(16, 352);
            this.rtDiagnostico.Name = "rtDiagnostico";
            this.rtDiagnostico.Size = new System.Drawing.Size(242, 96);
            this.rtDiagnostico.TabIndex = 16;
            this.rtDiagnostico.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Diagnostico:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(296, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Trabajos Realizados:";
            // 
            // rtTrabajos
            // 
            this.rtTrabajos.Location = new System.Drawing.Point(300, 352);
            this.rtTrabajos.Name = "rtTrabajos";
            this.rtTrabajos.Size = new System.Drawing.Size(248, 96);
            this.rtTrabajos.TabIndex = 18;
            this.rtTrabajos.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(296, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Correctivo",
            "Preventivo"});
            this.cbTipo.Location = new System.Drawing.Point(379, 121);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(169, 25);
            this.cbTipo.TabIndex = 21;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipoIndexChanged);
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Location = new System.Drawing.Point(89, 31);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.Size = new System.Drawing.Size(254, 26);
            this.txtRepuesto.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(7, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Repuesto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(430, 31);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(102, 26);
            this.txtPrecio.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(363, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Precio:";
            // 
            // gbRepuestos
            // 
            this.gbRepuestos.Controls.Add(this.label13);
            this.gbRepuestos.Controls.Add(this.txtPrecio);
            this.gbRepuestos.Controls.Add(this.label15);
            this.gbRepuestos.Controls.Add(this.txtRepuesto);
            this.gbRepuestos.Font = new System.Drawing.Font("Book Antiqua", 11.25F);
            this.gbRepuestos.ForeColor = System.Drawing.Color.White;
            this.gbRepuestos.Location = new System.Drawing.Point(12, 454);
            this.gbRepuestos.Name = "gbRepuestos";
            this.gbRepuestos.Size = new System.Drawing.Size(548, 85);
            this.gbRepuestos.TabIndex = 22;
            this.gbRepuestos.TabStop = false;
            this.gbRepuestos.Text = "Repuestos";
            this.gbRepuestos.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(417, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Violet;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(27, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "Historial";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRegMante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(570, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbRepuestos);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtTrabajos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtDiagnostico);
            this.Controls.Add(this.gbVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMecanico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegMante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegMante";
            ((System.ComponentModel.ISupportInitialize)(this.mecanicosBindingSource)).EndInit();
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            this.gbRepuestos.ResumeLayout(false);
            this.gbRepuestos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMecanico;
        private ProyectoPPDataSet1TableAdapters.mantenimientoTableAdapter mantenimientoTableAdapter;
        private System.Windows.Forms.BindingSource mecanicosBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.RichTextBox rtDiagnostico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtTrabajos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbRepuestos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}