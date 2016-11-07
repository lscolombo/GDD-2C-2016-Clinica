using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  /*PARA EL USO DEL UN  MessageBox*/
using CapaNegocio; /*PARA TENER REFERENCIA DE LAS CLASES DE OTRA CAPA*/

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

        /*METODO USADO POR LA CONSULTAR UN STORE PROCEDURE PASANDO COMO PARAMTROS LOS CAMPOS INGRESADOS POR LOS TEXTBOX*/
        private void BuscarProfesional()
        {
            this.dgvListado.DataSource = N11RegLlegada.BuscarPorApellidoEspec(txtApellido.Text,txtEspecialidad.Text);
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {   
            /*VERIFICO SI EL USUARIO INGRESO ALGUN DATO PARA LA BUSQUEDA*/
            /*Y REALIZO LO RESPECTIVO*/
            if (txtApellido.Text == "" && txtEspecialidad.Text == "") 
            {
                MessageBox.Show("Debe ingresar al menos un filtro","Ingreso de filtro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                BuscarProfesional();
            }
          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {   /*METODO USADO SOLO PARA LIMPIAR CAMPOS */
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
        {   /*METODO USADO PARA LLENAR CAMPOS QUE SE NECESITARAN PARA OTRA CONSULTA*/
            /*SEGUN QUE REGISTRO SE SELECCIONE*/
            if (e.RowIndex >= 0) /*SI SE SELECCIONO UN REGISTRO DE LOS MOSTRADOS EN EL DATAGRIDVIEW, TENGO UN INDEX DEL REGISTRO*/
            {
                DataGridViewRow Fila = this.dgvListado.Rows[e.RowIndex]; /*OBJETO Q USO PARA GUARDAR EL REGISTRO COMPLETO SEGUN EL INDEX*/

                /*APARTIR DE ACA SOLO GUARDO EN CONTROLES TEXTBOX LOS RESPECTIVOS CAMPOS DEL REGISTRO SELECCIONADO*/
                txtMatricula.Text = Fila.Cells["Matricula"].Value.ToString();
                txtSuEspecialidad.Text = Fila.Cells["Especialidad"].Value.ToString();
                txtApellNombre.Text = Fila.Cells["Apellido"].Value.ToString() + ", " + Fila.Cells["Nombre"].Value.ToString();
                txtProfesional.Text = "Dr. " + txtApellNombre.Text + "  -  " + txtSuEspecialidad.Text;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {   /*METODO USADO PARA REALIZAR LO CORESPONDIENTE AL TENER UN PROFESIONAL SELECCIONADO*/
            if (txtProfesional.Text == "")
            {
                MessageBox.Show("Debe tener seleccionado un profesional", "Seleccion de profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
