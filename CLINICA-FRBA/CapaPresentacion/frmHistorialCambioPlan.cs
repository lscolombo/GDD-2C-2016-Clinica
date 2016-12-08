using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio; /*PARA TENER REFERENCIA DE LAS CLASES DE OTRA CAPA*/

namespace CapaPresentacion
{
    public partial class frmHistorialCambioPlan : Form
    {
        public frmHistorialCambioPlan()
        {
            InitializeComponent();
        }

        private void frmHistorialCambioPlan_Load(object sender, EventArgs e)
        {
            dgvListado.DataSource = N4abmAfiliado.FiltroDeHistorial(-1,"","");
            
        }

        private void txtIdAfiliado_TextChanged(object sender, EventArgs e)
        {
            if (txtIdAfiliado.Text == "")
            {
                grpNomApell.Enabled = true;
                btnFiltrar.Text = "Filtrar por Datos";               
            }
            else
            {
                grpNomApell.Enabled = false;
                btnFiltrar.Text = "Filtrar solo por ID";
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (grpNomApell.Enabled)
            {
                dgvListado.DataSource = N4abmAfiliado.FiltroDeHistorial(-1, txtApellido.Text, txtNombre.Text);
            }
            else
            {
                dgvListado.DataSource = N4abmAfiliado.FiltroDeHistorial(Convert.ToInt32(txtIdAfiliado.Text), "", "");
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dgvListado.DataSource = N4abmAfiliado.FiltroDeHistorial(-1, "", "");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdAfiliado.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            dgvListado.DataSource = null;
        }

        private void txtIdAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = soloNumeros(e);
        }

        private bool soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                return false;
            else
                if (char.IsControl(e.KeyChar))
                    return false;
                else
                    return true;
        }
    }
}
