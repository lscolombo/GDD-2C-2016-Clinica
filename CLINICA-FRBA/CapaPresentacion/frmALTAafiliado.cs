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
//using System.Security.Cryptography;

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
            if (cbbEstadoCivil.SelectedIndex == 1 || cbbEstadoCivil.SelectedIndex == 3)
                btnPareja.Enabled = true;
            else
                btnPareja.Enabled = false;
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
            //txtNombre.Text = sender.ToString();
            //txtApellido.Text = cbbSexo.SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPareja.Enabled = false;
            cbbEstadoCivil.Enabled = false;
            frmALTAafiliado frmALTAPareja = new frmALTAafiliado();
            frmALTAPareja.Visible = true;  /*PRIMERO TENGO Q MOSTRARLO Y LUEGO HACER LOS CAMBIOS Q HAGA*/

            frmALTAPareja.Text = "Alta de Pareja";

            frmALTAPareja.grpAsociar.Visible = false;

            frmALTAPareja.cbbEstadoCivil.SelectedIndex = cbbEstadoCivil.SelectedIndex;
            frmALTAPareja.cbbEstadoCivil.Enabled = false;

            frmALTAPareja.txtCantHijos.Text = txtCantHijos.Text;
            frmALTAPareja.txtCantHijos.Enabled = false;

            frmALTAPareja.cambiarNroDeAfiliadoPareja();
            
        }
        public void cambiarNroRaiz(string unTexto)
        {
            txtNroRaiz.Text = unTexto;
        }

        public void cambiarNroDeAfiliadoPareja()
        {
            txtNumAfiliado.Text = NroRaiz.ToString() + "02";
        }

        
        private void txtCantHijos_TextChanged(object sender, EventArgs e)
        {
            if (txtCantHijos.Text == "0" || txtCantHijos.Text == "")
            {
                btnHijo.Enabled = false;
                ContadorHijos = 0;
            }
            else
            {
                btnHijo.Enabled = true;
                ContadorHijos = Convert.ToInt16(txtCantHijos.Text);
            }

            
        }

        private void btnInsertAlta_Click(object sender, EventArgs e)
        {
            if (todosCamposLlenos())
            {
                MessageBox.Show("Faltan campos a completar");
            }
            else
            {
                DataTable resultado = N4abmAfiliado.ExisteElUsuario(txtUserName.Text,txtMail.Text,Convert.ToInt32(txtNumDni.Text));
                if (resultado.Rows.Count == 1) //UN REGISTRO
                {
                    MessageBox.Show("El UserName ya esta en uso");
                }
                else
                { MessageBox.Show("NO Existe"); }

                //btnInsertAlta.Enabled = false;
                //btnNuevaAlta.Enabled = true;
                
                /*SHA256 mySHA256 = SHA256Managed.Create();
                byte[] textAEncrip = ASCIIEncoding.ASCII.GetBytes(txtNombre.Text);
                byte[] hashValue;
                hashValue = mySHA256.ComputeHash(textAEncrip);
                txtApellido.Text = Convert.ToString(hashValue);*/
            }
        }

        private void btnHijo_Click(object sender, EventArgs e)
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

            frmALTAHijo.cbbEstadoCivil.SelectedIndex = cbbEstadoCivil.SelectedIndex;
            frmALTAHijo.cbbEstadoCivil.Enabled = false;

            frmALTAHijo.txtCantHijos.Text = "0";
            frmALTAHijo.txtCantHijos.Enabled = false;            
            
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

            return true;            
        }
    }
}
