using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N11RegLlegada
    {   /*ESTA CLASE ES LA ENCARCARGADA DE CONECTAR CAPADATOS CON CAPANEGOCIOS*/
        /*ATRAVEZ DE UN METODO DE UNA CLASE */
        public static DataTable BuscarPorApellidoEspec(string unApellido,string unaEspecialidad)
        {
            D11RegLlegada Obj = new D11RegLlegada();
            return Obj.BuscarPorApellEspec(unApellido,unaEspecialidad);
        }

        public static DataTable BuscarTurnosDisponibles(int unaMatricula)
        {
            D11RegLlegada Obj = new D11RegLlegada();
            return Obj.BuscarTurnosDisponibles(unaMatricula);
        }
        public static DataTable BuscarBonosDisponibles(int unAfiliado)
        {
            D11RegLlegada obj = new D11RegLlegada();
            return obj.BuscarBonosDisponibles(unAfiliado);
        }

        public static DataTable InsertarConsulta(int unTurno, int unBono)
        {
            D11RegLlegada obj = new D11RegLlegada();
            return obj.insertarConsulta(unTurno,unBono);
        }
    }
}
