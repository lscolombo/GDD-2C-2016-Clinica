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
    public partial class frmAltaRol : Form
    {
        public frmAltaRol()
        {
            InitializeComponent();
        }

        private void nombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            N1ABMRol abm = new N1ABMRol();
            if (abm.crearRol(nombreRol.Text) == 0) //Verifico si el rol existe
            {
                MessageBox.Show("El rol que ingresó ya existe. Ingrese otro rol", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Rol creado exitosamente", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                { //Si el usuario clickea en el boton OK
                    DialogResult result2 = MessageBox.Show("Seleccione la funcionalidad que desea agregar", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    { //Si el usuario clickea en el boton OK
                        nombreRol.Enabled = false;
                        btnCrearRol.Enabled = false;
                        funcionalidades.Enabled = true;
                        btnAgregarFuncionalidad.Enabled = true;
                        DataTable listaDeFuncionalidades = abm.getFuncionalidades(nombreRol.Text); //Obtengo las funcionalidades que aún no tiene el rol
                        foreach (DataRow fila in listaDeFuncionalidades.Rows) //Recorro todas las filas del datatable
                        {
                            funcionalidades.Items.Add(fila[0].ToString()); //Agrego al combobox el elemento de la columna 0 de esa fila (en este caso solo hay una que es func_descripcion)
                        }
                    }
                }
            }
        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            N1ABMRol abm = new N1ABMRol();
            if (funcionalidades.SelectedIndex.Equals(-1)) //Verifico que si se selecciono algo en el ComboBox
            {
                MessageBox.Show("Selección vacía. Seleccione una funcionalidad para agregar", "ClinicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                abm.agregarFuncionalidadARol(nombreRol.Text, funcionalidades.Text);
                funcionalidades.Items.Clear(); //Borro todos los elementos del combobox
                funcionalidades.Refresh(); //Recargo el combobox para que reconozca el borrado de sus elementos
                DataTable listaDeFuncionalidades = abm.getFuncionalidades(nombreRol.Text);
                if (listaDeFuncionalidades.Rows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Funcionalidad agregada exitosamente", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DialogResult result2 = MessageBox.Show("Desea agregar alguna funcionalidad más a este rol?", "ClínicaFRBA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result2 == DialogResult.Yes)
                        {
                            foreach (DataRow fila in listaDeFuncionalidades.Rows)
                            {
                                funcionalidades.Items.Add(fila[0].ToString());
                            }
                        }
                        else
                        {
                            nombreRol.Enabled = true;
                            btnCrearRol.Enabled = true;
                            funcionalidades.Items.Clear();
                            funcionalidades.Enabled = false;
                            btnAgregarFuncionalidad.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Todas las funcionalidades del sistema han sido asignadas al rol. Ingrese un nuevo rol", "ClinicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nombreRol.Enabled = true;
                    btnCrearRol.Enabled = true;
                    funcionalidades.Items.Clear();
                    funcionalidades.Enabled = false;
                    btnAgregarFuncionalidad.Enabled = false;
                }
            }
        }

        private void funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
