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
            this.CenterToScreen();
            lblDateTime.Text = DateTime.Now.ToLongDateString();

            BuscarLosTurnosDisponibles();
            if (dgvListado.RowCount == 0)
            {
                lblTitulo.Text = "El profesional seleccionado no posee turnos hoy";
                btnSeleccionar.Enabled = false;
            }
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
            if (txtAfiliado.Text == "")
            {
                MessageBox.Show("Debe tener seleccionado un turno", "Seleccion de turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmRegLlegadaTurnosBonos frmRegLlegadaTurnosBonos = new frmRegLlegadaTurnosBonos();

                frmRegLlegadaTurnosBonos.setLblTitulo("Seleccione un bono para registrar la consulta del afiliado");
                frmRegLlegadaTurnosBonos.setTxtAfiliado(txtElAfiliado.Text);
                frmRegLlegadaTurnosBonos.setTxtNombAfiliado(txtAfiliado.Text);
                frmRegLlegadaTurnosBonos.setTxtTurno(txtTurno.Text);
                
                frmRegLlegadaTurnosBonos.Visible = true;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTimeHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void BuscarLosTurnosDisponibles()
        {
            int matricula = Convert.ToInt32(txtMatricula.Text);
            /*DateTime fecha = Convert.ToDateTime(DateTime.Now.ToString());*/

            this.dgvListado.DataSource = N11RegLlegada.BuscarTurnosDisponibles(matricula);/*,fecha);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarLosTurnosDisponibles(); 
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dgvListado.Rows[e.RowIndex];

                this.txtAfiliado.Text = Fila.Cells["Apellido"].Value.ToString() + ", " + Fila.Cells["Nombre"].Value.ToString();
                this.txtElAfiliado.Text = Fila.Cells["Afiliado"].Value.ToString();
                this.txtTurno.Text = Fila.Cells["Numero"].Value.ToString();

            }
            else
            {
                txtAfiliado.Text = "";
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
