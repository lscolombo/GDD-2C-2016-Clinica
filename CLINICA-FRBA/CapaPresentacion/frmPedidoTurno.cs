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

        public frmPedidoTurno()
        {
            InitializeComponent();
            this.llenarComboEspecialidad();
            especialidad = this.cbEspecialidades.SelectedValue.ToString();
            textBox1.Text = especialidad;
            this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);
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
            textBox1.Text = especialidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPedidoTurno_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.dgvProfesionales.DataSource = CapaNegocio.N10Turno.MostrarProfesionales(especialidad);
        }
    }
}
