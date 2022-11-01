using Programa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Datos
{
    class AlumnoContraller
    {
        public static bool guardar(Alumno Al)
        {
            try
            {
                Conexion con = new Conexion();
                string Sql = "INSERT bo_Alumno(nombre, calificacion) VALUES('" + Al.Nombre + "','" + Al.Calificacion + "')";
                SqlCommand inserta = new SqlCommand(Sql, con.conectar());
                int insertados = inserta.ExecuteNonQuery();
                if (insertados == 1)
                {
                    return true;
                }
                else return false;
                con.desconectar();

            }catch (Exception A)

            {
                return false;
            }
        
        }

        // segunda parte del trabajo (mostrar en pantalla) 

        public static DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                string Sql = "select * from bo_Alumno;";
                SqlCommand inserta = new SqlCommand(Sql, con.conectar());
                SqlDataReader it= inserta.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable its = new DataTable();
                its.Load(it);

                con.desconectar();
                return its;
            }
            catch (Exception A)

            {
                return null;
            }

        }

        public static Alumno consultar(string nombre)
        {
            try
            {
                Conexion con = new Conexion();
                string Sql = "select * from bo_Alumno WHERE nombre = '"+nombre+"';";
                SqlCommand inserta = new SqlCommand(Sql, con.conectar());
                SqlDataReader it = inserta.ExecuteReader();
                Alumno Al = new Alumno();

                if (it.Read())
                {
                    Al.Nombre = it["nombre"].ToString();
                    Al.Calificacion = Convert.ToInt32(it["calificacion"].ToString());
                    return Al;
                }

                con.desconectar();
                return null;
            }
            catch (Exception A)

            {
                return null;
            }

        }


    }
}
