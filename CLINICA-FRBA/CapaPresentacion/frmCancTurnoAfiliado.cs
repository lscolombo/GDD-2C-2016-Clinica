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

      /*  private string cancelarTurnoAf()
        {
            string rpta = "";
            try
            {
                            
            N13CancAtencion Obj = new N13CancAtencion();
           // int codTurno = this.dgvTurnosDisponibles.DataSource
            int codTurno = (int)dgvTurnosDisponibles.CurrentRow.HeaderCell.Value;
            //int codTurno = 1;
            string detalle = this.textBox1.Text;
            string var = Obj.CancelarTurnoAf(codTurno, detalle);
            }
             catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }
        */
        private void frmCancTurnoAfiliado_Load(object sender, EventArgs e)
        {
            N13CancAtencion var = new N13CancAtencion();
            dgvTurnosDisponibles.DataSource = var.TurnosPedidos(1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTurnosDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

          private void btnCancelarTurno_Click(object sender, EventArgs e)
          {
              this.cancelarTurnoAf();
          }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
