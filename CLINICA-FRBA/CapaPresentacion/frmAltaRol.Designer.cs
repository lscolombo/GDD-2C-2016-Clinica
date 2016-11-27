﻿namespace CapaPresentacion
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
            this.funcionalidades = new System.Windows.Forms.ComboBox();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // funcionalidades
            // 
            this.funcionalidades.BackColor = System.Drawing.SystemColors.Window;
            this.funcionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcionalidades.Enabled = false;
            this.funcionalidades.FormattingEnabled = true;
            this.funcionalidades.Items.AddRange(new object[] {
            "ABM Rol",
            "ABM Afiliado",
            "Compra de bonos",
            "Listado estadístico",
            "Pedir turno",
            "Registro agenda",
            "Registra de llegada para atención médico",
            "Registro de resultado para atención médica"});
            this.funcionalidades.Location = new System.Drawing.Point(12, 154);
            this.funcionalidades.Name = "funcionalidades";
            this.funcionalidades.Size = new System.Drawing.Size(301, 21);
            this.funcionalidades.TabIndex = 31;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(12, 79);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(93, 23);
            this.btnCrearRol.TabIndex = 30;
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Funcionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre";
            // 
            // nombreRol
            // 
            this.nombreRol.Location = new System.Drawing.Point(12, 34);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(301, 20);
            this.nombreRol.TabIndex = 27;
            this.nombreRol.TextChanged += new System.EventHandler(this.nombreRol_TextChanged);
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Enabled = false;
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(12, 199);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(126, 23);
            this.btnAgregarFuncionalidad.TabIndex = 32;
            this.btnAgregarFuncionalidad.Text = "Agregar Funcionalidad";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            // 
            // frmAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 256);
            this.Controls.Add(this.btnAgregarFuncionalidad);
            this.Controls.Add(this.funcionalidades);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreRol);
            this.Name = "frmAltaRol";
            this.Text = "Alta de roles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox funcionalidades;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
    }
}