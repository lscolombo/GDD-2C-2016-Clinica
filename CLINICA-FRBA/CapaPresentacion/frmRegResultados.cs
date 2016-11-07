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

        public void setTxtMatricula(string unaMatricula)
        {
            txtMatricula.Text = unaMatricula;
        }

        private void frmRegResultados_Load(object sender, EventArgs e)
        {
            BuscarLasConsultasParaReg();
            if (dgvListado.RowCount == 0)
            {
                lblNoConsultas.Visible = true;
                btnSeleccionar.Enabled = false;
                dgvListado.Enabled = false;
            }

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

        private void AbilitarEdicion(bool swEdit)
        {
            groupBox1.Enabled = swEdit;
            groupBox2.Enabled = swEdit;
            btnSeleccionar.Enabled = !swEdit;
            btnAceptar.Enabled = swEdit;
            btnCancelar.Enabled = swEdit;
            dgvListado.Enabled = !swEdit;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (txtIdConsulta.Text == "")
            {
                MessageBox.Show("Debe tener seleccionado una consulta", "Seleccion de consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AbilitarEdicion(true);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AbilitarEdicion(false);
        }

        private void UpdateALaConsultaSelecionada()
        {
            int IdConsulta = Convert.ToInt32(txtIdConsulta.Text);
            string enfermedades = txtEnfermedades.Text;
            string sintomas = txtSintomas.Text;

            this.dgvListado.DataSource = N12RegResultados.UpdateAConsulta(IdConsulta,enfermedades,sintomas);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UpdateALaConsultaSelecionada();
            MessageBox.Show("Se registro el diagnostico de la atencion", "Registro de enfermedades Y sintomas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dgvListado.Rows[e.RowIndex];

                this.txtIdConsulta.Text = Fila.Cells["Id"].Value.ToString();

            }
        }
    }
}
