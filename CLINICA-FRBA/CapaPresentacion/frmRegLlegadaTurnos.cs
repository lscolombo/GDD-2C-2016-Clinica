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
    public partial class frmRegLlegadaTurnos : Form
    {
        public frmRegLlegadaTurnos()
        {
            InitializeComponent();
        }

        private void frmRegLlegadaTurnos_Load(object sender, EventArgs e)
        {
            /*lblDateTime.Text = DateTime.Now.ToString();*/
            lblDateTime.Text = DateTime.Now.ToLongDateString();

            BuscarLosTurnosDisponibles();
        }

        public void setTxtMatricula(string unaMatricula)
        {
            txtMatricula.Text = unaMatricula;
        }

        public void setLblTitulo(string unTitulo)
        {
            lblTitulo.Text = unTitulo;
        }

        public void setTxtEspecialidad(string unaEspecialidad)
        {
            txtEspecialidad.Text = unaEspecialidad;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTimeHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void BuscarLosTurnosDisponibles()
        {
            int matricula = Convert.ToInt32(txtMatricula.Text);
            DateTime fecha = Convert.ToDateTime(DateTime.Now.ToString());

            this.dgvListado.DataSource = N11RegLlegada.BuscarTurnosDisponibles(matricula,fecha);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarLosTurnosDisponibles(); 
        }
    }
}
