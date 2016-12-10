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
    public partial class frmPedidoTurno : Form
    {
        private string especialidad;
        private string matricula;        
        private string usuarioProf;

        private string nombreProf;
        private string apellidoProf;

        public frmPedidoTurno()
        {
            InitializeComponent();
            this.llenarComboEspecialidad();
            especialidad = this.cbEspecialidades.SelectedValue.ToString();
            textBox1.Text = especialidad;
            this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);
            this.dgvProfesionales.Columns[0].Visible = false;
            txtProfesional.Text = (CapaNegocio.N10Turno.TraerEspecialidad(especialidad)).Rows[0][0].ToString();
        }

        private void llenarComboEspecialidad()
        {
            cbEspecialidades.DataSource = N10Turno.MostrarEspecialidades();
            cbEspecialidades.ValueMember = "esp_codigo";
            cbEspecialidades.DisplayMember = "esp_descripcion";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPedidoTurno_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);
        }

        private void cbEspecialidades_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            especialidad = this.cbEspecialidades.SelectedValue.ToString();
            textBox1.Text = especialidad;
        }

        // Boton "Buscar profesionales"
        private void button2_Click(object sender, EventArgs e)
        {
            this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);
            this.dgvProfesionales.Columns[0].Visible = false;
            txtProfesional.Text = (CapaNegocio.N10Turno.TraerEspecialidad(especialidad)).Rows[0][0].ToString();

            // Guardo el codigo de la especialidad en un String
            especialidad = this.cbEspecialidades.SelectedValue.ToString();             
        }

        private void dgvProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarioProf = Convert.ToString(this.dgvProfesionales.CurrentRow.Cells["user_username"].Value);

            nombreProf = Convert.ToString(this.dgvProfesionales.CurrentRow.Cells["Nombre"].Value);
            apellidoProf = Convert.ToString(this.dgvProfesionales.CurrentRow.Cells["Apellido"].Value);
            txtEleccion.Text = "Dr. " + nombreProf + " " + apellidoProf;

            // Guardo la matricula en un string
            matricula = (CapaNegocio.N10Turno.TraerMatricula(usuarioProf)).Rows[0][0].ToString();
        }
    }
}
