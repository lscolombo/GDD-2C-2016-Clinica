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
    public partial class frmCompraDeBonos : Form
    {
        public frmCompraDeBonos()
        {
            InitializeComponent();
        }

        private void frmCompraDeBonos_Load(object sender, EventArgs e)
        {
            if(frmLogin.passingRol != "Administrador General")
            {
                label1.Text = "Nro. de Afiliado";
                txtNroAfiliado.ReadOnly = true;
            }
        }
    }
}
