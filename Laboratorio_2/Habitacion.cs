using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Habitacion
    {
        public string Nombre { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitacion(string nombre, double precio, bool disponible, string cliente)
        {
            Nombre = nombre;
            PrecioPorNoche = precio;
            Disponible = disponible;
            ClienteAsignado = cliente;
        }
        public string MostrarInformacion()
        {
            return $"Nombre: {Nombre}, Precio: {PrecioPorNoche}, Disponibilidad: {Disponible}, Cliente: {ClienteAsignado}";
        }

        public double CambiarSiponibilidad()
        {
            return
        }
        public string AsignarCliente()
        {
            return
        }
        public string LiberarHabitacion()
        {
            return
        }
    }
}
