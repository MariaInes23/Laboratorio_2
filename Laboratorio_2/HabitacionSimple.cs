using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class HabitacionSimple : Habitacion
    {
        public int NumeroDeCamas { get; set; }
        public HabitacionSimple(int numeroCamas)
        {
            NumeroDeCamas = numeroCamas;
        }
    }
}
