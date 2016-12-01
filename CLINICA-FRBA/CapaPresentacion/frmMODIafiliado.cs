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
    public partial class frmMODIafiliado : Form
    {
        bool CambioPlanMedico = false;

        public frmMODIafiliado()
        {
            InitializeComponent();
        }

        private void frmMODIafiliado_Load(object sender, EventArgs e)
        {

        }

        public void LlenarCampos(string ID,string NombreDeUsuario, string Apellido,string Nombre,string TipoDNI,string DNI,
		                         string Direccion,string Telefono,string Mail,string FechaNacimiento,string Sexo,string EstadoCivil,
                                 string CantidadDeHijos, string PlanMedico)
        {
            txtNumAfiliado.Text = ID;
            txtUserName.Text = NombreDeUsuario;
            txtApellido.Text = Apellido;
            txtNombre.Text = Nombre;
            cbbTipoDni.Text = TipoDNI;
            txtNumDni.Text = DNI;
            txtDireccion.Text = Direccion;
            txtTelefono.Text = Telefono;
            txtMail.Text = Mail;
            dtpFechaNacimiento.Value = Convert.ToDateTime(FechaNacimiento);
            if (Sexo == "H")
            {
                cbbSexo.SelectedIndex = 0;
            }
            else
            {
                cbbSexo.SelectedIndex = 1;
            }
            cbbEstadoCivil.Text = EstadoCivil; // a verificar, si puede editar (por ahora no puede)
            txtCantHijos.Text = CantidadDeHijos;

            if (PlanMedico == "555555") { cbbPlanMedico.SelectedIndex = 0; }
            if (PlanMedico == "555556") { cbbPlanMedico.SelectedIndex = 1; }
            if (PlanMedico == "555557") { cbbPlanMedico.SelectedIndex = 2; }
            if (PlanMedico == "555558") { cbbPlanMedico.SelectedIndex = 3; }
            if (PlanMedico == "555559") { cbbPlanMedico.SelectedIndex = 4; }

            txtPlanMedicoActual.Text = cbbPlanMedico.Text;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!todosCamposLlenos())
            {
                MessageBox.Show("Faltan campos a completar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Se guardaran los datos modificados, ¿esta seguro?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    btnUpdate.Enabled = false;
                    int planElegido = 555555 + cbbPlanMedico.SelectedIndex;
                    N4abmAfiliado.ActualizarLosDatos(txtUserName.Text, Convert.ToInt32(txtTelefono.Text),
                                                     txtDireccion.Text, txtMail.Text, txtPassword.Text,
                                                     Convert.ToInt32(txtNumAfiliado.Text), planElegido);
                    MessageBox.Show("", "Modificaciones exitosas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (CambioPlanMedico)
                    {                        
                        if (txtPlanMedicoActual.Text == "Plan Medico 110") { planElegido = 555555; }
                        if (txtPlanMedicoActual.Text == "Plan Medico 120") { planElegido = 555556; }
                        if (txtPlanMedicoActual.Text == "Plan Medico 130") { planElegido = 555557; }
                        if (txtPlanMedicoActual.Text == "Plan Medico 140") { planElegido = 555558; }
                        if (txtPlanMedicoActual.Text == "Plan Medico 150") { planElegido = 555559; }

                        N4abmAfiliado.InsertarCambioDePlanM(Convert.ToInt32(txtNumAfiliado.Text), planElegido, txtDescripcion.Text);
                        MessageBox.Show("Se registro el cambio de plan medico", "Cambio de Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private bool todosCamposLlenos()
        {
            if (txtNombre.Text == "") return false;
            if (txtApellido.Text == "") return false;
            if (txtNumDni.Text == "") return false;
            if (txtDireccion.Text == "") return false;
            if (txtTelefono.Text == "") return false;
            if (txtMail.Text == "") return false;
            if (txtCantHijos.Text == "") return false;

            if (txtUserName.Text == "") return false;
            if (txtPassword.Text == "") return false;

            if (txtDescripcion.Text == "") return false;

            return true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = soloNumeros(e);
        }

        private bool soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                return false;
            else
                if (char.IsControl(e.KeyChar))
                    return false;
                else
                    return true;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbPlanMedico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbPlanMedico.Text == txtPlanMedicoActual.Text)
            {
                grpMotivoCambioP.Enabled = false;
                txtDescripcion.Text = "Sin Descripcion";
                CambioPlanMedico = false;
            }
            else
            {
                grpMotivoCambioP.Enabled = true;
                CambioPlanMedico = true;
            }
        }
    }
}
