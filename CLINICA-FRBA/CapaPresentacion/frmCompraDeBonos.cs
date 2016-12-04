﻿using System;
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
    public partial class frmCompraDeBonos : Form
    {
        string nroAfiliado;
        string nombreAfiliado;
        string apellidoAfiliado;

        int nroAfiliadoInt;

        public frmCompraDeBonos()
        {
            InitializeComponent();
        }

        private void frmCompraDeBonos_Load(object sender, EventArgs e)
        {
            if (frmLogin.passingRol != "Administrador General")
            {
                label1.Text = "Nro. de Afiliado";
                txtNroAfiliado.ReadOnly = true;
                nroAfiliado = (CapaNegocio.N3Usuario.TraerDatosAfiliado(frmLogin.passingText)).
                                    Rows[0][0].ToString();

                nroAfiliadoInt = Convert.ToInt32(nroAfiliado);
                txtNroAfiliado.Text = nroAfiliado;
                apellidoAfiliado = (CapaNegocio.N3Usuario.TraerNombreYApellidoAfiliado(nroAfiliadoInt)).
                                    Rows[0][0].ToString();
                nombreAfiliado = (CapaNegocio.N3Usuario.TraerNombreYApellidoAfiliado(nroAfiliadoInt)).
                                    Rows[0][1].ToString();
                txtNombre.Text = nombreAfiliado + " " + apellidoAfiliado;

                txtPlan.Text = (CapaNegocio.N3Usuario.TraerDatosAfiliado(frmLogin.passingText)).
                                    Rows[0][1].ToString(); 
            }
        }

        private void txtNroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                try
                {
                    nroAfiliadoInt = Convert.ToInt32(txtNroAfiliado.Text);

                    apellidoAfiliado = (CapaNegocio.N3Usuario.TraerNombreYApellidoAfiliado
                                        (nroAfiliadoInt)).Rows[0][0].ToString();
                    nombreAfiliado = (CapaNegocio.N3Usuario.TraerNombreYApellidoAfiliado
                                        (nroAfiliadoInt)).Rows[0][1].ToString();

                    txtNombre.Text = nombreAfiliado + " " + apellidoAfiliado;

                    txtPlan.Text = (CapaNegocio.N3Usuario.ObtenerPlanAfiliado(nroAfiliadoInt)).
                                        Rows[0][0].ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese un numero de afiliado valido", "Clinica FRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
