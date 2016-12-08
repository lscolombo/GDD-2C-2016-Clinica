namespace CapaPresentacion
{
    partial class frmHistorialCambioPlan
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.grpNomApell = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtIdAfiliado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.grpNomApell.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 171);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(524, 214);
            this.dgvListado.TabIndex = 17;
            // 
            // grpNomApell
            // 
            this.grpNomApell.Controls.Add(this.txtNombre);
            this.grpNomApell.Controls.Add(this.txtApellido);
            this.grpNomApell.Controls.Add(this.label2);
            this.grpNomApell.Controls.Add(this.label1);
            this.grpNomApell.Location = new System.Drawing.Point(9, 53);
            this.grpNomApell.Name = "grpNomApell";
            this.grpNomApell.Size = new System.Drawing.Size(261, 88);
            this.grpNomApell.TabIndex = 16;
            this.grpNomApell.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(79, 16);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(441, 130);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtIdAfiliado
            // 
            this.txtIdAfiliado.Location = new System.Drawing.Point(88, 24);
            this.txtIdAfiliado.MaxLength = 10;
            this.txtIdAfiliado.Name = "txtIdAfiliado";
            this.txtIdAfiliado.Size = new System.Drawing.Size(165, 20);
            this.txtIdAfiliado.TabIndex = 6;
            this.txtIdAfiliado.TextChanged += new System.EventHandler(this.txtIdAfiliado_TextChanged);
            this.txtIdAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdAfiliado_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdAfiliado);
            this.groupBox2.Controls.Add(this.grpNomApell);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 153);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro de Afiliado";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(315, 130);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 23);
            this.btnFiltrar.TabIndex = 17;
            this.btnFiltrar.Text = "Filtrar por datos";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(315, 65);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(125, 23);
            this.btnMostrarTodo.TabIndex = 18;
            this.btnMostrarTodo.Text = "Mostrar todo el Historial";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // frmHistorialCambioPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 396);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "frmHistorialCambioPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Cambio de Planes Medicos";
            this.Load += new System.EventHandler(this.frmHistorialCambioPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.grpNomApell.ResumeLayout(false);
            this.grpNomApell.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.GroupBox grpNomApell;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtIdAfiliado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}