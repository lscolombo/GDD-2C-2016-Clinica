namespace CapaPresentacion
{
    partial class frmCancTurnoAfiliado
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarTurno = new System.Windows.Forms.Button();
            this.dgvTurnosDisponibles = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTurnoSeleccionado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "t";
            this.label1.Text = "Turnos disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelarTurno
            // 
            this.btnCancelarTurno.Location = new System.Drawing.Point(369, 225);
            this.btnCancelarTurno.Name = "btnCancelarTurno";
            this.btnCancelarTurno.Size = new System.Drawing.Size(118, 23);
            this.btnCancelarTurno.TabIndex = 2;
            this.btnCancelarTurno.Text = "Cancelar Turno";
            this.btnCancelarTurno.UseVisualStyleBackColor = true;
            this.btnCancelarTurno.Click += new System.EventHandler(this.btnCancelarTurno_Click);
            // 
            // dgvTurnosDisponibles
            // 
            this.dgvTurnosDisponibles.AllowUserToAddRows = false;
            this.dgvTurnosDisponibles.AllowUserToDeleteRows = false;
            this.dgvTurnosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosDisponibles.Location = new System.Drawing.Point(15, 40);
            this.dgvTurnosDisponibles.Name = "dgvTurnosDisponibles";
            this.dgvTurnosDisponibles.ReadOnly = true;
            this.dgvTurnosDisponibles.Size = new System.Drawing.Size(472, 150);
            this.dgvTurnosDisponibles.TabIndex = 3;
            this.dgvTurnosDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnosDisponibles_CellClick);
            this.dgvTurnosDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnosDisponibles_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motivo de la cancelación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turno seleccionado:";
            // 
            // txtTurnoSeleccionado
            // 
            this.txtTurnoSeleccionado.Location = new System.Drawing.Point(15, 214);
            this.txtTurnoSeleccionado.Name = "txtTurnoSeleccionado";
            this.txtTurnoSeleccionado.Size = new System.Drawing.Size(100, 20);
            this.txtTurnoSeleccionado.TabIndex = 7;
            // 
            // frmCancTurnoAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 294);
            this.Controls.Add(this.txtTurnoSeleccionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvTurnosDisponibles);
            this.Controls.Add(this.btnCancelarTurno);
            this.Controls.Add(this.label1);
            this.Name = "frmCancTurnoAfiliado";
            this.Text = "Cancelación de turnos";
            this.Load += new System.EventHandler(this.frmCancTurnoAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarTurno;
        private System.Windows.Forms.DataGridView dgvTurnosDisponibles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTurnoSeleccionado;
    }
}