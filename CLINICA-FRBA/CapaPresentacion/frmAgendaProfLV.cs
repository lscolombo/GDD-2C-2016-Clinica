using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio; /*PARA TENER REFERENCIA DE LAS CLASES DE OTRA CAPA*/

namespace CapaPresentacion
{
    public partial class frmAgendaProfLV : Form
    {
        frmAgendaProf frmPadre;// = new frmAgendaProf();
        string dgvDia = "";

        public frmAgendaProfLV()
        {
            InitializeComponent();
        }

        private void frmAgendaProfLV_Load(object sender, EventArgs e)
        {
            //comboBox
            cbbEspecialidadL.DataSource = N8RegAgenda.MostrarLasEspecialidades(Convert.ToInt32(txtMatricula.Text));
            cbbEspecialidadL.DisplayMember = "esp_descripcion";
            cbbEspecialidadL.ValueMember = "esp_codigo";
            
        }

        public void setTxtMatricula(string Matricula, frmAgendaProf unPadre, string unDgvDia)
        {

            txtMatricula.Text = Matricula;
            frmPadre = unPadre;
            dgvDia = unDgvDia;
        }

        private Double CantidadDeHoras()
        { 
            return ((cbbRangoFinL.SelectedIndex * 0.5)-(cbbRangoIniL.SelectedIndex * 0.5));
        }

        private void btnAddEspecialidad_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(frmPadre.txtCargaHoraria.Text) + CantidadDeHoras() > 48.0)
            {
                MessageBox.Show("No se puede agregar la especialidad, desborda las 48 Hs semanales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (dgvDia == "lu")
                {
                    if (frmPadre.HorarioSuperpuesto(Convert.ToInt32(cbbRangoIniL.SelectedIndex), Convert.ToInt32(cbbRangoFinL.SelectedIndex), dgvDia))
                    {
                        frmPadre.txtCHL.Text = (Convert.ToDouble(frmPadre.txtCHL.Text) + CantidadDeHoras()).ToString();
                        frmPadre.ActualizarCargaHoraria();
                        frmPadre.dgvL.Rows.Add(cbbEspecialidadL.SelectedValue, cbbEspecialidadL.Text, cbbRangoIniL.Text, cbbRangoFinL.Text, cbbRangoIniL.SelectedIndex, cbbRangoFinL.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar la especialidad, horario superpuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dgvDia == "ma")
                {
                    if (frmPadre.HorarioSuperpuesto(Convert.ToInt32(cbbRangoIniL.SelectedIndex), Convert.ToInt32(cbbRangoFinL.SelectedIndex), dgvDia))
                    {
                        frmPadre.txtCHM.Text = (Convert.ToDouble(frmPadre.txtCHM.Text) + CantidadDeHoras()).ToString();
                        frmPadre.ActualizarCargaHoraria();
                        frmPadre.dgvM.Rows.Add(cbbEspecialidadL.SelectedValue, cbbEspecialidadL.Text, cbbRangoIniL.Text, cbbRangoFinL.Text, cbbRangoIniL.SelectedIndex, cbbRangoFinL.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar la especialidad, horario superpuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dgvDia == "mi")
                {
                    if (frmPadre.HorarioSuperpuesto(Convert.ToInt32(cbbRangoIniL.SelectedIndex), Convert.ToInt32(cbbRangoFinL.SelectedIndex), dgvDia))
                    {
                        frmPadre.txtCHX.Text = (Convert.ToDouble(frmPadre.txtCHX.Text) + CantidadDeHoras()).ToString();
                        frmPadre.ActualizarCargaHoraria();
                        frmPadre.dgvX.Rows.Add(cbbEspecialidadL.SelectedValue, cbbEspecialidadL.Text, cbbRangoIniL.Text, cbbRangoFinL.Text, cbbRangoIniL.SelectedIndex, cbbRangoFinL.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar la especialidad, horario superpuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dgvDia == "ju")
                {
                    if (frmPadre.HorarioSuperpuesto(Convert.ToInt32(cbbRangoIniL.SelectedIndex), Convert.ToInt32(cbbRangoFinL.SelectedIndex), dgvDia))
                    {
                        frmPadre.txtCHJ.Text = (Convert.ToDouble(frmPadre.txtCHJ.Text) + CantidadDeHoras()).ToString();
                        frmPadre.ActualizarCargaHoraria();
                        frmPadre.dgvJ.Rows.Add(cbbEspecialidadL.SelectedValue, cbbEspecialidadL.Text, cbbRangoIniL.Text, cbbRangoFinL.Text, cbbRangoIniL.SelectedIndex, cbbRangoFinL.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar la especialidad, horario superpuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dgvDia == "vi")
                {
                    if (frmPadre.HorarioSuperpuesto(Convert.ToInt32(cbbRangoIniL.SelectedIndex), Convert.ToInt32(cbbRangoFinL.SelectedIndex), dgvDia))
                    {
                        frmPadre.txtCHV.Text = (Convert.ToDouble(frmPadre.txtCHV.Text) + CantidadDeHoras()).ToString();
                        frmPadre.ActualizarCargaHoraria();
                        frmPadre.dgvV.Rows.Add(cbbEspecialidadL.SelectedValue, cbbEspecialidadL.Text, cbbRangoIniL.Text, cbbRangoFinL.Text, cbbRangoIniL.SelectedIndex, cbbRangoFinL.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar la especialidad, horario superpuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dgvDia == "sa")
                {
                    if (frmPadre.HorarioSuperpuesto(Convert.ToInt32(cbbRangoIniL.SelectedIndex), Convert.ToInt32(cbbRangoFinL.SelectedIndex), dgvDia))
                    {
                        frmPadre.txtCHS.Text = (Convert.ToDouble(frmPadre.txtCHS.Text) + CantidadDeHoras()).ToString();
                        frmPadre.ActualizarCargaHoraria();
                        frmPadre.dgvS.Rows.Add(cbbEspecialidadL.SelectedValue, cbbEspecialidadL.Text, cbbRangoIniL.Text, cbbRangoFinL.Text, cbbRangoIniL.SelectedIndex, cbbRangoFinL.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar la especialidad, horario superpuesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cbbRangoIniL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbbRangoFinL.SelectedIndex = -1;
            btnAddEspecialidad.Enabled = false;
        }

        private void cbbRangoFinL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbRangoFinL.SelectedIndex <= cbbRangoIniL.SelectedIndex)
            {
                btnAddEspecialidad.Enabled = false;
                MessageBox.Show("La hora fin debe ser mayor a la hora inicial", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnAddEspecialidad.Enabled = true;
            }
        }
    }
}
