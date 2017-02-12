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
            dgvTurnosPendientes.DataSource = var.TurnosPendientesEntreFechas(frmLogin.passingText.ToString(), this.dTimeFechaInicio.Value, this.dTimeFechaFin.Value); //acá le debería pasar como primer paràmetro el usuario logueado. le hardcodeo el id 1465925 para probar
            dgvTurnosPendientes.AutoGenerateColumns = true;
            
        }


        private void cancelarTurnosProf()
        {

            N13CancAtencion Obj = new N13CancAtencion();
            //string profesionalID = "80527583"; //pasarle el id del profesional logueado
           // string profesionalID = frmLogin.passingText;
            DateTime fechaInicio = this.dTimeFechaInicio.Value;
            DateTime fechaFin = this.dTimeFechaFin.Value;
            string detalle = this.txtMotivoCancelacion.Text;
            string var = Obj.CancelarTurnosProf(fechaInicio, fechaFin, detalle, frmLogin.passingText.ToString());
            
            MessageBox.Show(var, "CLINICA-FRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCancTurnosProf_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarTurnos_Click(object sender, EventArgs e)
        {
            this.cargarDataGridView();
        }

        private void btnCancelarTurnos_Click(object sender, EventArgs e)
        {
            if (dgvTurnosPendientes.Rows.Count == 0)
            {
                MessageBox.Show("No posee turnos pendientes para cancelar", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            this.cancelarTurnosProf();
            this.txtMotivoCancelacion.Text = "";
            this.cargarDataGridView();
           
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.dTimeFechaFin.Value = dTimeFechaInicio.Value;
                this.dTimeFechaFin.Enabled = false;

            }

            if (this.checkBox1.Checked == false)
            {
                
                this.dTimeFechaFin.Enabled = true;

            }
        }

        private void frmCancTurnosProf_Load_1(object sender, EventArgs e)
        {

        }

        private void dTimeFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.dTimeFechaFin.Value = dTimeFechaInicio.Value;
            }
        }
    }
}
