using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class HabitacionDoble : Habitacion
    {
        public bool VistaAlMar { get; set; }

        public HabitacionDoble(bool vistaAlMar)
        {
            VistaAlMar = vistaAlMar;
        }
    }
}
