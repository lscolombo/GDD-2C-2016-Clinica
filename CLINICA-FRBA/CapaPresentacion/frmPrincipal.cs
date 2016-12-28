using System;
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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;

        private string[] funcExistentes = new String[] {"ABM Afiliado",
                                                        "ABM Rol",
                                                        "Cancelar atencion medica",
                                                        "Compra de bonos",
                                                        "Listado Estadistico",
                                                        "Pedir Turno",
                                                        "Registro agenda profesional",
                                                        "Registro de llegada para atencion medica",
                                                        "Registro de resultado para atencion medica"
                                                        };

        private bool[] funcHabilitadas = new bool[] {false,
                                                     false,
                                                     false,
                                                     false,
                                                     false,
                                                     false,
                                                     false,
                                                     false,
                                                     false
                                                     };

        private string[] nombresFunc = new String[10];

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegLlegada frm = new frmRegLlegada();
            frm.MdiParent = this;
            frm.Show();
        }

        private void altaDeAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMAfiliado frm = new frmABMAfiliado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void altaDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMRolInicio frm = new frmABMRolInicio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegResultados frm = new frmRegResultados();
            
            frm.txtUserNameProf.Text = frmLogin.passingText;
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CenterToScreen();

            if (frmRoles.passingRol == null)
                this.GestionUsuario(frmLogin.passingRol);
            else
                this.GestionUsuario(frmRoles.passingRol);
        }

        private void GestionUsuario(string rol)
        {
            DataTable funcionalidades = CapaNegocio.N2Login.MostrarFuncionalidades(rol);

            for (int i = 0; i < funcionalidades.Rows.Count; i++)
                nombresFunc[i] = funcionalidades.Rows[i][0].ToString();

            for (int i = 0; i < funcExistentes.Length; i++)
                for (int j = 0; j < funcionalidades.Rows.Count; j++)
                    if (funcExistentes[i].Equals(funcionalidades.Rows[j][0].ToString()))
                        funcHabilitadas[i] = true;

            this.MnuABM.Visible = true;
            this.MnuAltaAfiliado.Visible = funcHabilitadas[0];
            this.MnuAltaRol.Visible = funcHabilitadas[1];

            if ((funcHabilitadas[0] == false) && (funcHabilitadas[1] == false))
                this.MnuABM.Visible = false;

            this.MnuCancelaciones.Visible = funcHabilitadas[2];
            this.MnuComprar.Visible = funcHabilitadas[3];
            this.MnuListados.Visible = funcHabilitadas[4];
            this.MnuTurnos.Visible = funcHabilitadas[5];

            this.MnuRegistrar.Visible = true;
            this.MnuAgenda.Visible = funcHabilitadas[6];
            this.MnuLlegada.Visible = funcHabilitadas[7];
            this.MnuResultados.Visible = funcHabilitadas[8];

            if ((funcHabilitadas[6] == false) && (funcHabilitadas[7] == false) && (funcHabilitadas[8] == false))
                this.MnuRegistrar.Visible = false;

        }

        private void cancelarAtencionMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLogin.passingRol == "Afiliado")
            {
                frmCancTurnoAfiliado frm = new frmCancTurnoAfiliado();
                frm.MdiParent = this;
                frm.Show();
            }

            if (frmLogin.passingRol == "Profesional")
            {
                frmCancTurnosProf frm = new frmCancTurnosProf();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void MnuSolicitarTurno_Click(object sender, EventArgs e)
        {
            frmPedidoTurno frm = new frmPedidoTurno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompraDeBonos frm = new frmCompraDeBonos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuEstadisticas_Click(object sender, EventArgs e)
        {
            frmEstadisticas frm = new frmEstadisticas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialCambioPlan frm = new frmHistorialCambioPlan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuAgenda_Click(object sender, EventArgs e)
        {
            frmAgendaProf frm = new frmAgendaProf();
            frm.txtUserNameProf.Text = frmLogin.passingText;
            //frm.MdiParent = this;
            //frm.Show();
            frm.Visible = true;
        }
    }
}
