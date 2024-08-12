

class Program
{
    static List<Habitacion> habitaciones = new List<Habitacion>();

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Menú de Gestión de Habitaciones ---");
            Console.WriteLine("1. Agregar Habitación");
            Console.WriteLine("2. Eliminar Habitación");
            Console.WriteLine("3. Mostrar Habitaciones");
            Console.WriteLine("4. Asignar Habitación a Cliente");
            Console.WriteLine("5. Liberar Habitación");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarHabitacion();
                    break;
                case 2:
                    EliminarHabitacion();
                    break;
                case 3:
                    MostrarHabitaciones();
                    break;
                case 4:
                    AsignarHabitacion();
                    break;
                case 5:
                    LiberarHabitacion();
                    break;
                case 6:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 6);
    }

    static void AgregarHabitacion()
    {
        Console.WriteLine("\n--- Agregar Habitación ---");
        Console.WriteLine("1. Habitación Simple");
        Console.WriteLine("2. Habitación Doble");
        Console.WriteLine("3. Suite");
        Console.WriteLine("4. Habitación Deluxe");
        Console.Write("Seleccione el tipo de habitación: ");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write("Número de habitación: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Precio por noche: ");
        double precioPorNoche = double.Parse(Console.ReadLine());

        switch (tipo)
        {
            case 1:
                Console.Write("Número de camas: ");
                int numeroDeCamas = int.Parse(Console.ReadLine());
                habitaciones.Add(new HabitacionSimple(numero, precioPorNoche, numeroDeCamas));
                break;
            case 2:
                Console.Write("¿Tiene vista al mar? (true/false): ");
                bool vistaAlMar = bool.Parse(Console.ReadLine());
                habitaciones.Add(new HabitacionDoble(numero, precioPorNoche, vistaAlMar));
                break;
            case 3:
                Console.Write("Número de habitaciones: ");
                int numeroDeHabitaciones = int.Parse(Console.ReadLine());
                Console.Write("¿Tiene jacuzzi? (true/false): ");
                bool tieneJacuzzi = bool.Parse(Console.ReadLine());
                habitaciones.Add(new Suite(numero, precioPorNoche, numeroDeHabitaciones, tieneJacuzzi));
                break;
            case 4:
                Console.Write("Servicios extras: ");
                string serviciosExtras = Console.ReadLine();
                habitaciones.Add(new HabitacionDeluxe(numero, precioPorNoche, serviciosExtras));
                break;
            default:
                Console.WriteLine("Tipo de habitación no válido.");
                break;
        }

        Console.WriteLine("Habitación agregada exitosamente.");
    }

    static void EliminarHabitacion()
    {
        Console.Write("\nNúmero de la habitación a eliminar: ");
        int numero = int.Parse(Console.ReadLine());

        Habitacion habitacion = habitaciones.Find(h => h.Numero == numero);
        if (habitacion != null)
        {
            habitaciones.Remove(habitacion);
            Console.WriteLine("Habitación eliminada exitosamente.");
        }
        else
        {
            Console.WriteLine("Habitación no encontrada.");
        }
    }

    static void MostrarHabitaciones()
    {
        Console.WriteLine("\n--- Lista de Habitaciones ---");
        foreach (var habitacion in habitaciones)
        {
            habitacion.MostrarInformacion();
            Console.WriteLine("------------------------");
        }
    }

    static void AsignarHabitacion()
    {
        Console.Write("\nNúmero de la habitación: ");
        int numero = int.Parse(Console.ReadLine());

        Habitacion habitacion = habitaciones.Find(h => h.Numero == numero);
        if (habitacion != null)
        {
            Console.Write("Nombre del cliente: ");
            string nombreCliente = Console.ReadLine();
            habitacion.AsignarCliente(nombreCliente);
        }
        else
        {
            Console.WriteLine("Habitación no encontrada.");
        }
    }

    static void LiberarHabitacion()
    {
        Console.Write("\nNúmero de la habitación: ");
        int numero = int.Parse(Console.ReadLine());

        Habitacion habitacion = habitaciones.Find(h => h.Numero == numero);
        if (habitacion != null)
        {
            habitacion.LiberarHabitacion();
        }
        else
        {
            Console.WriteLine("Habitación no encontrada.");
        }
    }
}