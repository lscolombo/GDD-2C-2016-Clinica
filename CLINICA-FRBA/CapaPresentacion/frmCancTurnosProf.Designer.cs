namespace CapaPresentacion
{
    partial class frmCancTurnosProf
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dTimeFechaFin = new System.Windows.Forms.DateTimePicker();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTurnosPendientes = new System.Windows.Forms.DataGridView();
            this.txtMotivoCancelacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTurnos = new System.Windows.Forms.Button();
            this.btnCancelarTurnos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.labelHasta);
            this.groupBox1.Controls.Add(this.labelDesde);
            this.groupBox1.Controls.Add(this.dTimeFechaFin);
            this.groupBox1.Controls.Add(this.dTimeFechaInicio);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de fechas";
            // 
            // dTimeFechaInicio
            // 
            this.dTimeFechaInicio.Location = new System.Drawing.Point(53, 42);
            this.dTimeFechaInicio.Name = "dTimeFechaInicio";
            this.dTimeFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dTimeFechaInicio.TabIndex = 0;
            // 
            // dTimeFechaFin
            // 
            this.dTimeFechaFin.Location = new System.Drawing.Point(53, 80);
            this.dTimeFechaFin.Name = "dTimeFechaFin";
            this.dTimeFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dTimeFechaFin.TabIndex = 1;
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(6, 48);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(41, 13);
            this.labelDesde.TabIndex = 2;
            this.labelDesde.Text = "Desde:";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(6, 86);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(38, 13);
            this.labelHasta.TabIndex = 3;
            this.labelHasta.Text = "Hasta:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Cancelar turnos de un sólo día";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTurnosPendientes);
            this.groupBox2.Location = new System.Drawing.Point(13, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos pendientes";
            // 
            // dgvTurnosPendientes
            // 
            this.dgvTurnosPendientes.AllowUserToAddRows = false;
            this.dgvTurnosPendientes.AllowUserToDeleteRows = false;
            this.dgvTurnosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosPendientes.Location = new System.Drawing.Point(6, 20);
            this.dgvTurnosPendientes.Name = "dgvTurnosPendientes";
            this.dgvTurnosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosPendientes.Size = new System.Drawing.Size(428, 174);
            this.dgvTurnosPendientes.TabIndex = 0;
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(151, 137);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(286, 20);
            this.txtMotivoCancelacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Motivo de la cancelación:";
            // 
            // btnMostrarTurnos
            // 
            this.btnMostrarTurnos.Location = new System.Drawing.Point(323, 36);
            this.btnMostrarTurnos.Name = "btnMostrarTurnos";
            this.btnMostrarTurnos.Size = new System.Drawing.Size(75, 62);
            this.btnMostrarTurnos.TabIndex = 4;
            this.btnMostrarTurnos.Text = "Mostrar turnos pendientes";
            this.btnMostrarTurnos.UseVisualStyleBackColor = true;
            this.btnMostrarTurnos.Click += new System.EventHandler(this.btnMostrarTurnos_Click);
            // 
            // btnCancelarTurnos
            // 
            this.btnCancelarTurnos.Location = new System.Drawing.Point(139, 396);
            this.btnCancelarTurnos.Name = "btnCancelarTurnos";
            this.btnCancelarTurnos.Size = new System.Drawing.Size(169, 23);
            this.btnCancelarTurnos.TabIndex = 5;
            this.btnCancelarTurnos.Text = "Cancelar turnos";
            this.btnCancelarTurnos.UseVisualStyleBackColor = true;
            this.btnCancelarTurnos.Click += new System.EventHandler(this.btnCancelarTurnos_Click);
            // 
            // frmCancTurnosProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 431);
            this.Controls.Add(this.btnCancelarTurnos);
            this.Controls.Add(this.btnMostrarTurnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivoCancelacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCancTurnosProf";
            this.Text = "frmCancAtencionProf";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.DateTimePicker dTimeFechaFin;
        private System.Windows.Forms.DateTimePicker dTimeFechaInicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTurnosPendientes;
        private System.Windows.Forms.TextBox txtMotivoCancelacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTurnos;
        private System.Windows.Forms.Button btnCancelarTurnos;
    }
}