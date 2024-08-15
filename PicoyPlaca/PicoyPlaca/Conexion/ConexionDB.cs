using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PicoyPlaca.Conexion
{
    class ConexionDB
    {
        private string cadenaConexion = @"Data Source=.;Initial Catalog=Test;Integrated Security=True"; //Cadena a la cual se va a conectar
        private SqlConnection conn; 
        private SqlCommand cmd; 

        public ConexionDB()
        {
            conectar();
        }

        private void conectar()
        {
            conn = new SqlConnection(cadenaConexion);
        }

        public bool guardarSQL(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                int i = cmd.ExecuteNonQuery(); 
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
