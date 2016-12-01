namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuABM = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAltaAfiliado = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAltaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCancelaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarAtencionMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuComprar = new System.Windows.Forms.ToolStripMenuItem();
            this.bonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListados = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTurnos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSolicitarTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLlegada = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuResultados = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSistema,
            this.MnuABM,
            this.MnuCancelaciones,
            this.MnuComprar,
            this.MnuListados,
            this.MnuTurnos,
            this.MnuRegistrar,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(783, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuSistema
            // 
            this.MnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.MnuSistema.Name = "MnuSistema";
            this.MnuSistema.Size = new System.Drawing.Size(96, 20);
            this.MnuSistema.Text = "SistemaClinica";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MnuABM
            // 
            this.MnuABM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAltaAfiliado,
            this.MnuAltaRol});
            this.MnuABM.Name = "MnuABM";
            this.MnuABM.Size = new System.Drawing.Size(45, 20);
            this.MnuABM.Text = "ABM";
            // 
            // MnuAltaAfiliado
            // 
            this.MnuAltaAfiliado.Name = "MnuAltaAfiliado";
            this.MnuAltaAfiliado.Size = new System.Drawing.Size(155, 22);
            this.MnuAltaAfiliado.Text = "Alta de Afiliado";
            this.MnuAltaAfiliado.Click += new System.EventHandler(this.altaDeAfiliadoToolStripMenuItem_Click);
            // 
            // MnuAltaRol
            // 
            this.MnuAltaRol.Name = "MnuAltaRol";
            this.MnuAltaRol.Size = new System.Drawing.Size(155, 22);
            this.MnuAltaRol.Text = "Alta de Rol";
            this.MnuAltaRol.Click += new System.EventHandler(this.altaDeRolToolStripMenuItem_Click);
            // 
            // MnuCancelaciones
            // 
            this.MnuCancelaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarAtencionMedicaToolStripMenuItem});
            this.MnuCancelaciones.Name = "MnuCancelaciones";
            this.MnuCancelaciones.Size = new System.Drawing.Size(95, 20);
            this.MnuCancelaciones.Text = "Cancelaciones";
            // 
            // cancelarAtencionMedicaToolStripMenuItem
            // 
            this.cancelarAtencionMedicaToolStripMenuItem.Name = "cancelarAtencionMedicaToolStripMenuItem";
            this.cancelarAtencionMedicaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cancelarAtencionMedicaToolStripMenuItem.Text = "Cancelar atencion medica";
            this.cancelarAtencionMedicaToolStripMenuItem.Click += new System.EventHandler(this.cancelarAtencionMedicaToolStripMenuItem_Click);
            // 
            // MnuComprar
            // 
            this.MnuComprar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonosToolStripMenuItem});
            this.MnuComprar.Name = "MnuComprar";
            this.MnuComprar.Size = new System.Drawing.Size(66, 20);
            this.MnuComprar.Text = "Comprar";
            // 
            // bonosToolStripMenuItem
            // 
            this.bonosToolStripMenuItem.Name = "bonosToolStripMenuItem";
            this.bonosToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.bonosToolStripMenuItem.Text = "Bonos";
            // 
            // MnuListados
            // 
            this.MnuListados.Name = "MnuListados";
            this.MnuListados.Size = new System.Drawing.Size(62, 20);
            this.MnuListados.Text = "Listados";
            // 
            // MnuTurnos
            // 
            this.MnuTurnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSolicitarTurno});
            this.MnuTurnos.Name = "MnuTurnos";
            this.MnuTurnos.Size = new System.Drawing.Size(56, 20);
            this.MnuTurnos.Text = "Turnos";
            // 
            // MnuSolicitarTurno
            // 
            this.MnuSolicitarTurno.Name = "MnuSolicitarTurno";
            this.MnuSolicitarTurno.Size = new System.Drawing.Size(152, 22);
            this.MnuSolicitarTurno.Text = "Solicitar turno";
            this.MnuSolicitarTurno.Click += new System.EventHandler(this.MnuSolicitarTurno_Click);
            // 
            // MnuRegistrar
            // 
            this.MnuRegistrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAgenda,
            this.MnuLlegada,
            this.MnuResultados});
            this.MnuRegistrar.Name = "MnuRegistrar";
            this.MnuRegistrar.Size = new System.Drawing.Size(65, 20);
            this.MnuRegistrar.Text = "Registrar";
            // 
            // MnuAgenda
            // 
            this.MnuAgenda.Name = "MnuAgenda";
            this.MnuAgenda.Size = new System.Drawing.Size(177, 22);
            this.MnuAgenda.Text = "Agenda Profesional";
            // 
            // MnuLlegada
            // 
            this.MnuLlegada.Name = "MnuLlegada";
            this.MnuLlegada.Size = new System.Drawing.Size(177, 22);
            this.MnuLlegada.Text = "Llegada";
            this.MnuLlegada.Click += new System.EventHandler(this.llegadaToolStripMenuItem_Click);
            // 
            // MnuResultados
            // 
            this.MnuResultados.Name = "MnuResultados";
            this.MnuResultados.Size = new System.Drawing.Size(177, 22);
            this.MnuResultados.Text = "Resultados";
            this.MnuResultados.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(35, 20);
            this.viewMenu.Text = "&Ver";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.toolBarToolStripMenuItem.Text = "&Barra de herramientas";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.statusBarToolStripMenuItem.Text = "&Barra de estado";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(90, 20);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(66, 20);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(144, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(783, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(783, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.Text = "Clinica FRBA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnuSistema;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuABM;
        private System.Windows.Forms.ToolStripMenuItem MnuAltaAfiliado;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem MnuLlegada;
        private System.Windows.Forms.ToolStripMenuItem MnuResultados;
        private System.Windows.Forms.ToolStripMenuItem MnuAltaRol;
        private System.Windows.Forms.ToolStripMenuItem MnuCancelaciones;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtencionMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuComprar;
        private System.Windows.Forms.ToolStripMenuItem bonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuListados;
        private System.Windows.Forms.ToolStripMenuItem MnuAgenda;
        private System.Windows.Forms.ToolStripMenuItem MnuTurnos;
        private System.Windows.Forms.ToolStripMenuItem MnuSolicitarTurno;
    }
}



