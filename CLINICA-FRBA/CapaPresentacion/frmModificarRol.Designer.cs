namespace CapaPresentacion
{
    partial class frmModificarRol
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
            this.tablaDeRoles = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnCambiarNombre = new System.Windows.Forms.Button();
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.btnEliminarFuncionalidad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idRol = new System.Windows.Forms.TextBox();
            this.habilitado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.funcionalidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeRoles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaDeRoles
            // 
            this.tablaDeRoles.AllowUserToAddRows = false;
            this.tablaDeRoles.AllowUserToDeleteRows = false;
            this.tablaDeRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDeRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeRoles.Location = new System.Drawing.Point(356, 43);
            this.tablaDeRoles.MultiSelect = false;
            this.tablaDeRoles.Name = "tablaDeRoles";
            this.tablaDeRoles.ReadOnly = true;
            this.tablaDeRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDeRoles.Size = new System.Drawing.Size(469, 404);
            this.tablaDeRoles.TabIndex = 74;
            this.tablaDeRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeRoles_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(10, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 52);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirme la acción seleccionada";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(9, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(103, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHabilitar);
            this.groupBox1.Controls.Add(this.btnCambiarNombre);
            this.groupBox1.Controls.Add(this.btnAgregarFuncionalidad);
            this.groupBox1.Controls.Add(this.btnEliminarFuncionalidad);
            this.groupBox1.Location = new System.Drawing.Point(10, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 106);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la acción de modificación deseada";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Enabled = false;
            this.btnHabilitar.Location = new System.Drawing.Point(25, 64);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(133, 23);
            this.btnHabilitar.TabIndex = 46;
            this.btnHabilitar.Text = "Editar Estado Habilitado";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnCambiarNombre
            // 
            this.btnCambiarNombre.Enabled = false;
            this.btnCambiarNombre.Location = new System.Drawing.Point(25, 19);
            this.btnCambiarNombre.Name = "btnCambiarNombre";
            this.btnCambiarNombre.Size = new System.Drawing.Size(133, 23);
            this.btnCambiarNombre.TabIndex = 45;
            this.btnCambiarNombre.Text = "Cambiar Nombre";
            this.btnCambiarNombre.UseVisualStyleBackColor = true;
            this.btnCambiarNombre.Click += new System.EventHandler(this.btnCambiarNombre_Click);
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Enabled = false;
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(187, 19);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(122, 23);
            this.btnAgregarFuncionalidad.TabIndex = 43;
            this.btnAgregarFuncionalidad.Text = "Agregar Funcionalidad";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidad.Click += new System.EventHandler(this.btnAgregarFuncionalidad_Click);
            // 
            // btnEliminarFuncionalidad
            // 
            this.btnEliminarFuncionalidad.Enabled = false;
            this.btnEliminarFuncionalidad.Location = new System.Drawing.Point(187, 64);
            this.btnEliminarFuncionalidad.Name = "btnEliminarFuncionalidad";
            this.btnEliminarFuncionalidad.Size = new System.Drawing.Size(120, 23);
            this.btnEliminarFuncionalidad.TabIndex = 44;
            this.btnEliminarFuncionalidad.Text = "Eliminar Funcionalidad";
            this.btnEliminarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnEliminarFuncionalidad.Click += new System.EventHandler(this.btnEliminarFuncionalidad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Roles: Seleccione el rol que sea modificar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Id";
            // 
            // idRol
            // 
            this.idRol.Enabled = false;
            this.idRol.Location = new System.Drawing.Point(17, 43);
            this.idRol.Name = "idRol";
            this.idRol.Size = new System.Drawing.Size(124, 20);
            this.idRol.TabIndex = 69;
            // 
            // habilitado
            // 
            this.habilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.habilitado.Enabled = false;
            this.habilitado.FormattingEnabled = true;
            this.habilitado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.habilitado.Location = new System.Drawing.Point(197, 43);
            this.habilitado.Name = "habilitado";
            this.habilitado.Size = new System.Drawing.Size(121, 21);
            this.habilitado.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Habilitado";
            // 
            // funcionalidades
            // 
            this.funcionalidades.BackColor = System.Drawing.SystemColors.Window;
            this.funcionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcionalidades.Enabled = false;
            this.funcionalidades.FormattingEnabled = true;
            this.funcionalidades.Location = new System.Drawing.Point(17, 164);
            this.funcionalidades.Name = "funcionalidades";
            this.funcionalidades.Size = new System.Drawing.Size(301, 21);
            this.funcionalidades.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Funcionalidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nombre";
            // 
            // nombreRol
            // 
            this.nombreRol.Enabled = false;
            this.nombreRol.Location = new System.Drawing.Point(17, 104);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(301, 20);
            this.nombreRol.TabIndex = 63;
            // 
            // frmModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 463);
            this.Controls.Add(this.tablaDeRoles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idRol);
            this.Controls.Add(this.habilitado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.funcionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreRol);
            this.Name = "frmModificarRol";
            this.Text = "Modificacion de roles";
            this.Load += new System.EventHandler(this.frmModificarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeRoles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDeRoles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnCambiarNombre;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
        private System.Windows.Forms.Button btnEliminarFuncionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idRol;
        private System.Windows.Forms.ComboBox habilitado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox funcionalidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreRol;

    }
}