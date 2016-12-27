namespace CapaPresentacion
{
    partial class frmAgendaProfLV
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbEspecialidadL = new System.Windows.Forms.ComboBox();
            this.grpRangoL = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbRangoFinL = new System.Windows.Forms.ComboBox();
            this.cbbRangoIniL = new System.Windows.Forms.ComboBox();
            this.btnAddEspecialidad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpRangoL.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(1, 182);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 8;
            this.txtMatricula.Text = "prof_Matricula";
            this.txtMatricula.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbEspecialidadL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 47);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialidad";
            // 
            // cbbEspecialidadL
            // 
            this.cbbEspecialidadL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEspecialidadL.FormattingEnabled = true;
            this.cbbEspecialidadL.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbbEspecialidadL.Location = new System.Drawing.Point(6, 19);
            this.cbbEspecialidadL.Name = "cbbEspecialidadL";
            this.cbbEspecialidadL.Size = new System.Drawing.Size(121, 21);
            this.cbbEspecialidadL.TabIndex = 10;
            // 
            // grpRangoL
            // 
            this.grpRangoL.Controls.Add(this.label5);
            this.grpRangoL.Controls.Add(this.label4);
            this.grpRangoL.Controls.Add(this.cbbRangoFinL);
            this.grpRangoL.Controls.Add(this.cbbRangoIniL);
            this.grpRangoL.Location = new System.Drawing.Point(18, 76);
            this.grpRangoL.Name = "grpRangoL";
            this.grpRangoL.Size = new System.Drawing.Size(109, 77);
            this.grpRangoL.TabIndex = 18;
            this.grpRangoL.TabStop = false;
            this.grpRangoL.Text = "Rango Horario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Inicio";
            // 
            // cbbRangoFinL
            // 
            this.cbbRangoFinL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRangoFinL.FormattingEnabled = true;
            this.cbbRangoFinL.Location = new System.Drawing.Point(44, 46);
            this.cbbRangoFinL.Name = "cbbRangoFinL";
            this.cbbRangoFinL.Size = new System.Drawing.Size(55, 21);
            this.cbbRangoFinL.TabIndex = 15;
            this.cbbRangoFinL.SelectionChangeCommitted += new System.EventHandler(this.cbbRangoFinL_SelectionChangeCommitted);
            // 
            // cbbRangoIniL
            // 
            this.cbbRangoIniL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRangoIniL.FormattingEnabled = true;
            this.cbbRangoIniL.Location = new System.Drawing.Point(44, 19);
            this.cbbRangoIniL.Name = "cbbRangoIniL";
            this.cbbRangoIniL.Size = new System.Drawing.Size(55, 21);
            this.cbbRangoIniL.TabIndex = 15;
            this.cbbRangoIniL.SelectionChangeCommitted += new System.EventHandler(this.cbbRangoIniL_SelectionChangeCommitted);
            // 
            // btnAddEspecialidad
            // 
            this.btnAddEspecialidad.Enabled = false;
            this.btnAddEspecialidad.Location = new System.Drawing.Point(42, 169);
            this.btnAddEspecialidad.Name = "btnAddEspecialidad";
            this.btnAddEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnAddEspecialidad.TabIndex = 20;
            this.btnAddEspecialidad.Text = "Agregar";
            this.btnAddEspecialidad.UseVisualStyleBackColor = true;
            this.btnAddEspecialidad.Click += new System.EventHandler(this.btnAddEspecialidad_Click);
            // 
            // frmAgendaProfLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 201);
            this.Controls.Add(this.btnAddEspecialidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRangoL);
            this.Controls.Add(this.txtMatricula);
            this.Name = "frmAgendaProfLV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAgendaProfLV_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpRangoL.ResumeLayout(false);
            this.grpRangoL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbEspecialidadL;
        private System.Windows.Forms.GroupBox grpRangoL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddEspecialidad;
        public System.Windows.Forms.ComboBox cbbRangoFinL;
        public System.Windows.Forms.ComboBox cbbRangoIniL;
    }
}