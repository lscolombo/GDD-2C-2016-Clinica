using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio; /*PARA TENER REFERENCIA DE LAS CLASES DE OTRA CAPA*/


namespace CapaPresentacion
{
    public partial class frmBAJAafiliado : Form
    {
        DataGridViewRow Fila;

        public frmBAJAafiliado()
        {
            InitializeComponent();
        }

        private void frmBAJAafiliado_Load(object sender, EventArgs e)
        {

        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //LLENO EL txtAfiliado
            /*SEGUN QUE REGISTRO SE SELECCIONE*/
            
            if (e.RowIndex >= 0) /*SI SE SELECCIONO UN REGISTRO DE LOS MOSTRADOS EN EL DATAGRIDVIEW, TENGO UN INDEX DEL REGISTRO*/
            {
                Fila = this.dgvListado.Rows[e.RowIndex]; /*OBJETO Q USO PARA GUARDAR EL REGISTRO COMPLETO SEGUN EL INDEX*/

                /*APARTIR DE ACA SOLO GUARDO EN CONTROLES TEXTBOX LOS RESPECTIVOS CAMPOS DEL REGISTRO SELECCIONADO*/

                txtAfiliado.Text = Fila.Cells["Apellido"].Value.ToString() + ", " + Fila.Cells["Nombre"].Value.ToString();
                txtUserName.Text = Fila.Cells["NombreDeUsuario"].Value.ToString();
                txtID.Text = Fila.Cells["ID"].Value.ToString();
            }
            else // FIX DE SELECION DE CABEZAL DE COLUMNA
            {
                txtAfiliado.Text = "";
            }
        }

        private void BuscarAfiliado()
        {
            this.dgvListado.DataSource = N4abmAfiliado.BuscarAlAfiliado(txtApellido.Text,txtNombre.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*VERIFICO SI EL USUARIO INGRESO ALGUN DATO PARA LA BUSQUEDA*/
            /*Y REALIZO LO RESPECTIVO*/
            if (txtApellido.Text == "" && txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar al menos un filtro", "Ingreso de filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BuscarAfiliado();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            /*METODO USADO PARA REALIZAR LO CORESPONDIENTE AL TENER UN PROFESIONAL SELECCIONADO*/
            
            if (txtAfiliado.Text == "")
            {
                MessageBox.Show("Debe tener seleccionado un afiliado", "Seleccion de afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Se dara de baja al afiliado, ¿esta seguro?", "Dar de BAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    btnSeleccionar.Enabled = false;
                    N4abmAfiliado.BajaLogicaADelAfiliado(txtUserName.Text, Convert.ToInt32(txtID.Text));

                    MessageBox.Show("Afiliado dado de baja", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }        

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtAfiliado.Text = "";
            dgvListado.DataSource = null;
            txtUserName.Text = "";
            txtID.Text = "";
            btnSeleccionar.Enabled = true;
            btbModicacion.Enabled = true;
        }

        public void setAModificacion()
        {
            this.Text = "MODIFICACION Afiliado";
            btnSeleccionar.Visible = false;
            btbModicacion.Visible = true; // ERA btN...   :S
        }

        private void btbModicacion_Click(object sender, EventArgs e)
        {
            /*METODO USADO PARA REALIZAR LO CORESPONDIENTE AL TENER UN PROFESIONAL SELECCIONADO*/
            if (txtAfiliado.Text == "")
            {
                MessageBox.Show("Debe tener seleccionado un afiliado", "Seleccion de afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btbModicacion.Enabled = false;
                frmMODIafiliado frmMODIafiliado = new frmMODIafiliado();
                frmMODIafiliado.Visible = true;

                frmMODIafiliado.LlenarCampos(Fila.Cells["ID"].Value.ToString(), Fila.Cells["NombreDeUsuario"].Value.ToString(),
                                             Fila.Cells["Apellido"].Value.ToString(), Fila.Cells["Nombre"].Value.ToString(),
                                             Fila.Cells["TipoDNI"].Value.ToString(),Fila.Cells["DNI"].Value.ToString(),
                                             Fila.Cells["Direccion"].Value.ToString(),Fila.Cells["Telefono"].Value.ToString(),
                                             Fila.Cells["Mail"].Value.ToString(),Fila.Cells["FechaNacimiento"].Value.ToString(),
                                             Fila.Cells["Sexo"].Value.ToString(),Fila.Cells["EstadoCivil"].Value.ToString(),
                                             Fila.Cells["CantidadDeHijos"].Value.ToString(),Fila.Cells["PlanMedico"].Value.ToString());
                
            }
        }
    }
}
