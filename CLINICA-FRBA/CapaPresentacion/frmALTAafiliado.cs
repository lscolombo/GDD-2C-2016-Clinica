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
    public partial class frmALTAafiliado : Form
    {
        int NroRaiz;
        int ContadorHijos;

        public frmALTAafiliado()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmALTAafiliado_Load(object sender, EventArgs e)
        {
            generarNroRaiz();             
        }

        private void generarNroRaiz()
        {
            DataTable resultado = N4abmAfiliado.BuscarElUltimoAfiliado();
            dgvListado.DataSource = resultado;  // <-----A BORRAR
            txtNroRaiz.Text = resultado.Rows[0][0].ToString();
            NroRaiz = (Convert.ToInt32(txtNroRaiz.Text) / 100) + 1;
            txtNroRaiz.Text = NroRaiz.ToString();

            txtNumAfiliado.Text=txtNroRaiz.Text + "01";
            txtPrincipal.Text = txtNumAfiliado.Text;

            txtNombre.Text = "";
            txtApellido.Text = "";
            cbbTipoDni.SelectedIndex = 0;
            txtNumDni.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            cbbSexo.SelectedIndex = 0;
            cbbEstadoCivil.SelectedIndex = 0;
            txtCantHijos.Text = "0";
            cbbPlanMedico.SelectedIndex = 0;
            txtCantHijos.ReadOnly = false;
            ContadorHijos = 0;
            cbbEstadoCivil.Enabled = true;

            txtUserName.Text = "";
            txtPassword.Text = "";

            btnPareja.Enabled = false;
            btnHijo.Enabled = false;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void txtCantHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = soloNumeros(e);
                  
        }

        private void txtNumDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = soloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = soloNumeros(e);
        }

        private void cbbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!todosCamposLlenos())
            {
                MessageBox.Show("Faltan campos a completar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnPareja.Enabled = false;
                cbbEstadoCivil.Enabled = false;
                frmALTAafiliado frmALTAPareja = new frmALTAafiliado();
                frmALTAPareja.Visible = true;  /*PRIMERO TENGO Q MOSTRARLO Y LUEGO HACER LOS CAMBIOS Q HAGA*/

                frmALTAPareja.txtNumAfiliado.Text = ((NroRaiz * 100) + 2).ToString();

                frmALTAPareja.Text = "Alta de Pareja";

                frmALTAPareja.grpAsociar.Visible = false;

                frmALTAPareja.cbbEstadoCivil.SelectedIndex = cbbEstadoCivil.SelectedIndex;
                frmALTAPareja.cbbEstadoCivil.Enabled = false;

                frmALTAPareja.txtCantHijos.Text = txtCantHijos.Text;
                frmALTAPareja.txtCantHijos.Enabled = false;
                
                frmALTAPareja.txtPrincipal.Text = txtPrincipal.Text;

                frmALTAPareja.btnNuevaAlta.Visible = false;
            }
            
        }
        public void cambiarNroRaiz(string unTexto)
        {
            txtNroRaiz.Text = unTexto;
        }

        public void cambiarNroDeAfiliadoPareja()
        {
            txtNumAfiliado.Text = NroRaiz.ToString() + "02";
        }

        private void darPosibilidadesDeAfiliacion()
        {
            if (cbbEstadoCivil.SelectedIndex == 1 || cbbEstadoCivil.SelectedIndex == 3)
                btnPareja.Enabled = true;
            else
                btnPareja.Enabled = false;

            if (ContadorHijos!=0)
            {
                btnHijo.Enabled = true;
            }            
        }
        
        private void txtCantHijos_TextChanged(object sender, EventArgs e)
        {
            if (txtCantHijos.Text == "0" || txtCantHijos.Text == "")
            {
                ContadorHijos = 0;
            }
            else
            {
                ContadorHijos = Convert.ToInt16(txtCantHijos.Text);
            }            
        }

        private void btnInsertAlta_Click(object sender, EventArgs e)
        {
            if (!todosCamposLlenos())
            {
                MessageBox.Show("Faltan campos a completar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {    
                dgvListado.DataSource = N4abmAfiliado.ExisteElUserName(txtUserName.Text);
                
                if (dgvListado.RowCount == 1) //EXISTE USERNAME
                {
                    dgvListado.DataSource = N4abmAfiliado.ExisteElUsuario(cbbTipoDni.Text, txtMail.Text, Convert.ToInt32(txtNumDni.Text));
                    if (dgvListado.RowCount == 1) // EXISTE usuario
                    {
                        dgvListado.DataSource = N4abmAfiliado.ExisteElAfiliado(txtUserName.Text);
                        if (dgvListado.RowCount == 1) //EXISTE AFILIADO
                        {
                            // 2
                            MessageBox.Show("No se puede dar el ALTA, el usuario ya es un afiliado,", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {   // 1
                            int planElegido = 555555 + cbbPlanMedico.SelectedIndex;

                            btnInsertAlta.Enabled = false;
                            N4abmAfiliado.InsertElAfiliado(Convert.ToInt32(txtNumAfiliado.Text),
                                                           txtUserName.Text,
                                                           planElegido,
                                                           Convert.ToInt32(txtPrincipal.Text),
                                                           Convert.ToInt32(txtCantHijos.Text));
                            darPosibilidadesDeAfiliacion();
                            btnNuevaAlta.Enabled = true;
                            //MessageBox.Show("1.- inserto A");
                            MessageBox.Show("Afiliado registrado", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {   // (3)
                        MessageBox.Show("El user name, ya esta en uso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                    }
                }
                else
                { 
                    dgvListado.DataSource = N4abmAfiliado.ExisteElUsuario(cbbTipoDni.Text, txtMail.Text, Convert.ToInt32(txtNumDni.Text));
                    if (dgvListado.RowCount == 1) // EXISTE usuario  (5)
                    {
                        MessageBox.Show("El usuario ya esta registrado, ingrese su user name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int planElegido = 555555 + cbbPlanMedico.SelectedIndex;
                        btnInsertAlta.Enabled = false;

                        N4abmAfiliado.InsertElUsuario(txtUserName.Text, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtTelefono.Text),
                            cbbSexo.Text, cbbEstadoCivil.Text, Convert.ToInt32(txtNumDni.Text), cbbTipoDni.Text, dtpFechaNacimiento.Value,
                            txtDireccion.Text, txtMail.Text, txtPassword.Text);

                        N4abmAfiliado.InsertElAfiliado(Convert.ToInt32(txtNumAfiliado.Text), txtUserName.Text, planElegido,
                                                       Convert.ToInt32(txtPrincipal.Text), Convert.ToInt32(txtCantHijos.Text));
                        darPosibilidadesDeAfiliacion();
                        btnNuevaAlta.Enabled = true;
                        //MessageBox.Show("4.- inserto U y A");
                        MessageBox.Show("Afiliado registrado", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                
            }            
                          
            
        }

        private void btnHijo_Click(object sender, EventArgs e)
        {
            if (!todosCamposLlenos())
            {
                MessageBox.Show("Faltan campos a completar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmALTAafiliado frmALTAHijo = new frmALTAafiliado();
                frmALTAHijo.Visible = true;  /*PRIMERO TENGO Q MOSTRARLO Y LUEGO HACER LOS CAMBIOS Q HAGA*/

                frmALTAHijo.txtNumAfiliado.Text = ((NroRaiz * 100) + Convert.ToInt16(txtCantHijos.Text) - ContadorHijos + 3).ToString();

                ContadorHijos--;
                txtCantHijos.ReadOnly = true;
                if (ContadorHijos == 0)
                {
                    btnHijo.Enabled = false;
                }


                frmALTAHijo.Text = "Alta de Hijo/a";

                frmALTAHijo.grpAsociar.Visible = false;

                frmALTAHijo.cbbEstadoCivil.SelectedIndex = 0;
                frmALTAHijo.cbbEstadoCivil.Enabled = false;

                frmALTAHijo.txtCantHijos.Text = "0";
                frmALTAHijo.txtCantHijos.Enabled = false;

                frmALTAHijo.txtPrincipal.Text = txtPrincipal.Text;

                frmALTAHijo.btnNuevaAlta.Visible = false;
            }
            
        }

        private void btnNuevaAlta_Click(object sender, EventArgs e)
        {
            
            btnNuevaAlta.Enabled = false;
            btnInsertAlta.Enabled = true;
            generarNroRaiz();
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

            return true;            
        }

        private void cbbTipoDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
