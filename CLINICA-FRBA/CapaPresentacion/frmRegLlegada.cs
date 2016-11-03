using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  /*para   MessageBox*/
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmRegLlegada : Form
    {
        public frmRegLlegada()
        {
            InitializeComponent();
        }

        private void frmRegLlegada_Load(object sender, EventArgs e)
        {

        }

        private void BuscarPro1()
        {
            this.dgvListado.DataSource = N11RegLlegada.BuscarPorApellido(txtApellido.Text);

        }
        
        private void BuscarPro2()
        {
            this.dgvListado.DataSource = N11RegLlegada.BuscarPorEspecialidad(txtEspecialidad.Text);

        }

        private void BuscarPro3()
        {
            this.dgvListado.DataSource = N11RegLlegada.BuscarPorApellidoEspec(txtApellido.Text,txtEspecialidad.Text);

        }
       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*BuscarPro1();*/
            if (txtApellido.Text == "" && txtEspecialidad.Text == "") 
            {
                MessageBox.Show("Debe ingresar al menos un filtro","Ingreso de filtro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                BuscarPro3();
            }

            /*BuscarPro3();*/
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtEspecialidad.Text = "";
            this.dgvListado.DataSource = null;
            txtProfesional.Text = "";
            txtMatricula.Text = "";
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Fila = this.dgvListado.Rows[e.RowIndex];
                txtMatricula.Text = Fila.Cells["Matricula"].Value.ToString();
                txtSuEspecialidad.Text = Fila.Cells["Especialidad"].Value.ToString();
                txtApellNombre.Text = Fila.Cells["Apellido"].Value.ToString() + ", " + Fila.Cells["Nombre"].Value.ToString();
                txtProfesional.Text = "Dr. " + txtApellNombre.Text + "  -  " + txtSuEspecialidad.Text;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (txtProfesional.Text == "")
            {
                MessageBox.Show("Debe tener selecionado un profesional");
            }
            else
            {
                frmRegLlegadaTurnos frmRegLlegadaTurnos = new frmRegLlegadaTurnos();

                frmRegLlegadaTurnos.setLblTitulo("Turnos del Dr. " + txtApellNombre.Text);
                frmRegLlegadaTurnos.setTxtEspecialidad(txtSuEspecialidad.Text);
                frmRegLlegadaTurnos.setTxtMatricula(txtMatricula.Text);
                frmRegLlegadaTurnos.Visible = true;
            }
        }
    }
}
