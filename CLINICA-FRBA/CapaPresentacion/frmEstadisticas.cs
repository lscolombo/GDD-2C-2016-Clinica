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

        int anio;
        int semestre;
        int tipoListado;
        //int? mes;
        //int? especialidad;
        //int? tipoCancelacion;
         
        int? mes = null;
        int? especialidad = null;
        int? tipoCancelacion = null;


        private DataTable MostrarEspecialidades()
            {
           
            N14Estadisticas Obj = new N14Estadisticas();
            DataTable var = Obj.MostrarEspecialidades();
            return (var);
            }

        private DataTable MostrarResultados()
        {
            N14Estadisticas Obj = new N14Estadisticas();
           // DataTable var = Obj.ListadoEstadistico(anio, semestre, mes, tipoListado, especialidad, tipoCancelacion);
            DataTable var = Obj.ListadoEstadistico(2015, 2, null, 1, null, null);
            return (var);
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
            cmbMes.ValueMember = Convert.ToString(cmbMes.SelectedIndex + 1);

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
            //especialidad = (int)cmbEspecialidad.SelectedValue;

        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            //validación combobox anio
            if (cmbAnio.SelectedItem != null)
            {
                anio = Convert.ToInt32(cmbAnio.SelectedValue);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un año", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
            //validación combobox tipo listado
            if (cmbTipoListado.SelectedItem != null)
            {
                tipoListado = Convert.ToInt32(cmbTipoListado.SelectedValue);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un listado", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //validación semestre
            if (rbPrimerSemestre.Checked == false && rbSegundoSemestre.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un semestre", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            //cargar dataGridView con resultados
            this.dgvResultadosEstadisticas.DataSource = this.MostrarResultados();

        }

        private void rbPrimerSemestre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrimerSemestre.Checked == true)
            {
                semestre = 1;
            }
        }

        private void rbSegundoSemestre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSegundoSemestre.Checked == true)
            {
                semestre = 2;
            }
        }
    }
}
