namespace CapaPresentacion
{
    partial class frmEliminarRol
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
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.tablaDeRoles = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Enabled = false;
            this.btnEliminarRol.Location = new System.Drawing.Point(16, 150);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(146, 23);
            this.btnEliminarRol.TabIndex = 82;
            this.btnEliminarRol.Text = "Dar De Baja";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // tablaDeRoles
            // 
            this.tablaDeRoles.AllowUserToAddRows = false;
            this.tablaDeRoles.AllowUserToDeleteRows = false;
            this.tablaDeRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDeRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeRoles.Location = new System.Drawing.Point(355, 40);
            this.tablaDeRoles.MultiSelect = false;
            this.tablaDeRoles.Name = "tablaDeRoles";
            this.tablaDeRoles.ReadOnly = true;
            this.tablaDeRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDeRoles.Size = new System.Drawing.Size(469, 404);
            this.tablaDeRoles.TabIndex = 81;
            this.tablaDeRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeRoles_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Roles: Seleccione el rol que sea eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Id";
            // 
            // idRol
            // 
            this.idRol.Enabled = false;
            this.idRol.Location = new System.Drawing.Point(16, 40);
            this.idRol.Name = "idRol";
            this.idRol.Size = new System.Drawing.Size(124, 20);
            this.idRol.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nombre";
            // 
            // nombreRol
            // 
            this.nombreRol.Enabled = false;
            this.nombreRol.Location = new System.Drawing.Point(16, 101);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(301, 20);
            this.nombreRol.TabIndex = 76;
            // 
            // frmEliminarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 456);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.tablaDeRoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreRol);
            this.Name = "frmEliminarRol";
            this.Text = "Baja de roles";
            this.Load += new System.EventHandler(this.frmEliminarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.DataGridView tablaDeRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreRol;
    }
}