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
    public partial class frmCancTurnoAfiliado : Form
    {
        public frmCancTurnoAfiliado()
        {
            InitializeComponent();
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "CLINICA - FRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "CLINICA - FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cancelarTurnoAf()
        {

            N13CancAtencion Obj = new N13CancAtencion();
            int codTurno = (int)this.dgvTurnosDisponibles.CurrentRow.Cells[0].Value;
            string detalle = this.textBox1.Text;
            string var = Obj.CancelarTurnoAf(codTurno, detalle);
            MessageBox.Show(var, "CLINICA-FRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCancTurnoAfiliado_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            N13CancAtencion var = new N13CancAtencion();
            dgvTurnosDisponibles.DataSource = var.TurnosPedidos(frmLogin.passingText);
           
            if (dgvTurnosDisponibles.Rows.Count == 0)
            {
                MessageBox.Show("No posee turnos disponibles para cancelar", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTurnosDisponibles.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTurnosDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTurnosDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.txtTurnoSeleccionado.Text = Convert.ToString(this.dgvTurnosDisponibles.CurrentRow.Cells["turn_id"].Value);
            this.btnCancelarTurno.Enabled = true;
            this.textBox1.Enabled = true;
        }

        private void dgvTurnosDisponibles_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {



        }


        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {

            this.cancelarTurnoAf();
            this.textBox1.Text = "";
            this.txtTurnoSeleccionado.Text = "";
            this.btnCancelarTurno.Enabled = false;
            this.textBox1.Enabled = false;
            N13CancAtencion var = new N13CancAtencion();
            dgvTurnosDisponibles.DataSource = var.TurnosPedidos(frmLogin.passingText);
            if (dgvTurnosDisponibles.Rows.Count == 0)
            {
                MessageBox.Show("No posee turnos disponibles para cancelar", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTurnoSeleccionado_TextChanged(object sender, EventArgs e)
        {
            // this.Text = this.dgvTurnosDisponibles.CurrentRow.Cells["turn_id"].Value.ToString();
        }

        private void frmCancTurnoAfiliado_Click(object sender, EventArgs e)
        {

        }


    }
}
