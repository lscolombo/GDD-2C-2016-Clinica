using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; /**/
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmRegResultados : Form
    {
        public frmRegResultados()
        {
            InitializeComponent();
        }

        private void frmRegResultados_Load(object sender, EventArgs e)
        {
            BuscarLasConsultasParaReg();
        }

        private void BuscarLasConsultasParaReg()
        {
            int matricula = Convert.ToInt32(txtMatricula.Text);
            /*DateTime fecha = Convert.ToDateTime(DateTime.Now.ToString());*/

            this.dgvListado.DataSource = N12RegResultados.BuscarConsultasParaReg(matricula);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
