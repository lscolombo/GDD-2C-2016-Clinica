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
    {
        public static DataTable BuscarPorApellido(string unApellido) 
        {
            D11RegLlegada Obj = new D11RegLlegada();
            return Obj.BuscarPorApell(unApellido);
        }

    }
}
