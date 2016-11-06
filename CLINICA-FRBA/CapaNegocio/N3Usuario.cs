using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N3Usuario
    {
        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase D3Usuario
        //de la CapaDatos
        public static string Insertar(string user_username, string user_nombre, string user_apellido,
                        string user_telefono, char user_sexo, string user_estado_civil,
                        string user_dni, string user_tipo_dni, DateTime user_fecha_nac,
                        string user_direccion, string user_mail, string user_password,
                        int user_intentos_fallidos, bool user_habilitado)
        {
            D3Usuario Obj = new D3Usuario();
            Obj.User_username = user_username;
            Obj.User_nombre = user_nombre;
            Obj.User_apellido = user_apellido;
            Obj.User_telefono = user_telefono;
            Obj.User_sexo = user_sexo;
            Obj.User_estado_civil = user_estado_civil;
            Obj.User_dni = user_dni;
            Obj.User_tipo_dni = user_tipo_dni;
            Obj.User_fecha_nac = user_fecha_nac;
            Obj.User_direccion = user_direccion;
            Obj.User_mail = user_mail;
            Obj.User_password = user_password;
            Obj.User_intentos_fallidos = user_intentos_fallidos;
            Obj.User_habilitado = user_habilitado;

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase D3Usuario
        //de la CapaDatos

        public static string Editar(string user_username, string user_nombre, string user_apellido,
                        string user_telefono, char user_sexo, string user_estado_civil,
                        string user_direccion, string user_mail, string user_password,
                        bool user_habilitado)
        {
            D3Usuario Obj = new D3Usuario();
            Obj.User_username = user_username;
            Obj.User_nombre = user_nombre;
            Obj.User_apellido = user_apellido;
            Obj.User_telefono = user_telefono;
            Obj.User_sexo = user_sexo;
            Obj.User_estado_civil = user_estado_civil;
            Obj.User_direccion = user_direccion;
            Obj.User_mail = user_mail;
            Obj.User_password = user_password;
            Obj.User_habilitado = user_habilitado;

            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase D3Usuario
        //de la CapaDatos
        public static string Eliminar(string user_username)
        {
            D3Usuario Obj = new D3Usuario();
            Obj.User_username = user_username;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Login(string user_username, string user_password)
        {
            D3Usuario Obj = new D3Usuario();
            Obj.User_username = user_username;
            Obj.User_password = user_password;
            return Obj.Login(Obj);
        }
    }
}
