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
    public partial class frmEliminarRol : Form
    {
        public frmEliminarRol()
        {
            InitializeComponent();
        }

        private void frmEliminarRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.tablaDeRoles.DataSource = N1ABMRol.mostrarRolesHabilitados();
        }

        private void tablaDeRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaDeRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) /*SI SE SELECCIONO UN REGISTRO DE LOS MOSTRADOS EN EL DATAGRIDVIEW, TENGO UN INDEX DEL REGISTRO*/
            {
                DataGridViewRow Fila = this.tablaDeRoles.Rows[e.RowIndex]; /*OBJETO Q USO PARA GUARDAR EL REGISTRO COMPLETO SEGUN EL INDEX*/

                /*APARTIR DE ACA SOLO GUARDO EN CONTROLES TEXTBOX LOS RESPECTIVOS CAMPOS DEL REGISTRO SELECCIONADO*/
                this.idRol.Text = Fila.Cells["Id"].Value.ToString();
                this.nombreRol.Text = Fila.Cells["Nombre"].Value.ToString();

                this.btnEliminarRol.Enabled = true;
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            N1ABMRol abm = new N1ABMRol();
            abm.deshabilitarRol(Convert.ToInt32(idRol.Text));
            this.tablaDeRoles.DataSource = N1ABMRol.mostrarRolesHabilitados();
            this.idRol.Text = "";
            this.nombreRol.Text = "";
            this.btnEliminarRol.Enabled = false;
            MessageBox.Show("Baja de rol exitosa", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
