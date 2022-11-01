using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Datos
{
    class Conexion
    {
        SqlConnection con;
        public Conexion() 
        {
            con = new SqlConnection("Server = LAPTOP-U17LT8PI; Database = Tablas; integrated security = true");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }


    }
}
