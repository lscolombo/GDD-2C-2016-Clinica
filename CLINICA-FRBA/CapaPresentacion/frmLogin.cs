using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public static String passingText;
        public static String passingRol;
        public static int cantRoles;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.N2Login.Login(this.TxtUsuario.Text, this.TxtPassword.Text);

            if (Datos.Rows.Count == 0)
            {
                DataTable Habilitado = CapaNegocio.N2Login.EstaHabilitado(this.TxtUsuario.Text);

                if (Habilitado.Rows.Count != 0 && Habilitado.Rows[0][0].ToString() == "False")
                    MessageBox.Show("Usuario inhabilitado, contacte a un administrador", "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("NO Tiene Acceso al Sistema", "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Datos.Rows[0][2].ToString() == "False")
                    MessageBox.Show("Usuario inhabilitado, contacte a un administrador", "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);            
                else
                {
                    passingText = TxtUsuario.Text;
                    cantRoles = CapaNegocio.N2Login.Mostrar(frmLogin.passingText).Rows.Count;

                    if (cantRoles <= 1)
                    {
                        if (cantRoles == 1)
                        {
                            passingRol = CapaNegocio.N2Login.Mostrar(frmLogin.passingText).Rows[0][0].ToString();
                            frmPrincipal frm = new frmPrincipal();
                            frm.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Acceso Denegado. Usted no posee roles asignados del sistema", "ClínicaFRBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                         }
                    
                    }
                    else
                    {
                       frmRoles frm = new frmRoles();
                       frm.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
