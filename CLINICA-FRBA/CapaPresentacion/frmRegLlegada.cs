using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmRegLlegada : Form
    {
        public frmRegLlegada()
        {
            InitializeComponent();
        }

        private void frmRegLlegada_Load(object sender, EventArgs e)
        {

        }

        private void BuscarPro1()
        {
            this.dgvListado.DataSource = N11RegLlegada.BuscarPorApellido(txtApellido.Text);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPro1();
        }
    }
}
