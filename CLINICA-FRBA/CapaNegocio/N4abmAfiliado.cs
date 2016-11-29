using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N4abmAfiliado
    {
        /*ESTA CLASE ES LA ENCARCARGADA DE CONECTAR CAPADATOS CON CAPANEGOCIOS*/
        /*ATRAVEZ DE UN METODO DE UNA CLASE */
        public static DataTable BuscarElUltimoAfiliado()
        {
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.BuscarUltimoAfiliado();
        }

        public static DataTable ExisteElUserName(string unUserName)
        {
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.ExisteUserName(unUserName);
        }

        public static DataTable ExisteElUsuario(string unTipoDNI, string unMail, int unDNI)
        {
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.ExisteUsuario(unTipoDNI, unMail, unDNI);
        }

        public static DataTable ExisteElAfiliado(string unUsuario)
        {
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.ExisteAfiliado(unUsuario);
        }

        public static DataTable InsertElUsuario(string unUserName, string unNombre, string unApellido,
                                                int unTelefono, string unSexo, string unEstadoCivil, int unDni,
                                                string unTipoDNI, DateTime unaFechaNacimiento, string unaDireccion, string unMail,
                                                string unPassword)
        {
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.InsertarUsuario(unUserName, unNombre, unApellido, unTelefono, unSexo, unEstadoCivil, unDni,
								       unTipoDNI, unaFechaNacimiento, unaDireccion, unMail,unPassword);
        }

        public static DataTable InsertElAfiliado(int unId, string unUsuario, int unPlan, int unPrincipal, int unaCantHijos)
        { 
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.InsertarAfiliado(unId, unUsuario, unPlan, unPrincipal, unaCantHijos);
        }
    }
}
