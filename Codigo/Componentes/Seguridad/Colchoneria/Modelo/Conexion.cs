using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

//Comentado por Luis Torres 26/02/2023
namespace Modelo_Seguridad
{
    class Conexion
    {
        //Metodo de conexion a base de datos
        public OdbcConnection conexion()
        {

            OdbcConnection conn = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

        //Metodo para la desconexion de la base de datos
        //Metodo sin referencia
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }

    }
}
