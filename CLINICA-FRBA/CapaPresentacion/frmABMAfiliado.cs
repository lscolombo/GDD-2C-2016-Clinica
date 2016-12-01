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
    public partial class frmABMAfiliado : Form
    {
        public frmABMAfiliado()
        {
            InitializeComponent();
        }

        
        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmALTAafiliado frmALTAafiliado = new frmALTAafiliado();

            frmALTAafiliado.Visible = true;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmBAJAafiliado frmBAJAafiliado = new frmBAJAafiliado();
            frmBAJAafiliado.Visible = true;
        }
        
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmBAJAafiliado frmBAJAafiliado = new frmBAJAafiliado();
            frmBAJAafiliado.Visible = true;
            frmBAJAafiliado.setAModificacion();
        }

    }
}
