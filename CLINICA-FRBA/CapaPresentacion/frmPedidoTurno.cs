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
    public partial class frmPedidoTurno : Form
    {
        private string especialidad;

        public frmPedidoTurno()
        {
            InitializeComponent();
            this.llenarComboEspecialidad();
        }

        private void llenarComboEspecialidad()
        {
            cbEspecialidades.DataSource = N10Turno.MostrarEspecialidades();
            cbEspecialidades.ValueMember = "esp_codigo";
            cbEspecialidades.DisplayMember = "esp_descripcion";
        }

        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            especialidad = this.cbEspecialidades.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
