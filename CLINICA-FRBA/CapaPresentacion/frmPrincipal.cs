﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegLlegada frm = new frmRegLlegada();
            frm.MdiParent = this;
            frm.Show();
        }

        private void altaDeAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmALTAafiliado frm = new frmALTAafiliado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void altaDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaRol frm = new frmAltaRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegResultados frm = new frmRegResultados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.GestionUsuario(frmRoles.passingRol);
        }

        private void GestionUsuario(string rol)
        {
            DataTable funcionalidades = CapaNegocio.N2Login.MostrarFuncionalidades("Administrador General");

            this.dgvFunc.DataSource = CapaNegocio.N2Login.MostrarFuncionalidades("Administrador General");
            /*
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == funcionalidades.Rows[0][i].ToString())
                    visibilidad[i] = true;
            }
            */

            /*
            int a = funcionalidades.Rows.Count;
            this.dgvFunc.DataSource = CapaNegocio.N2Login.MostrarFuncionalidades(rol);
            MessageBox.Show("Resultados" + rol, "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            */
            this.MnuAltaRol.Visible = true;
            this.MnuAltaAfiliado.Visible = false;

        }
    }
}
