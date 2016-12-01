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
    public partial class frmModificarRol : Form
    {
        //Variables para asegurare el correcto funcionamiento del btnAceptar_Click

        private bool estoyCambiandoNombre = false;
        private bool estoyAgregandoUnaFuncionalidad = false;
        private bool estoyEliminandoUnaFuncionalidad = false;
        private bool estoyHabilitandoUnRol = false;

        //Variable para recuperar el nombre en caso de cancelar
        private String nombre;

        public frmModificarRol()
        {
            InitializeComponent();
        }

        private void tablaDeRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaDeRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) /*SI SE SELECCIONO UN REGISTRO DE LOS MOSTRADOS EN EL DATAGRIDVIEW, TENGO UN INDEX DEL REGISTRO*/
            {
                DataGridViewRow Fila = this.tablaDeRoles.Rows[e.RowIndex]; /*OBJETO Q USO PARA GUARDAR EL REGISTRO COMPLETO SEGUN EL INDEX*/

                /*APARTIR DE ACA SOLO GUARDO EN CONTROLES TEXTBOX LOS RESPECTIVOS CAMPOS DEL REGISTRO SELECCIONADO*/
                this.idRol.Text = Fila.Cells["Id"].Value.ToString();
                this.nombreRol.Text = Fila.Cells["Nombre"].Value.ToString();
                nombre = Fila.Cells["Nombre"].Value.ToString();
                this.habilitado.Text = Fila.Cells["Habilitado"].Value.ToString();

                btnCambiarNombre.Enabled = true;
                btnAgregarFuncionalidad.Enabled = true;
                btnEliminarFuncionalidad.Enabled = true;

                if (Fila.Cells["Habilitado"].Value.ToString() == "SI")
                {
                    btnHabilitar.Enabled = false;
                }

                if (Fila.Cells["Habilitado"].Value.ToString() == "NO")
                {
                    btnHabilitar.Enabled = true;
                }

            }
        }

        private void frmModificarRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.tablaDeRoles.DataSource = N1ABMRol.mostrarRoles();
            if (tablaDeRoles.RowCount == 0) {
                MessageBox.Show("Actualmente no hay roles en el sistema", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void habilitado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //EVENTO CLICK PARA EL BOTON CAMBIAR NOMBRE

        private void btnCambiarNombre_Click(object sender, EventArgs e)
        {
            nombreRol.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAgregarFuncionalidad.Enabled = false;
            btnEliminarFuncionalidad.Enabled = false;
            btnHabilitar.Enabled = false;
            tablaDeRoles.Enabled = false;
            estoyCambiandoNombre = true;
        }

        //EVENTO CLICK PARA EL BOTON AGREGAR FUNCIONALIDAD

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            N1ABMRol abm = new N1ABMRol();
            DataTable listaDeFuncionalidades = abm.getFuncionalidades(nombreRol.Text); //Obtengo las funcionalidades que aun no tiene asignadas el rol
            if (listaDeFuncionalidades.Rows.Count != 0)
            {
                if (btnAceptar.Enabled == false)
                {
                    DialogResult result2 = MessageBox.Show("Seleccione la funcionalidad que desea agregar", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    { //Si el usuario clickea en el boton OK
                        funcionalidades.Enabled = true;
                        btnAceptar.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnCambiarNombre.Enabled = false;
                        btnEliminarFuncionalidad.Enabled = false;
                        btnHabilitar.Enabled = false;
                        tablaDeRoles.Enabled = false;
                        foreach (DataRow fila in listaDeFuncionalidades.Rows) //Recorro todas las filas del datatable
                        {
                            funcionalidades.Items.Add(fila[0].ToString()); //Agrego al combobox el elemento de la columna 0 de esa fila (en este caso solo hay una que es func_descripcion)
                        }
                        estoyAgregandoUnaFuncionalidad = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Todas las funcionalidades del sistema han sido asignadas al rol. Seleccione otro rol a modificar o una acción distinta", "ClinicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //EVENTO CLICK PARA EL BOTON EDITAR ESTADO HABILITADO

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            habilitado.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAgregarFuncionalidad.Enabled = false;
            btnEliminarFuncionalidad.Enabled = false;
            btnCambiarNombre.Enabled = false;
            tablaDeRoles.Enabled = false;
            estoyHabilitandoUnRol = true;
        }

        //EVENTO CLICK PARA EL BOTON ELIMINAR FUNCIONALIDAD

        private void btnEliminarFuncionalidad_Click(object sender, EventArgs e)
        {
            N1ABMRol abm = new N1ABMRol();
            DataTable listaDeFuncionalidades = abm.getFuncionalidadesAsignadas(nombreRol.Text); //Obtengo las funcionalidades asignadas del rol
            if (listaDeFuncionalidades.Rows.Count != 0)
            {
                if (btnAceptar.Enabled == false)
                {
                    DialogResult result2 = MessageBox.Show("Seleccione la funcionalidad que desea eliminar", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    { //Si el usuario clickea en el boton OK
                        funcionalidades.Enabled = true;
                        btnAceptar.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnCambiarNombre.Enabled = false;
                        btnAgregarFuncionalidad.Enabled = false;
                        btnHabilitar.Enabled = false;
                        tablaDeRoles.Enabled = false;
                        foreach (DataRow fila in listaDeFuncionalidades.Rows) //Recorro todas las filas del datatable
                        {
                            funcionalidades.Items.Add(fila[0].ToString()); //Agrego al combobox el elemento de la columna 0 de esa fila (en este caso solo hay una que es func_descripcion)
                        }
                        estoyEliminandoUnaFuncionalidad = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("El rol seleccionado no posee funcionalidades asignadas. Seleccione otro rol a modificar o una acción distinta", "ClinicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //EVENTO CLICK PARA EL BOTON ACEPTAR

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //SI ESTOY CONFIRMANDO EL CAMBIO DE UN NOMBRE...

            if (btnCambiarNombre.Enabled == true && estoyCambiandoNombre)
            {
                if (nombreRol.Text != "")
                {
                    N1ABMRol.cambiarNombreRol(Convert.ToInt32(idRol.Text), nombreRol.Text);
                    nombreRol.Enabled = false;
                    funcionalidades.Enabled = false;
                    habilitado.Enabled = false;
                    btnAgregarFuncionalidad.Enabled = false;
                    btnCambiarNombre.Enabled = false;
                    btnEliminarFuncionalidad.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    tablaDeRoles.Enabled = true;
                    this.idRol.Text = "";
                    this.nombreRol.Text = "";
                    this.habilitado.Text = "";
                    this.habilitado.SelectedIndex = -1; //Hago que se muestre vacío el combobox en tiempo de ejecución


                    if (habilitado.Text == "SI")
                    {
                        btnHabilitar.Enabled = false;
                    }
                    estoyCambiandoNombre = false;
                    this.tablaDeRoles.DataSource = N1ABMRol.mostrarRoles();
                    MessageBox.Show("Cambio de nombre de rol exitoso", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nombre de rol vacío. Inserte el nombre del rol", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //SI ESTOY CONFIRMANDO EL AGREGADO DE UNA FUNCIONALIDAD A UN ROL...

            if (btnAgregarFuncionalidad.Enabled == true && estoyAgregandoUnaFuncionalidad)
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
                                    funcionalidades.Items.Add(fila[0].ToString());//Agrego las funcionalidades restantes al combobox
                                }
                            }
                            else
                            {
                                nombreRol.Enabled = false;
                                funcionalidades.Enabled = false;
                                habilitado.Enabled = false;
                                btnAgregarFuncionalidad.Enabled = true;
                                btnCambiarNombre.Enabled = true;
                                btnEliminarFuncionalidad.Enabled = true;
                                btnAceptar.Enabled = false;
                                btnCancelar.Enabled = false;
                                tablaDeRoles.Enabled = true;

                                if (habilitado.Text == "SI")
                                {
                                    btnHabilitar.Enabled = false;
                                }
                                estoyAgregandoUnaFuncionalidad = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todas las funcionalidades del sistema han sido asignadas al rol. Seleccione otro rol a modificar o una acción distinta", "ClinicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nombreRol.Enabled = false;
                        funcionalidades.Enabled = false;
                        habilitado.Enabled = false;
                        btnAgregarFuncionalidad.Enabled = true;
                        btnCambiarNombre.Enabled = true;
                        btnEliminarFuncionalidad.Enabled = true;
                        btnAceptar.Enabled = false;
                        btnCancelar.Enabled = false;
                        tablaDeRoles.Enabled = true;

                        if (habilitado.Text == "SI")
                        {
                            btnHabilitar.Enabled = false;
                        }
                        estoyAgregandoUnaFuncionalidad = false;
                    }
                }
            }

            //SI ESTOY CONFIRMANDO LA ELIMINACION DE UNA FUNCIONALIDAD A UN ROL...

            if (btnEliminarFuncionalidad.Enabled == true && estoyEliminandoUnaFuncionalidad)
            {
                N1ABMRol abm = new N1ABMRol();
                if (funcionalidades.SelectedIndex.Equals(-1)) //Verifico que si se selecciono algo en el ComboBox
                {
                    MessageBox.Show("Selección vacía. Seleccione una funcionalidad para eliminar", "ClinicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    abm.eliminarFuncionalidadARol(Convert.ToInt32(idRol.Text), funcionalidades.Text);
                    funcionalidades.Items.Clear(); //Borro todos los elementos del combobox
                    funcionalidades.Refresh(); //Recargo el combobox para que reconozca el borrado de sus elementos
                    DataTable listaDeFuncionalidades = abm.getFuncionalidadesAsignadas(nombreRol.Text);
                    if (listaDeFuncionalidades.Rows.Count != 0)
                    {
                        DialogResult result = MessageBox.Show("Funcionalidad eliminada exitosamente", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            DialogResult result2 = MessageBox.Show("Desea eliminar alguna funcionalidad más de este rol?", "ClínicaFRBA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result2 == DialogResult.Yes)
                            {
                                foreach (DataRow fila in listaDeFuncionalidades.Rows)
                                {
                                    funcionalidades.Items.Add(fila[0].ToString());//Agrego las funcionalidades restantes al combobox
                                }
                            }
                            else
                            {
                                nombreRol.Enabled = false;
                                funcionalidades.Enabled = false;
                                habilitado.Enabled = false;
                                btnAgregarFuncionalidad.Enabled = true;
                                btnCambiarNombre.Enabled = true;
                                btnEliminarFuncionalidad.Enabled = true;
                                btnAceptar.Enabled = false;
                                btnCancelar.Enabled = false;
                                tablaDeRoles.Enabled = true;

                                if (habilitado.Text == "SI")
                                {
                                    btnHabilitar.Enabled = false;
                                }
                                estoyEliminandoUnaFuncionalidad = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El rol seleccionado no posee funcionalidades asignadas. Seleccione otro rol a modificar o una acción distinta", "ClinicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nombreRol.Enabled = false;
                        funcionalidades.Enabled = false;
                        habilitado.Enabled = false;
                        btnAgregarFuncionalidad.Enabled = true;
                        btnCambiarNombre.Enabled = true;
                        btnEliminarFuncionalidad.Enabled = true;
                        btnAceptar.Enabled = false;
                        btnCancelar.Enabled = false;
                        tablaDeRoles.Enabled = true;

                        if (habilitado.Text == "SI")
                        {
                            btnHabilitar.Enabled = false;
                        }
                        estoyEliminandoUnaFuncionalidad = false;
                    }
                }
            }

            //SI ESTOY CONFIRMANDO LA EDICION DEL ESTADO HABILITADO DE UN ROL...

            if (btnHabilitar.Enabled == true && estoyHabilitandoUnRol)
            {
                if (habilitado.Text == "Si")
                {
                    N1ABMRol abm = new N1ABMRol();
                    abm.habilitarRol(Convert.ToInt32(idRol.Text));

                    //Hacer habilitaciones necesarias de campos y botones

                    N1ABMRol.cambiarNombreRol(Convert.ToInt32(idRol.Text), nombreRol.Text);
                    nombreRol.Enabled = false;
                    funcionalidades.Enabled = false;
                    habilitado.Enabled = false;
                    btnAgregarFuncionalidad.Enabled = false;
                    btnCambiarNombre.Enabled = false;
                    btnEliminarFuncionalidad.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    tablaDeRoles.Enabled = true;
                    this.idRol.Text = "";
                    this.nombreRol.Text = "";
                    this.habilitado.Text = "";
                    this.habilitado.SelectedIndex = -1; //Hago que se muestre vacío el combobox en tiempo de ejecución
                    btnHabilitar.Enabled = false;
                    estoyHabilitandoUnRol = false;
                    this.tablaDeRoles.DataSource = N1ABMRol.mostrarRoles();
                    MessageBox.Show("Habilitación realizada con éxito", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Habilite el rol seleccionado u oprima cancelar para anular la operacion", "ClínicaFRBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //EVENTO CLICK DEL BOTON CANCELAR

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nombreRol.Text = nombre;
            nombreRol.Enabled = false;
            funcionalidades.Enabled = false;
            habilitado.Enabled = false;
            btnAgregarFuncionalidad.Enabled = true;
            btnCambiarNombre.Enabled = true;
            btnEliminarFuncionalidad.Enabled = true;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            tablaDeRoles.Enabled = true;
            funcionalidades.Items.Clear();

            if (habilitado.Text == "Si" && btnHabilitar.Enabled == true)
            {
                habilitado.Text = "NO";
            }

            estoyAgregandoUnaFuncionalidad = false;
            estoyCambiandoNombre = false;
            estoyEliminandoUnaFuncionalidad = false;
            estoyHabilitandoUnRol = false;
        }
    }
}
