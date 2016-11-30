using System;
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
    public partial class frmRoles : Form
    {
        public static String passingRol;

        public frmRoles()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            this.dgvRoles.DataSource = CapaNegocio.N2Login.Mostrar(frmLogin.passingText);
        }

        private void dgvRoles_DoubleClick(object sender, EventArgs e)
        {
            this.txtRol.Text = Convert.ToString(this.dgvRoles.CurrentRow.Cells["rol_descripcion"].Value);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            passingRol = txtRol.Text;
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }
    }
}
