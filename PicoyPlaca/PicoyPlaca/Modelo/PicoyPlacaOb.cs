using PicoyPlaca.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoyPlaca.Modelo
{
    class PicoyPlacaOb
    {
        private string placaVehiculo;
        private string hora;
        private DateTime fecha;
        private bool circula;

        public PicoyPlacaOb(string placaVehiculo, string hora, DateTime fecha, bool circula)
        {
            this.PlacaVehiculo = placaVehiculo;
            this.Hora = hora;   
            this.Fecha = fecha;
            this.Circula = circula;
        }

        public string PlacaVehiculo { get => placaVehiculo; set => placaVehiculo = value; }
        public string Hora { get => hora; set => hora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Circula { get => circula; set => circula = value; }

        ConexionDB conn = new ConexionDB();
        public bool registrarInfo()
        {
            string sql = $"INSERT INTO PicoPlaca VALUES('{this.placaVehiculo}', '{this.hora}', '{this.fecha}', '{this.circula}')"; //SQL para guardar en la base de datos
            if (conn.guardarSQL(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
