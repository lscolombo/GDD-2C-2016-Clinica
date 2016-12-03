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
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private DataTable MostrarEspecialidades()
            {
           
            N14Estadisticas Obj = new N14Estadisticas();
            DataTable var = Obj.MostrarEspecialidades();
            return (var);
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
           //cmb TipoListado
            DataTable dtTipoListado = new DataTable();
            dtTipoListado.Columns.Add("tipo");
            dtTipoListado.Columns.Add("descripcion");
            DataRow dr = dtTipoListado.NewRow();
            dr["tipo"] = 1;
            dr["descripcion"] = "Especialidades con más cancelaciones";
            dtTipoListado.Rows.Add(dr);

            dr = dtTipoListado.NewRow();
            dr["tipo"] = 2;
            dr["descripcion"] = "Profesionales más consultados por especialidad";
            dtTipoListado.Rows.Add(dr);

            dr = dtTipoListado.NewRow();
            dr["tipo"] = 3;
            dr["descripcion"] = "Profesionales con menos horas trabajadas por especialidad";
            dtTipoListado.Rows.Add(dr);

            dr = dtTipoListado.NewRow();
            dr["tipo"] = 4;
            dr["descripcion"] = "Afiliados con mayor cantidad de bonos comprados";
            dtTipoListado.Rows.Add(dr);

            dr = dtTipoListado.NewRow();
            dr["tipo"] = 5;
            dr["descripcion"] = "Especialidades de médicos con más bonos de consultas utilizados";
            dtTipoListado.Rows.Add(dr);

            cmbTipoListado.DisplayMember = "descripcion";
            cmbTipoListado.ValueMember = "tipo";
            cmbTipoListado.DataSource = dtTipoListado;

            cmbTipoListado.SelectedIndex = -1;

            //cmb Mes
            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");
            cmbMes.SelectedIndex = -1;

            //cmb Año
            for (int i = 1990; i <= 2017; i++)
            {
                string[] numbers = { i.ToString() };
                cmbAnio.Items.AddRange(numbers);
            }

            cmbAnio.SelectedIndex = -1;

            //cmb Especialidades
            cmbEspecialidad.DataSource = MostrarEspecialidades();
            cmbEspecialidad.DisplayMember = "esp_descripcion";
            cmbEspecialidad.ValueMember = "esp_codigo";
            cmbEspecialidad.SelectedIndex = -1;

        }
    }
}
