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
    public partial class frmAgendaProf : Form
    {
        public frmAgendaProf()
        {
            InitializeComponent();
        }

        public void ActualizarCargaHoraria()
        {
            Double CargaTotal = 0.0;
            
            if (grpLunes.Enabled) { CargaTotal = CargaTotal + Convert.ToDouble(txtCHL.Text); }
            if (grpMartes.Enabled) { CargaTotal = CargaTotal + Convert.ToDouble(txtCHM.Text); }
            if (grpMiercoles.Enabled) { CargaTotal = CargaTotal + Convert.ToDouble(txtCHX.Text); }
            if (grpJueves.Enabled) { CargaTotal = CargaTotal + Convert.ToDouble(txtCHJ.Text); }
            if (grpViernes.Enabled) { CargaTotal = CargaTotal + Convert.ToDouble(txtCHV.Text); }
            if (grpSabado.Enabled) { CargaTotal = CargaTotal + Convert.ToDouble(txtCHS.Text); }
            txtCargaHoraria.Text = CargaTotal.ToString();
            
        }

        private void frmAgendaProf_Load(object sender, EventArgs e)
        {
            DataGridViewRow Fila;
            dgvListado.DataSource = N8RegAgenda.BuscarLaMatricula(txtUserNameProf.Text);
            Fila = dgvListado.Rows[0];
            txtMatricula.Text = Fila.Cells["prof_matricula"].Value.ToString();

            ActualizarCargaHoraria();

            dtpFechaFin.Text = N8RegAgenda.GetFechaDeSistema();
            dtpFechaIni.Text = N8RegAgenda.GetFechaDeSistema();
            
            //dtpFechaFin.Value.AddDays(1);
        }

        public bool HorarioSuperpuesto(int Ini,int Fin,string Dia)
        {
            //bool SW = true;
            DataGridViewRow Fila;
            int Ti;
            int Tf;
            
            if (Dia == "lu")
            {
                for (int i = 1; i <= dgvL.RowCount;i++)
                {
                    Fila=dgvL.Rows[i-1];
                    Ti = Convert.ToInt32(Fila.Cells["TI"].Value);
                    Tf = Convert.ToInt32(Fila.Cells["TF"].Value);
                    
                    if ((Ti <= Ini && Ini < Tf) || (Ti < Fin && Fin <= Tf)) // detalle con "<" solo, xq no podria dispo. distintas seguidas
                    {
                        return false;
                    }
                }
            }

            if (Dia == "ma")
            {
                for (int i = 1; i <= dgvM.RowCount; i++)
                {
                    Fila = dgvM.Rows[i - 1];
                    Ti = Convert.ToInt32(Fila.Cells[4].Value);
                    Tf = Convert.ToInt32(Fila.Cells[5].Value);

                    if ((Ti <= Ini && Ini < Tf) || (Ti < Fin && Fin <= Tf)) // detalle con "<" solo, xq no podria dispo. distintas seguidas
                    {
                        return false;
                    }
                }
            }

            if (Dia == "mi")
            {
                for (int i = 1; i <= dgvX.RowCount; i++)
                {
                    Fila = dgvX.Rows[i - 1];
                    Ti = Convert.ToInt32(Fila.Cells[4].Value);
                    Tf = Convert.ToInt32(Fila.Cells[5].Value);

                    if ((Ti <= Ini && Ini < Tf) || (Ti < Fin && Fin <= Tf)) // detalle con "<" solo, xq no podria dispo. distintas seguidas
                    {
                        return false;
                    }
                }
            }

            if (Dia == "ju")
            {
                for (int i = 1; i <= dgvJ.RowCount; i++)
                {
                    Fila = dgvJ.Rows[i - 1];
                    Ti = Convert.ToInt32(Fila.Cells[4].Value);
                    Tf = Convert.ToInt32(Fila.Cells[5].Value);

                    if ((Ti <= Ini && Ini < Tf) || (Ti < Fin && Fin <= Tf)) // detalle con "<" solo, xq no podria dispo. distintas seguidas
                    {
                        return false;
                    }
                }
            }
            if (Dia == "vi")
            {
                for (int i = 1; i <= dgvV.RowCount; i++)
                {
                    Fila = dgvV.Rows[i - 1];
                    Ti = Convert.ToInt32(Fila.Cells[4].Value);
                    Tf = Convert.ToInt32(Fila.Cells[5].Value);

                    if ((Ti <= Ini && Ini < Tf) || (Ti < Fin && Fin <= Tf)) // detalle con "<" solo, xq no podria dispo. distintas seguidas
                    {
                        return false;
                    }
                }
            }
            if (Dia == "sa")
            {
                for (int i = 1; i <= dgvS.RowCount; i++)
                {
                    Fila = dgvS.Rows[i - 1];
                    Ti = Convert.ToInt32(Fila.Cells[4].Value);
                    Tf = Convert.ToInt32(Fila.Cells[5].Value);

                    if ((Ti <= Ini && Ini < Tf) || (Ti < Fin && Fin <= Tf)) // detalle con "<" solo, xq no podria dispo. distintas seguidas
                    {
                        return false;
                    }
                }
            }

            return true;
        }
                

        public void setTxtMatricula(int Matricula)
        {
            txtMatricula.Text = Matricula.ToString();
        }

        private void LlenarCombosHorasLV(frmAgendaProfLV frmAgendaProfLV)
        {
            frmAgendaProfLV.cbbRangoIniL.Items.Add("7:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("7:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("8:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("8:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("9:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("9:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("10:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("10:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("11:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("11:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("12:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("12:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("13:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("13:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("14:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("14:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("15:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("15:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("16:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("16:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("17:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("17:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("18:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("18:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("19:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("19:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("20:00");

            frmAgendaProfLV.cbbRangoFinL.Items.Add("7:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("7:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("8:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("8:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("9:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("9:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("10:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("10:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("11:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("11:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("12:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("12:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("13:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("13:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("14:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("14:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("15:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("15:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("16:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("16:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("17:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("17:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("18:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("18:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("19:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("19:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("20:00");
        }

        private void LlenarCombosHorasS(frmAgendaProfLV frmAgendaProfLV)
        {
                        
            frmAgendaProfLV.cbbRangoIniL.Items.Add("10:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("10:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("11:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("11:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("12:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("12:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("13:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("13:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("14:00");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("14:30");
            frmAgendaProfLV.cbbRangoIniL.Items.Add("15:00");
            
            frmAgendaProfLV.cbbRangoFinL.Items.Add("10:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("10:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("11:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("11:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("12:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("12:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("13:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("13:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("14:00");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("14:30");
            frmAgendaProfLV.cbbRangoFinL.Items.Add("15:00");
        }

        
        private void dgvL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkLunes_CheckedChanged(object sender, EventArgs e)
        {
            grpLunes.Enabled = chkLunes.Checked;
            ActualizarCargaHoraria();
            
        }

        private void chkMartes_CheckedChanged(object sender, EventArgs e)
        {
            grpMartes.Enabled = chkMartes.Checked;
            ActualizarCargaHoraria();
        }

        private void chkMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            grpMiercoles.Enabled = chkMiercoles.Checked;
            ActualizarCargaHoraria();
        }

        private void chkJueves_CheckedChanged(object sender, EventArgs e)
        {
            grpJueves.Enabled = chkJueves.Checked;
            ActualizarCargaHoraria();
        }

        private void chkViernes_CheckedChanged(object sender, EventArgs e)
        {
            grpViernes.Enabled = chkViernes.Checked;
            ActualizarCargaHoraria();
        }

        private void chkSabado_CheckedChanged(object sender, EventArgs e)
        {
            grpSabado.Enabled = chkSabado.Checked;
            ActualizarCargaHoraria();
        }

        private void btnAddEspecialidadL_Click(object sender, EventArgs e)
        {
            frmAgendaProfLV frmAgendaProfLV = new frmAgendaProfLV();

            frmAgendaProfLV.setTxtMatricula(txtMatricula.Text, this, "lu");
            LlenarCombosHorasLV(frmAgendaProfLV);

            frmAgendaProfLV.Visible = true;

        }

        private void btnAddEspecialidadM_Click(object sender, EventArgs e)
        {
            frmAgendaProfLV frmAgendaProfLV = new frmAgendaProfLV();

            frmAgendaProfLV.setTxtMatricula(txtMatricula.Text, this, "ma");
            LlenarCombosHorasLV(frmAgendaProfLV);

            frmAgendaProfLV.Visible = true;
        }

        private void btnAddEspecialidadX_Click(object sender, EventArgs e)
        {
            frmAgendaProfLV frmAgendaProfLV = new frmAgendaProfLV();

            frmAgendaProfLV.setTxtMatricula(txtMatricula.Text, this, "mi");
            LlenarCombosHorasLV(frmAgendaProfLV);

            frmAgendaProfLV.Visible = true;
        }

        private void btnAddEspecialidadJ_Click(object sender, EventArgs e)
        {
            frmAgendaProfLV frmAgendaProfLV = new frmAgendaProfLV();

            frmAgendaProfLV.setTxtMatricula(txtMatricula.Text, this, "ju");
            LlenarCombosHorasLV(frmAgendaProfLV);

            frmAgendaProfLV.Visible = true;
        }

        private void btnAddEspecialidadV_Click(object sender, EventArgs e)
        {
            frmAgendaProfLV frmAgendaProfLV = new frmAgendaProfLV();

            frmAgendaProfLV.setTxtMatricula(txtMatricula.Text, this, "vi");
            LlenarCombosHorasLV(frmAgendaProfLV);

            frmAgendaProfLV.Visible = true;
        }

        private void btnAddEspecialidadS_Click(object sender, EventArgs e)
        {
            frmAgendaProfLV frmAgendaProfLV = new frmAgendaProfLV();

            frmAgendaProfLV.setTxtMatricula(txtMatricula.Text, this, "sa");
            LlenarCombosHorasS(frmAgendaProfLV);

            frmAgendaProfLV.Visible = true;
        }

        private void grpViernes_Enter(object sender, EventArgs e)
        {

        }

        private void grpJueves_Enter(object sender, EventArgs e)
        {

        }

        private void grpMiercoles_Enter(object sender, EventArgs e)
        {

        }

        private void grpLunes_Enter(object sender, EventArgs e)
        {

        }

        private void grpMartes_Enter(object sender, EventArgs e)
        {

        }

        private void grpSabado_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = dgvL.Rows.Count.ToString();
        }

        private void txtCHX_TextChanged(object sender, EventArgs e)
        {

        }

        private bool PuedeRegAgenda()
        {
            if (grpLunes.Enabled)
            {
                if (dgvL.RowCount <= 0)
                {
                    return false;
                }                
            }
            if (grpMartes.Enabled)
            {
                if (dgvM.RowCount <= 0)
                {
                    return false;
                }
            }
            if (grpMiercoles.Enabled)
            {
                if (dgvX.RowCount <= 0)
                {
                    return false;
                }
            }
            if (grpJueves.Enabled)
            {
                if (dgvJ.RowCount <= 0)
                {
                    return false;
                }
            }
            if (grpViernes.Enabled)
            {
                if (dgvV.RowCount <= 0)
                {
                    return false;
                }
            }
            if (grpSabado.Enabled)
            {
                if (dgvS.RowCount <= 0)
                {
                    return false;
                }
            }
            if(grpLunes.Enabled==false && grpMartes.Enabled==false && grpMiercoles.Enabled==false && grpJueves.Enabled==false && grpViernes.Enabled==false && grpSabado.Enabled==false)
            {
                return false;
            }

            return true;
        }

        private void btnRegAgenda_Click(object sender, EventArgs e)
        {
            if (PuedeRegAgenda())
            {
                dgvListado.DataSource = N8RegAgenda.VerificarElRangoFechas(Convert.ToInt32(txtMatricula.Text), dtpFechaIni.Value.ToString(), dtpFechaFin.Value.ToString());
                
                if (dgvListado.RowCount == 0)
                {
                    DataGridViewRow Fila;
                    int IdAgenda;
                    int unaMatricula;
                    int unaEspecialidad;
                    string horaIni;
                    string horaFin;
                    //MessageBox.Show("registra (break line)"); //
                    N8RegAgenda.InsertarEnAgenda(Convert.ToInt32(txtMatricula.Text), dtpFechaIni.Value, dtpFechaFin.Value, Convert.ToDouble(txtCargaHoraria.Text));
                    dgvListado.DataSource = N8RegAgenda.BuscarIdEnAgenda(Convert.ToInt32(txtMatricula.Text), dtpFechaIni.Value.ToString(), dtpFechaFin.Value.ToString());
                    Fila = dgvListado.Rows[0];
                    IdAgenda = Convert.ToInt32(Fila.Cells["agen_id"].Value);

                    if (grpLunes.Enabled)
                    {
                        for (int i = 1; i <= dgvL.RowCount; i++)
                        {
                            Fila = dgvL.Rows[i - 1];
                            unaMatricula = Convert.ToInt32(txtMatricula.Text);
                            unaEspecialidad = Convert.ToInt32(Fila.Cells[0].Value);
                            horaIni = Fila.Cells[2].Value.ToString();
                            horaFin = Fila.Cells[3].Value.ToString();

                            N8RegAgenda.InsertarEnDisponibilidad(IdAgenda, unaMatricula, unaEspecialidad, "Lunes", horaIni, horaFin);
                        }
                    }

                    if (grpMartes.Enabled)
                    {
                        for (int i = 1; i <= dgvM.RowCount; i++)
                        {
                            Fila = dgvM.Rows[i - 1];
                            unaMatricula = Convert.ToInt32(txtMatricula.Text);
                            unaEspecialidad = Convert.ToInt32(Fila.Cells[0].Value);
                            horaIni = Fila.Cells[2].Value.ToString();
                            horaFin = Fila.Cells[3].Value.ToString();

                            N8RegAgenda.InsertarEnDisponibilidad(IdAgenda, unaMatricula, unaEspecialidad, "Martes", horaIni, horaFin);
                        }
                    }

                    if (grpMiercoles.Enabled)
                    {
                        for (int i = 1; i <= dgvX.RowCount; i++)
                        {
                            Fila = dgvX.Rows[i - 1];
                            unaMatricula = Convert.ToInt32(txtMatricula.Text);
                            unaEspecialidad = Convert.ToInt32(Fila.Cells[0].Value);
                            horaIni = Fila.Cells[2].Value.ToString();
                            horaFin = Fila.Cells[3].Value.ToString();

                            N8RegAgenda.InsertarEnDisponibilidad(IdAgenda, unaMatricula, unaEspecialidad, "Miércoles", horaIni, horaFin);
                        }
                    }

                    if (grpJueves.Enabled)
                    {
                        for (int i = 1; i <= dgvJ.RowCount; i++)
                        {
                            Fila = dgvJ.Rows[i - 1];
                            unaMatricula = Convert.ToInt32(txtMatricula.Text);
                            unaEspecialidad = Convert.ToInt32(Fila.Cells[0].Value);
                            horaIni = Fila.Cells[2].Value.ToString();
                            horaFin = Fila.Cells[3].Value.ToString();

                            N8RegAgenda.InsertarEnDisponibilidad(IdAgenda, unaMatricula, unaEspecialidad, "Jueves", horaIni, horaFin);
                        }
                    }

                    if (grpViernes.Enabled)
                    {
                        for (int i = 1; i <= dgvV.RowCount; i++)
                        {
                            Fila = dgvV.Rows[i - 1];
                            unaMatricula = Convert.ToInt32(txtMatricula.Text);
                            unaEspecialidad = Convert.ToInt32(Fila.Cells[0].Value);
                            horaIni = Fila.Cells[2].Value.ToString();
                            horaFin = Fila.Cells[3].Value.ToString();

                            N8RegAgenda.InsertarEnDisponibilidad(IdAgenda, unaMatricula, unaEspecialidad, "Viernes", horaIni, horaFin);
                        }
                    }

                    if (grpSabado.Enabled)
                    {
                        for (int i = 1; i <= dgvS.RowCount; i++)
                        {
                            Fila = dgvS.Rows[i - 1];
                            unaMatricula = Convert.ToInt32(txtMatricula.Text);
                            unaEspecialidad = Convert.ToInt32(Fila.Cells[0].Value);
                            horaIni = Fila.Cells[2].Value.ToString();
                            horaFin = Fila.Cells[3].Value.ToString();

                            N8RegAgenda.InsertarEnDisponibilidad(IdAgenda, unaMatricula, unaEspecialidad, "Sábado", horaIni, horaFin);
                        }
                    }

                    btnRegAgenda.Enabled = false;
                    //N8RegAgenda.RegistrarLosTurnos(Convert.ToInt32(txtMatricula.Text)); //solo para una agendaXprof
                    N8RegAgenda.RegistrarLosTurnos(IdAgenda);
                    MessageBox.Show("Agenda del Profesional registrado, con sus respectivos turnos", "Registro de Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNewAgenda.Enabled = true;

                }
                else
                {
                    MessageBox.Show("El rango de fechas se superpone con otra agenda del profesional", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe tener al menos un dia seleccionado con datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dtpFechaIni_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaIni.Value >= Convert.ToDateTime(N8RegAgenda.GetFechaDeSistema()))
            {
                dtpFechaFin.Enabled = true;
                dtpFechaFin.Text = dtpFechaIni.Text;
            }
            else
            {
                //dtpFechaIni.Text = N8RegAgenda.GetFechaDeSistema();
                dtpFechaFin.Enabled = false;
                btnRegAgenda.Enabled = false;
                MessageBox.Show("La fecha inicial debe ser posterior a la fecha de sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value < dtpFechaIni.Value)
            {
                btnRegAgenda.Enabled = false;
                MessageBox.Show("La fecha final debe ser posterior a la fecha inicial", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnRegAgenda.Enabled = true;
            }
        }

        private void btnNewAgenda_Click(object sender, EventArgs e)
        {
            dgvL.Rows.Clear();
            dgvM.Rows.Clear();
            dgvX.Rows.Clear();
            dgvJ.Rows.Clear();
            dgvV.Rows.Clear();
            dgvS.Rows.Clear();

            chkLunes.Checked = false;
            chkMartes.Checked = false;
            chkMiercoles.Checked = false;
            chkJueves.Checked = false;
            chkViernes.Checked = false;
            chkSabado.Checked = false;

            txtCHL.Text = "0";
            txtCHM.Text = "0";
            txtCHX.Text = "0";
            txtCHJ.Text = "0";
            txtCHV.Text = "0";
            txtCHS.Text = "0";
            btnNewAgenda.Enabled = false;
        }
    }
}