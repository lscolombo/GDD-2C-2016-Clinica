namespace CapaPresentacion
{
    partial class frmEstadisticas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvResultadosEstadisticas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSegundoSemestre = new System.Windows.Forms.RadioButton();
            this.rbPrimerSemestre = new System.Windows.Forms.RadioButton();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.chkMes = new System.Windows.Forms.CheckBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbTipoListado = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.rbMedico = new System.Windows.Forms.RadioButton();
            this.chkTipoCancelacion = new System.Windows.Forms.CheckBox();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.chkEspecialidad = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosEstadisticas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado estadístico:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvResultadosEstadisticas);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // dgvResultadosEstadisticas
            // 
            this.dgvResultadosEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosEstadisticas.Location = new System.Drawing.Point(6, 19);
            this.dgvResultadosEstadisticas.Name = "dgvResultadosEstadisticas";
            this.dgvResultadosEstadisticas.Size = new System.Drawing.Size(647, 181);
            this.dgvResultadosEstadisticas.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSegundoSemestre);
            this.groupBox2.Controls.Add(this.rbPrimerSemestre);
            this.groupBox2.Location = new System.Drawing.Point(16, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 77);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Semestre";
            this.groupBox2.Enter += new System.EventHandler(this.frmEstadisticas_Load);
            // 
            // rbSegundoSemestre
            // 
            this.rbSegundoSemestre.AutoSize = true;
            this.rbSegundoSemestre.Location = new System.Drawing.Point(6, 42);
            this.rbSegundoSemestre.Name = "rbSegundoSemestre";
            this.rbSegundoSemestre.Size = new System.Drawing.Size(113, 17);
            this.rbSegundoSemestre.TabIndex = 1;
            this.rbSegundoSemestre.TabStop = true;
            this.rbSegundoSemestre.Text = "Segundo semestre";
            this.rbSegundoSemestre.UseVisualStyleBackColor = true;
            this.rbSegundoSemestre.CheckedChanged += new System.EventHandler(this.rbSegundoSemestre_CheckedChanged);
            // 
            // rbPrimerSemestre
            // 
            this.rbPrimerSemestre.AutoSize = true;
            this.rbPrimerSemestre.Location = new System.Drawing.Point(6, 19);
            this.rbPrimerSemestre.Name = "rbPrimerSemestre";
            this.rbPrimerSemestre.Size = new System.Drawing.Size(99, 17);
            this.rbPrimerSemestre.TabIndex = 0;
            this.rbPrimerSemestre.TabStop = true;
            this.rbPrimerSemestre.Text = "Primer semestre";
            this.rbPrimerSemestre.UseVisualStyleBackColor = true;
            this.rbPrimerSemestre.CheckedChanged += new System.EventHandler(this.rbPrimerSemestre_CheckedChanged);
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(48, 12);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbAnio.TabIndex = 5;
            // 
            // chkMes
            // 
            this.chkMes.AutoSize = true;
            this.chkMes.Location = new System.Drawing.Point(16, 133);
            this.chkMes.Name = "chkMes";
            this.chkMes.Size = new System.Drawing.Size(167, 17);
            this.chkMes.TabIndex = 6;
            this.chkMes.Text = "Filtrar por un mes en particular";
            this.chkMes.UseVisualStyleBackColor = true;
            this.chkMes.CheckedChanged += new System.EventHandler(this.chkMes_CheckedChanged);
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(48, 164);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 7;
            // 
            // cmbTipoListado
            // 
            this.cmbTipoListado.FormattingEnabled = true;
            this.cmbTipoListado.Location = new System.Drawing.Point(319, 12);
            this.cmbTipoListado.Name = "cmbTipoListado";
            this.cmbTipoListado.Size = new System.Drawing.Size(352, 21);
            this.cmbTipoListado.TabIndex = 8;
            this.cmbTipoListado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoListado_SelectedIndexChanged);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(290, 111);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(185, 21);
            this.cmbEspecialidad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Especialidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPaciente);
            this.groupBox3.Controls.Add(this.rbMedico);
            this.groupBox3.Location = new System.Drawing.Point(388, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 51);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cancelaciones por parte de:";
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.Location = new System.Drawing.Point(79, 20);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(67, 17);
            this.rbPaciente.TabIndex = 1;
            this.rbPaciente.TabStop = true;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = true;
            this.rbPaciente.CheckedChanged += new System.EventHandler(this.rbPaciente_CheckedChanged);
            // 
            // rbMedico
            // 
            this.rbMedico.AutoSize = true;
            this.rbMedico.Location = new System.Drawing.Point(7, 20);
            this.rbMedico.Name = "rbMedico";
            this.rbMedico.Size = new System.Drawing.Size(60, 17);
            this.rbMedico.TabIndex = 0;
            this.rbMedico.TabStop = true;
            this.rbMedico.Text = "Médico";
            this.rbMedico.UseVisualStyleBackColor = true;
            this.rbMedico.CheckedChanged += new System.EventHandler(this.rbMedico_CheckedChanged);
            // 
            // chkTipoCancelacion
            // 
            this.chkTipoCancelacion.AutoSize = true;
            this.chkTipoCancelacion.Location = new System.Drawing.Point(217, 39);
            this.chkTipoCancelacion.Name = "chkTipoCancelacion";
            this.chkTipoCancelacion.Size = new System.Drawing.Size(165, 17);
            this.chkTipoCancelacion.TabIndex = 12;
            this.chkTipoCancelacion.Text = "Filtrar por tipo de cancelación";
            this.chkTipoCancelacion.UseVisualStyleBackColor = true;
            this.chkTipoCancelacion.CheckedChanged += new System.EventHandler(this.chkTipoCancelacion_CheckedChanged);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.Location = new System.Drawing.Point(525, 92);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(109, 102);
            this.btnMostrarResultados.TabIndex = 13;
            this.btnMostrarResultados.Text = "Mostrar resultados";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // chkEspecialidad
            // 
            this.chkEspecialidad.AutoSize = true;
            this.chkEspecialidad.Location = new System.Drawing.Point(217, 92);
            this.chkEspecialidad.Name = "chkEspecialidad";
            this.chkEspecialidad.Size = new System.Drawing.Size(131, 17);
            this.chkEspecialidad.TabIndex = 14;
            this.chkEspecialidad.Text = "Filtrar por especialidad";
            this.chkEspecialidad.UseVisualStyleBackColor = true;
            this.chkEspecialidad.CheckedChanged += new System.EventHandler(this.chkEspecialidad_CheckedChanged);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 412);
            this.Controls.Add(this.chkEspecialidad);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.chkTipoCancelacion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.cmbTipoListado);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.chkMes);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadisticas";
            this.Text = "Listados estadísticos";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosEstadisticas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSegundoSemestre;
        private System.Windows.Forms.RadioButton rbPrimerSemestre;
        private System.Windows.Forms.DataGridView dgvResultadosEstadisticas;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.CheckBox chkMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbTipoListado;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.RadioButton rbMedico;
        private System.Windows.Forms.CheckBox chkTipoCancelacion;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.CheckBox chkEspecialidad;
    }
}