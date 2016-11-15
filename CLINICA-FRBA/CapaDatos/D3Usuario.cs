using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D3Usuario
    {
        private string _user_username;
        private string _user_password;

        //Propiedades

        public string User_username
        {
            get { return _user_username; }
            set { _user_username = value; }
        }

        public string User_password
        {
            get { return _user_password; }
            set { _user_password = value; }
        }

        //Constructores
        public D3Usuario()
        {

        }

        public D3Usuario(string user_username, string user_password)
        {
            this.User_username = user_username;
            this.User_password = user_password;
        }

    }
}
