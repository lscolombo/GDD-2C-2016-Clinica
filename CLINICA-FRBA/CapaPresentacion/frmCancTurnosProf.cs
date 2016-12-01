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
    public partial class frmCancTurnosProf : Form
    {
        public frmCancTurnosProf()
        {
            InitializeComponent();
        }

        private void cargarDataGridView()
        {
            N13CancAtencion var = new N13CancAtencion();
            dgvTurnosPendientes.DataSource = var.TurnosPendientesEntreFechas(1465925, this.dTimeFechaInicio.Value, this.dTimeFechaFin.Value); //acá le debería pasar como primer paràmetro el usuario logueado. le hardcodeo el id 1465925 para probar
            
        }


        private void cancelarTurnosProf()
        {

            N13CancAtencion Obj = new N13CancAtencion();
            int profesionalID = 1465925; //pasarle el id del profesional logueado
            DateTime fechaInicio = this.dTimeFechaInicio.Value;
            DateTime fechaFin = this.dTimeFechaFin.Value;
            string detalle = this.txtMotivoCancelacion.Text;
            string var = Obj.CancelarTurnosProf(fechaInicio, fechaFin, detalle, profesionalID);
            
            MessageBox.Show(var, "CLINICA-FRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCancTurnosProf_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.cargarDataGridView();
            if (dgvTurnosPendientes.Rows.Count == 0)
            {
                MessageBox.Show("No posee turnos disponibles para cancelar", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTurnosPendientes.Enabled = false;
            }

        }

        private void dgvTurnosPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarTurnos_Click(object sender, EventArgs e)
        {
            this.cargarDataGridView();
        }
    }
}
