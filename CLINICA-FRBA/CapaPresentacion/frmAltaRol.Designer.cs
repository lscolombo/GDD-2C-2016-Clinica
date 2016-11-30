namespace CapaPresentacion
{
    partial class frmAltaRol
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
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.funcionalidades = new System.Windows.Forms.ComboBox();
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreRol
            // 
            this.nombreRol.Location = new System.Drawing.Point(16, 44);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(288, 20);
            this.nombreRol.TabIndex = 1;
            this.nombreRol.TextChanged += new System.EventHandler(this.nombreRol_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidades";
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(16, 91);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(75, 23);
            this.btnCrearRol.TabIndex = 3;
            this.btnCrearRol.Text = "Crear";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // funcionalidades
            // 
            this.funcionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcionalidades.Enabled = false;
            this.funcionalidades.FormattingEnabled = true;
            this.funcionalidades.Location = new System.Drawing.Point(16, 177);
            this.funcionalidades.Name = "funcionalidades";
            this.funcionalidades.Size = new System.Drawing.Size(288, 21);
            this.funcionalidades.TabIndex = 4;
            this.funcionalidades.SelectedIndexChanged += new System.EventHandler(this.funcionalidades_SelectedIndexChanged);
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Enabled = false;
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(16, 229);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(140, 23);
            this.btnAgregarFuncionalidad.TabIndex = 5;
            this.btnAgregarFuncionalidad.Text = "Agregar Funcionalidad";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidad.Click += new System.EventHandler(this.btnAgregarFuncionalidad_Click);
            // 
            // frmAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 294);
            this.Controls.Add(this.btnAgregarFuncionalidad);
            this.Controls.Add(this.funcionalidades);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaRol";
            this.Text = "Alta de roles";
            this.Load += new System.EventHandler(this.frmAltaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.ComboBox funcionalidades;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
    }
}