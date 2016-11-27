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
    public partial class frmABMRolInicio : Form
    {
        public frmABMRolInicio()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaRol frmAlta = new frmAltaRol();
            frmAlta.Visible = true;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmModificarRol frmModificacion = new frmModificarRol();
            frmModificacion.Visible = true;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmEliminarRol frmBaja = new frmEliminarRol();
            frmBaja.Visible = true;
        }
    }
}
