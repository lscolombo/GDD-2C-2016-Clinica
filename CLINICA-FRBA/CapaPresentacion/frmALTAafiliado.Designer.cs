namespace CapaPresentacion
{
    partial class frmALTAafiliado
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumDni = new System.Windows.Forms.TextBox();
            this.cbbTipoDni = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtCantHijos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumAfiliado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNroRaiz = new System.Windows.Forms.TextBox();
            this.cbbPlanMedico = new System.Windows.Forms.ComboBox();
            this.btnPareja = new System.Windows.Forms.Button();
            this.btnHijo = new System.Windows.Forms.Button();
            this.grpAsociar = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnInsertAlta = new System.Windows.Forms.Button();
            this.btnNuevaAlta = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpAsociar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(91, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(145, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(90, 125);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(146, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumDni);
            this.groupBox1.Controls.Add(this.cbbTipoDni);
            this.groupBox1.Location = new System.Drawing.Point(19, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo y Nº de documento";
            // 
            // txtNumDni
            // 
            this.txtNumDni.Location = new System.Drawing.Point(64, 20);
            this.txtNumDni.MaxLength = 8;
            this.txtNumDni.Name = "txtNumDni";
            this.txtNumDni.Size = new System.Drawing.Size(100, 20);
            this.txtNumDni.TabIndex = 7;
            this.txtNumDni.TextChanged += new System.EventHandler(this.txtNumDni_TextChanged);
            this.txtNumDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDni_KeyPress);
            // 
            // cbbTipoDni
            // 
            this.cbbTipoDni.FormattingEnabled = true;
            this.cbbTipoDni.Items.AddRange(new object[] {
            "DNI",
            "Otro"});
            this.cbbTipoDni.Location = new System.Drawing.Point(6, 19);
            this.cbbTipoDni.Name = "cbbTipoDni";
            this.cbbTipoDni.Size = new System.Drawing.Size(53, 21);
            this.cbbTipoDni.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(90, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(91, 177);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(145, 20);
            this.txtMail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbbSexo.Location = new System.Drawing.Point(90, 229);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbbSexo.TabIndex = 12;
            this.cbbSexo.SelectedIndexChanged += new System.EventHandler(this.cbbSexo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sexo";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(141, 203);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaNacimiento.TabIndex = 14;
            this.dtpFechaNacimiento.Value = new System.DateTime(2016, 11, 22, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado Civil";
            // 
            // cbbEstadoCivil
            // 
            this.cbbEstadoCivil.FormattingEnabled = true;
            this.cbbEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.cbbEstadoCivil.Location = new System.Drawing.Point(91, 256);
            this.cbbEstadoCivil.Name = "cbbEstadoCivil";
            this.cbbEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cbbEstadoCivil.TabIndex = 15;
            this.cbbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtCantHijos
            // 
            this.txtCantHijos.Location = new System.Drawing.Point(104, 287);
            this.txtCantHijos.MaxLength = 3;
            this.txtCantHijos.Name = "txtCantHijos";
            this.txtCantHijos.Size = new System.Drawing.Size(48, 20);
            this.txtCantHijos.TabIndex = 18;
            this.txtCantHijos.TextChanged += new System.EventHandler(this.txtCantHijos_TextChanged);
            this.txtCantHijos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantHijos_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cant, de hijos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Plan Medico";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nro. de afiliados";
            // 
            // txtNumAfiliado
            // 
            this.txtNumAfiliado.Location = new System.Drawing.Point(116, 340);
            this.txtNumAfiliado.Name = "txtNumAfiliado";
            this.txtNumAfiliado.ReadOnly = true;
            this.txtNumAfiliado.Size = new System.Drawing.Size(100, 20);
            this.txtNumAfiliado.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNroRaiz);
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 49);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nº Raiz";
            // 
            // txtNroRaiz
            // 
            this.txtNroRaiz.Location = new System.Drawing.Point(6, 19);
            this.txtNroRaiz.MaxLength = 8;
            this.txtNroRaiz.Name = "txtNroRaiz";
            this.txtNroRaiz.Size = new System.Drawing.Size(100, 20);
            this.txtNroRaiz.TabIndex = 7;
            // 
            // cbbPlanMedico
            // 
            this.cbbPlanMedico.FormattingEnabled = true;
            this.cbbPlanMedico.Items.AddRange(new object[] {
            "Plan Medico 110",
            "Plan Medico 120",
            "Plan Medico 130",
            "Plan Medico 140",
            "Plan Medico 150"});
            this.cbbPlanMedico.Location = new System.Drawing.Point(91, 313);
            this.cbbPlanMedico.Name = "cbbPlanMedico";
            this.cbbPlanMedico.Size = new System.Drawing.Size(121, 21);
            this.cbbPlanMedico.TabIndex = 23;
            // 
            // btnPareja
            // 
            this.btnPareja.Location = new System.Drawing.Point(22, 21);
            this.btnPareja.Name = "btnPareja";
            this.btnPareja.Size = new System.Drawing.Size(75, 23);
            this.btnPareja.TabIndex = 24;
            this.btnPareja.Text = "Pareja";
            this.btnPareja.UseVisualStyleBackColor = true;
            this.btnPareja.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHijo
            // 
            this.btnHijo.Enabled = false;
            this.btnHijo.Location = new System.Drawing.Point(22, 51);
            this.btnHijo.Name = "btnHijo";
            this.btnHijo.Size = new System.Drawing.Size(75, 23);
            this.btnHijo.TabIndex = 25;
            this.btnHijo.Text = "Hijo/a";
            this.btnHijo.UseVisualStyleBackColor = true;
            this.btnHijo.Click += new System.EventHandler(this.btnHijo_Click);
            // 
            // grpAsociar
            // 
            this.grpAsociar.Controls.Add(this.btnPareja);
            this.grpAsociar.Controls.Add(this.btnHijo);
            this.grpAsociar.Location = new System.Drawing.Point(293, 159);
            this.grpAsociar.Name = "grpAsociar";
            this.grpAsociar.Size = new System.Drawing.Size(123, 83);
            this.grpAsociar.TabIndex = 26;
            this.grpAsociar.TabStop = false;
            this.grpAsociar.Text = "Asociar a:";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(223, 361);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(254, 110);
            this.dgvListado.TabIndex = 27;
            // 
            // btnInsertAlta
            // 
            this.btnInsertAlta.Location = new System.Drawing.Point(35, 402);
            this.btnInsertAlta.Name = "btnInsertAlta";
            this.btnInsertAlta.Size = new System.Drawing.Size(84, 23);
            this.btnInsertAlta.TabIndex = 28;
            this.btnInsertAlta.Text = "Dar ALTA";
            this.btnInsertAlta.UseVisualStyleBackColor = true;
            this.btnInsertAlta.Click += new System.EventHandler(this.btnInsertAlta_Click);
            // 
            // btnNuevaAlta
            // 
            this.btnNuevaAlta.Enabled = false;
            this.btnNuevaAlta.Location = new System.Drawing.Point(125, 402);
            this.btnNuevaAlta.Name = "btnNuevaAlta";
            this.btnNuevaAlta.Size = new System.Drawing.Size(80, 23);
            this.btnNuevaAlta.TabIndex = 29;
            this.btnNuevaAlta.Text = "Nueva ALTA";
            this.btnNuevaAlta.UseVisualStyleBackColor = true;
            this.btnNuevaAlta.Click += new System.EventHandler(this.btnNuevaAlta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Location = new System.Drawing.Point(269, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 77);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User name y Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(14, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(153, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(14, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // frmALTAafiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNuevaAlta);
            this.Controls.Add(this.btnInsertAlta);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.grpAsociar);
            this.Controls.Add(this.cbbPlanMedico);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNumAfiliado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantHijos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbEstadoCivil);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmALTAafiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmALTAafiliado";
            this.Load += new System.EventHandler(this.frmALTAafiliado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpAsociar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTipoDni;
        private System.Windows.Forms.TextBox txtNumDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbEstadoCivil;
        private System.Windows.Forms.TextBox txtCantHijos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumAfiliado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNroRaiz;
        private System.Windows.Forms.ComboBox cbbPlanMedico;
        private System.Windows.Forms.Button btnPareja;
        private System.Windows.Forms.Button btnHijo;
        private System.Windows.Forms.GroupBox grpAsociar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnInsertAlta;
        private System.Windows.Forms.Button btnNuevaAlta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
    }
}