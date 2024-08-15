using PicoyPlaca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PicoyPlaca.Controller
{
    class PicoyPlacaController
    {
        PicoyPlacaOb pyp;

        public void registarInformacion(string placaVehiculo, string hora, DateTime fecha, bool circula) 
        {
            if (placaVehiculo != "" || hora != "" || fecha.ToString() != "")//validar informacion
            {
                pyp = new PicoyPlacaOb(placaVehiculo, hora, fecha, circula);
                if (pyp.registrarInfo())
                {
                    Console.WriteLine("Datos registrados exitosamente.");
                }
                else
                {
                    Console.WriteLine("Datos no guardados");
                }
            }
        }

        public bool puedeCircular(string placaVehiculo, string hora, DateTime fecha)
        {
            int numDig = placaVehiculo.Length;
            int ultimoDigito = Int32.Parse(placaVehiculo.Substring((numDig - 1), 1));

            int horaDia = Int32.Parse((hora.Split(':'))[0]);
            int minutoDia = Int32.Parse((hora.Split(':'))[1]);
            int diaSemana = (int)fecha.DayOfWeek;

            int diaProhibido = (ultimoDigito + 1) / 2;

            if (diaSemana == diaProhibido)
            {
                return horarioCorrecto(horaDia, minutoDia);
            }
            else
            {
                return true;
            }
        }

        public bool horarioCorrecto (int horaDia, int minutoDia) //Verificar si esta en el horario restringido
        {
            if ((horaDia >= 6 && (horaDia < 9 || (horaDia == 9 && minutoDia <= 30))) || (horaDia >= 16 && horaDia <= 20))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
