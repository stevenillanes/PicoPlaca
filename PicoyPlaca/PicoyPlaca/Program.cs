using Microsoft.VisualBasic;
using PicoyPlaca.Controller;
using System.Numerics;

/*En respuesta a la creciente congestión vehicular en la ciudad, el municipio ha implementado el sistema de Pico y Placa para vehículos particulares. 
 * Necesitamos que desarrollen un programa que determine si un vehículo puede circular en una hora y fecha específicas, tomando en cuenta las reglas 
 * de Pico y Placa vigentes.

 * */
namespace PicoyPlaca
{
    class Program
    {
        static void Main(string[] args)
        {
            PicoyPlacaController pypControl = new PicoyPlacaController();
            bool circu = pypControl.puedeCircular("PSD7645", "15:34", DateTime.Parse("1998-01-03"));
            Console.WriteLine(circu ? "Usuario puede transitar" : "Usuario NO puede transitar");
            pypControl.registarInformacion("PSD7645", "15:34", DateTime.Parse("1998-01-03"), circu);

        }
    }
}
