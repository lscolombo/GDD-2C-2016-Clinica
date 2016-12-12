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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;




        }

        int anio;
        int semestre;
        int tipoListado;
        int mes;
        int especialidad;
        int tipoCancelacion;








        private DataTable MostrarEspecialidades()
        {

            N14Estadisticas Obj = new N14Estadisticas();
            DataTable var = Obj.MostrarEspecialidades();
            return (var);
        }

        private DataTable MostrarResultados()
        {
            N14Estadisticas Obj = new N14Estadisticas();
            DataTable var = Obj.ListadoEstadistico(anio, semestre, mes, tipoListado, especialidad, tipoCancelacion);
            //DataTable var = Obj.ListadoEstadistico(anio, semestre, -2, tipoListado, -2, -2);
            // DataTable var = Obj.ListadoEstadistico(2015, 2, 1000, 1, 1000, 1000);
            return (var);
        }

        //private void llenarCmbMes()
        //    {
        //   if (rbPrimerSemestre.Checked == true)
        //   {
        //       cmbMes.DataSource = primerSemestre;
        //   }

        //   if (rbSegundoSemestre.Checked == true)
        //   {
        //       cmbMes.DataSource = segundoSemestre;
        //   }
        //    }

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
            //cmbMes.Items.Add("Enero");
            //cmbMes.Items.Add("Febrero");
            //cmbMes.Items.Add("Marzo");
            //cmbMes.Items.Add("Abril");
            //cmbMes.Items.Add("Mayo");
            //cmbMes.Items.Add("Junio");
            //cmbMes.Items.Add("Julio");
            //cmbMes.Items.Add("Agosto");
            //cmbMes.Items.Add("Septiembre");
            //cmbMes.Items.Add("Octubre");
            //cmbMes.Items.Add("Noviembre");
            //cmbMes.Items.Add("Diciembre");
            //cmbMes.SelectedIndex = -1;

            cmbMes.DisplayMember = "Mes";
            cmbMes.ValueMember = "Valor";

            var primerSemestre = new[]
                {
                new { Mes = "Enero", Valor = 1 },
                new { Mes = "Febrero", Valor = 2 },
                new { Mes = "Marzo", Valor = 3 },
                new { Mes = "Abril", Valor = 4 },
                new { Mes = "Mayo", Valor = 5 },
                new { Mes = "Junio", Valor = 6 }
                };

            var segundoSemestre = new[]
                {
                new { Mes = "Julio", Valor = 7 },
                new { Mes = "Agosto", Valor = 8 },
                new { Mes = "Septiembre", Valor = 9 },
                new { Mes = "Octubre", Valor = 10 },
                new { Mes = "Noviembre", Valor = 11 },
                new { Mes = "Diciembre", Valor = 12 }
                };

            if (rbPrimerSemestre.Checked == true)
            {
                cmbMes.DataSource = primerSemestre;
            }

            if (rbSegundoSemestre.Checked == true)
            {
                cmbMes.DataSource = segundoSemestre;
            }




            //cmb Especialidades
            cmbEspecialidad.DataSource = MostrarEspecialidades();
            cmbEspecialidad.DisplayMember = "esp_descripcion";
            cmbEspecialidad.ValueMember = "esp_codigo";
            cmbEspecialidad.SelectedIndex = -1;
            //especialidad = (int)cmbEspecialidad.SelectedValue;

            this.groupBox3.Hide();
            this.rbMedico.Hide();
            this.rbPaciente.Hide();
            this.chkTipoCancelacion.Hide();

            this.label2.Hide();
            this.cmbMes.Hide();

            this.label4.Hide();
            this.cmbEspecialidad.Hide();

            this.chkEspecialidad.Hide();

            this.MostrarResultados();

        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            //asignación combobox anio
            anio = Convert.ToInt32(this.dateTimePicker1.Value.Date.Year);

            //validación y asignación combobox tipo listado
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

            //asignar semestre
            if (rbPrimerSemestre.Checked == true)
            {
                semestre = 1;
            }

            if (rbSegundoSemestre.Checked == true)
            {
                semestre = 2;
            }

            //asignar mes

            mes = Convert.ToInt32(this.cmbMes.SelectedValue);

            if (cmbMes.SelectedIndex == -1 || chkMes.Checked == false)
            {
                mes = -2;
            }



            //asignar especialidad
            if (chkEspecialidad.Checked == false || cmbEspecialidad.SelectedIndex == -1)
            {
                especialidad = -2;
            }
            else
            {
                especialidad = Convert.ToInt32(this.cmbEspecialidad.SelectedValue);
            }


            //asignar tipoCancelacion

            if (chkTipoCancelacion.Checked == false)
            {
                tipoCancelacion = -2;
            }

            if (rbMedico.Checked == true)
            {
                tipoCancelacion = 1;
            }

            if (rbPaciente.Checked == true)
            {
                tipoCancelacion = 0;
            }


            //cargar dataGridView con resultados

            this.dgvResultadosEstadisticas.DataSource = this.MostrarResultados();


        }



        private void cmbTipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbTipoListado.SelectedValue) == 1)
            {
                this.chkTipoCancelacion.Show();
                this.label4.Hide();
                this.cmbEspecialidad.Hide();
                this.chkEspecialidad.Hide();
                this.especialidad = -2;



            }

            if (Convert.ToInt32(cmbTipoListado.SelectedValue) == 2 || Convert.ToInt32(cmbTipoListado.SelectedValue) == 3)
            {
                this.chkTipoCancelacion.Hide();
                this.chkEspecialidad.Show();
                this.tipoCancelacion = -2;
                if (chkEspecialidad.Checked == false || cmbEspecialidad.SelectedIndex == -1)
                {
                    especialidad = -2;
                }
                else
                {
                    especialidad = Convert.ToInt32(this.cmbEspecialidad.SelectedValue);
                }




            }

            if (Convert.ToInt32(cmbTipoListado.SelectedValue) == 4 || Convert.ToInt32(cmbTipoListado.SelectedValue) == 5)
            {
                this.chkTipoCancelacion.Hide();
                this.label4.Hide();
                this.cmbEspecialidad.Hide();
                this.chkEspecialidad.Hide();
                this.especialidad = -2;
                this.tipoCancelacion = -2;



            }

            this.chkEspecialidad.Checked = false;
            this.chkTipoCancelacion.Checked = false;
        }

        private void chkTipoCancelacion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTipoCancelacion.Checked == true)
            {
                this.groupBox3.Show();
                this.rbPaciente.Show();
                this.rbMedico.Show();
            }
            else
            {
                this.groupBox3.Hide();
                this.rbPaciente.Hide();
                this.rbMedico.Hide();
            }

        }

        private void chkMes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkMes.Checked == true)
            {
                this.label2.Show();
                this.cmbMes.Show();

                cmbMes.DisplayMember = "Mes";
                cmbMes.ValueMember = "Valor";

                var primerSemestre = new[]
                {
                new { Mes = "Enero", Valor = 1 },
                new { Mes = "Febrero", Valor = 2 },
                new { Mes = "Marzo", Valor = 3 },
                new { Mes = "Abril", Valor = 4 },
                new { Mes = "Mayo", Valor = 5 },
                new { Mes = "Junio", Valor = 6 }
                };

                var segundoSemestre = new[]
                {
                new { Mes = "Julio", Valor = 7 },
                new { Mes = "Agosto", Valor = 8 },
                new { Mes = "Septiembre", Valor = 9 },
                new { Mes = "Octubre", Valor = 10 },
                new { Mes = "Noviembre", Valor = 11 },
                new { Mes = "Diciembre", Valor = 12 }
                };

                if (rbPrimerSemestre.Checked == true)
                {
                    cmbMes.DataSource = primerSemestre;
                }

                if (rbSegundoSemestre.Checked == true)
                {
                    cmbMes.DataSource = segundoSemestre;
                }
            }
            else
            {
                this.label2.Hide();
                this.cmbMes.Hide();
            }

        }

        private void chkEspecialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEspecialidad.Checked == true)
            {
                this.label4.Show();
                this.cmbEspecialidad.Show();
                especialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
            }
            else
            {
                this.label4.Hide();
                this.cmbEspecialidad.Hide();
                especialidad = -2;
            }
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex == -1 || chkMes.Checked == false)
            {
                mes = -2;
            }
            else
            {
                mes = Convert.ToInt32(this.cmbMes.SelectedValue);
            }

        }




    }
}