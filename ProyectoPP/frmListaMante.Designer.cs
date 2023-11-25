namespace ProyectoPP
{
    partial class frmListaMante
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
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.ctrMantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrMantenimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.AllowUserToAddRows = false;
            this.dgvMantenimiento.AllowUserToDeleteRows = false;
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimiento.Location = new System.Drawing.Point(12, 62);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.ReadOnly = true;
            this.dgvMantenimiento.Size = new System.Drawing.Size(776, 306);
            this.dgvMantenimiento.TabIndex = 0;
            this.dgvMantenimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de mantenimientos";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(761, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 21);
            this.button4.TabIndex = 15;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ctrMantenimientoBindingSource
            // 
            this.ctrMantenimientoBindingSource.DataSource = typeof(Controller.ctrMantenimiento);
            // 
            // frmListaMante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMantenimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaMante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepuestosUt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrMantenimientoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource ctrMantenimientoBindingSource;
    }
}