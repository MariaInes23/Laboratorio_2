using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_2
{
    public class HabitacionDeluxe : Habitacion
    {
        public string ServiciosExtras { get; set; }
        public HabitacionDeluxe(string serviciosExtras)
        {
            ServiciosExtras = serviciosExtras;
        }
    }
}
