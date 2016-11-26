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

        public static DataTable ExisteElUsuario(string unUsuario, string unMail, int unDNI)
        {
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.ExisteUsuario(unUsuario, unMail, unDNI);
        }

        public static DataTable ExisteELAfiliado(string unUsuario)
        {
            D4abmAfiliado Obj = new D4abmAfiliado();
            return Obj.ExisteAfiliado(unUsuario);
        }
    }
}
