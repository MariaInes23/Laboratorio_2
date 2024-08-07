using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Suite : Habitacion
    {
        public int NumeroDeHabitaciones { get; set; }
        public bool TieneJacozzi { get; set; }
        public HabitacionSuite(int numeroDeHabitaciones, bool tieneJacuzzi)
        {
            NumeroDeHabitaciones = numeroDeHabitaciones;
            TieneJacozzi = tieneJacuzzi;
        }
    }
}
