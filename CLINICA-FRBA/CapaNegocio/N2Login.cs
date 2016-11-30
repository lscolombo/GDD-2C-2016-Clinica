using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N2Login
    {
        public static DataTable Login(string user_username, string user_password)
        {
            D3Usuario Obj = new D3Usuario();
            Obj.User_username = user_username;
            Obj.User_password = user_password;
            return new D2Login().Login(Obj);
        }

        public static DataTable Mostrar(string user_username)
        {
            return new D2Login().Mostrar(user_username);
        }

        public static DataTable MostrarFuncionalidades(string user_rol)
        {
            return new D2Login().MostrarFuncionalidades(user_rol);
        }
    }
}
