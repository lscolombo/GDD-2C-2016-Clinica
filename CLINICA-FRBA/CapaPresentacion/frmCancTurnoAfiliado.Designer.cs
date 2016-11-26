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
            this.dTTurnosDisponibles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dTTurnosDisponibles)).BeginInit();
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
            this.btnCancelarTurno.Location = new System.Drawing.Point(199, 205);
            this.btnCancelarTurno.Name = "btnCancelarTurno";
            this.btnCancelarTurno.Size = new System.Drawing.Size(118, 23);
            this.btnCancelarTurno.TabIndex = 2;
            this.btnCancelarTurno.Text = "Cancelar Turno";
            this.btnCancelarTurno.UseVisualStyleBackColor = true;
            // 
            // dTTurnosDisponibles
            // 
            this.dTTurnosDisponibles.AllowUserToAddRows = false;
            this.dTTurnosDisponibles.AllowUserToDeleteRows = false;
            this.dTTurnosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTTurnosDisponibles.Location = new System.Drawing.Point(15, 40);
            this.dTTurnosDisponibles.Name = "dTTurnosDisponibles";
            this.dTTurnosDisponibles.ReadOnly = true;
            this.dTTurnosDisponibles.Size = new System.Drawing.Size(472, 150);
            this.dTTurnosDisponibles.TabIndex = 3;
            this.dTTurnosDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmCancTurnoAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 240);
            this.Controls.Add(this.dTTurnosDisponibles);
            this.Controls.Add(this.btnCancelarTurno);
            this.Controls.Add(this.label1);
            this.Name = "frmCancTurnoAfiliado";
            this.Text = "Cancelación de turnos";
            this.Load += new System.EventHandler(this.frmCancTurnoAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTTurnosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarTurno;
        private System.Windows.Forms.DataGridView dTTurnosDisponibles;
    }
}