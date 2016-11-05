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
    public partial class frmRegLlegadaTurnosBonos : Form
    {
        public frmRegLlegadaTurnosBonos()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (txtBono.Text == "")
            {
                MessageBox.Show("Debe tener seleccionado un bono", "Seleccion de bono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grpConfirmacion.Enabled = true;
                btnSeleccionar.Enabled = false;
                dgvListado.Enabled = false;
            }
            
        }

        public void setLblTitulo(string unTitulo) 
        {
            lblTitulo.Text = unTitulo;
        }

        public void setTxtAfiliado(string unAfiliado)
        {
            txtAfiliado.Text = unAfiliado;
        }

        public void setTxtNombAfiliado(string unNombre)
        {
            txtNombAfiliado.Text = unNombre;
        
        }

        public void setTxtTurno(string unTurno)
        {
            txtTurno.Text = unTurno;
        }

        private void frmRegLlegadaTurnosBonos_Load(object sender, EventArgs e)
        {
            BuscarLosBonosDisponibles();
            if (dgvListado.RowCount == 0)
            {
                lblTitulo.Text = "El afiliado no posee bonos para registrar la consulta";
                btnSeleccionar.Enabled = false;
                grpConfirmacion.Enabled = true;
                btnAceptar.Enabled = false;
                dgvListado.Enabled = false;
            }
        }

        private void BuscarLosBonosDisponibles()
        {
            int afiliado = Convert.ToInt32(txtAfiliado.Text);
            
            this.dgvListado.DataSource = N11RegLlegada.BuscarBonosDisponibles(afiliado);
        }

        private void InsertarLaConsulta()
        {/*turno y bono*/
            int turnoReg = Convert.ToInt32(txtTurno.Text);
            int bonoReg = Convert.ToInt32(txtBono.Text);

            N11RegLlegada.InsertarConsulta(turnoReg,bonoReg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = true;
            grpConfirmacion.Enabled = false;
            dgvListado.Enabled = true;
            
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dgvListado.Rows[e.RowIndex];

                this.txtBono.Text = Fila.Cells["Id"].Value.ToString();
                
            }
        }

        private void frmRegLlegadaTurnosBonos_Activated(object sender, EventArgs e)
        {
                        
        }

        private void txtAfiliado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se genero la consulta del afiliado","Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            /*InsertarLaConsulta();*/
            this.Close();
            frmRegLlegadaTurnos.ActiveForm.Close();
        }
    }
}
