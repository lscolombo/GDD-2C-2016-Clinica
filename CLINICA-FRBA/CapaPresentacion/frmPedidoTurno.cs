﻿using System;
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
        private string matricula;        
        private string usuarioProf;

        private string nombreProf;
        private string apellidoProf;

        private string fechaDeseada;
        private string idTurno;

        private int nroAfiliado;
        private string nroAfiliadoString;
        private string rtaTurno;

        private string matriculaAux;

        public frmPedidoTurno()
        {
            InitializeComponent();
            this.llenarComboEspecialidad();
            especialidad = this.cbEspecialidades.SelectedValue.ToString();
            textBox1.Text = especialidad;
            //this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);
            //this.dgvProfesionales.Columns[0].Visible = false;
            //txtProfesional.Text = (CapaNegocio.N10Turno.TraerEspecialidad(especialidad)).Rows[0][0].ToString();
        }

        private void llenarComboEspecialidad()
        {
            cbEspecialidades.DataSource = N10Turno.MostrarEspecialidades();
            cbEspecialidades.ValueMember = "esp_codigo";
            cbEspecialidades.DisplayMember = "esp_descripcion";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPedidoTurno_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);

            dtpFecha.Text = N8RegAgenda.GetFechaDeSistema();
        }

        private void cbEspecialidades_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            especialidad = this.cbEspecialidades.SelectedValue.ToString();
            textBox1.Text = especialidad;
            btnPedirTurno.Enabled = false;
            btnTurno.Enabled = false;
            txtProfesional.Clear();
            txtEleccion.Clear();
            dgvProfesionales.DataSource = null;
            cbTurnos.DataSource = null; //
        }

        // Boton "Buscar profesionales"
        private void button2_Click(object sender, EventArgs e)
        {
            this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);
            this.dgvProfesionales.Columns[0].Visible = false;
            txtProfesional.Text = (CapaNegocio.N10Turno.TraerEspecialidad(especialidad)).Rows[0][0].ToString();

            btnPedirTurno.Enabled = false;
            cbTurnos.DataSource = null;

            // Guardo el codigo de la especialidad en un String
            especialidad = this.cbEspecialidades.SelectedValue.ToString();
        }

        private void dgvProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarioProf = Convert.ToString(this.dgvProfesionales.CurrentRow.Cells["user_username"].Value);

            nombreProf = Convert.ToString(this.dgvProfesionales.CurrentRow.Cells["Nombre"].Value);
            apellidoProf = Convert.ToString(this.dgvProfesionales.CurrentRow.Cells["Apellido"].Value);
            txtEleccion.Text = "Dr. " + nombreProf + " " + apellidoProf;

            btnTurno.Enabled = true;
            cbTurnos.DataSource = null;
            // Guardo la matricula en un string
            matricula = (CapaNegocio.N10Turno.TraerMatricula(usuarioProf)).Rows[0][0].ToString();
            
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            fechaDeseada = dtpFecha.Value.ToString("yyyyMMdd");
            //textBox2.Text = fechaDeseada;
            this.llenarComboTurnos();

            //dgvProfesionales.Enabled = false;
            //btnPedirTurno.Enabled = true;
        }

        private void llenarComboTurnos()
        {
            cbTurnos.DataSource = N10Turno.MostrarTurnos(fechaDeseada, matricula, especialidad);
            cbTurnos.ValueMember = "turn_id";
            cbTurnos.DisplayMember = "turn_fecha";

            // Toma el id
            //idTurno = cbTurnos.SelectedValue.ToString();
        }

        private void btnPedirTurno_Click(object sender, EventArgs e)
        {
            // Si iniciamos la app directamente de este form rompe xq toma datos desde el login
            nroAfiliadoString = (CapaNegocio.N3Usuario.TraerDatosAfiliado
                                    (frmLogin.passingText)).Rows[0][0].ToString();
            nroAfiliado = Convert.ToInt32(nroAfiliadoString);
            //textBox4.Text = Convert.ToString(nroAfiliado);
            //textBox3.Text = idTurno;

            if (frmLogin.passingRol == "Afiliado")
            {
                matriculaAux = (CapaNegocio.N3Usuario.
                        ProfesionalQueTambienEsAfiliado(nroAfiliado)).ToString();
            }

            if (frmLogin.passingRol == "Afiliado" && matriculaAux == matricula)
                MessageBox.Show("No puede asignarse un turno con usted mismo",
                        "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                rtaTurno = CapaNegocio.N10Turno.InsertarAfiliadoEnTurno
                                (idTurno, nroAfiliado);

                if (rtaTurno == "OK")
                {
                    MessageBox.Show("El turno " + idTurno + " (" + cbTurnos.Text + ") ha sido reservado con exito",
                           "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProfesional.Clear();
                    txtEleccion.Clear();
                    dgvProfesionales.DataSource = null;
                    //cbTurnos.DataSource = null;
                    btnTurno.Enabled = false;
                    btnPedirTurno.Enabled = false;

                    dgvProfesionales.Enabled = true;
                }
                else
                    MessageBox.Show(rtaTurno, "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTurnos_SelectedValueChanged(object sender, EventArgs e)
        {
            //idTurno = cbTurnos.SelectedValue.ToString();            
        }

        private void cbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTurnos.DataSource != null)
            {
                idTurno = cbTurnos.SelectedValue.ToString();
                btnPedirTurno.Enabled = true;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            btnPedirTurno.Enabled = false;
            cbTurnos.DataSource = null;
            if (dtpFecha.Value < Convert.ToDateTime(N8RegAgenda.GetFechaDeSistema()))
            {
                //cbTurnos.DataSource = null;
                dtpFecha.Text = N8RegAgenda.GetFechaDeSistema();
                MessageBox.Show("La fecha debe ser posterior a la fecha de sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
