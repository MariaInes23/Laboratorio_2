using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitacion(int numero, double precioPorNoche)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponible = true;
            ClienteAsignado = string.Empty;
        }

        public static void MostrarInformacion()
        {
            Console.WriteLine($"Habitación {Numero} - Precio por noche: {PrecioPorNoche} - Disponible: {Disponible}");
            if (!Disponible)
            {
                Console.WriteLine($"Cliente Asignado: {ClienteAsignado}");
            }
        }

        public void CambiarDisponibilidad(bool disponible)
        {
            Disponible = disponible;
        }

        public void AsignarCliente(string nombreCliente)
        {
            if (Disponible)
            {
                ClienteAsignado = nombreCliente;
                CambiarDisponibilidad(false);
                Console.WriteLine($"Habitación {Numero} asignada a {nombreCliente}.");
            }
            else
            {
                Console.WriteLine($"La habitación {Numero} no está disponible.");
            }
        }

        public void LiberarHabitacion()
        {
            ClienteAsignado = string.Empty;
            CambiarDisponibilidad(true);
            Console.WriteLine($"Habitación {Numero} liberada.");
        }
    }
}
