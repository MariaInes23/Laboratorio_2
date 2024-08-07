using static System.Runtime.InteropServices.JavaScript.JSType;

static void Main(string[] args)
{
    bool salir = false;

    while (!salir)
    {
        Console.WriteLine("1. Agregar habitación (Simple, Doble, Suite, Deluxe).");
        Console.WriteLine("2. Eliminar la habitacion.");
        Console.WriteLine("3. Mostrar las habitaciones.");
        Console.WriteLine("4. Asignar habitaciones a clientes.");
        Console.WriteLine("5. Liberar la habitacion.");
        Console.WriteLine("6. Salir.");
        Console.Write("Seleccione una opción: ");

        string opcion = Console.ReadLine();

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
                AsignarHabitacionCliente();
                break;
            case 5:
                LiberarHabitacion();
                break;
            case 6:
                salir = true;
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

public string AgregarHabitacion()
{
    bool salir = false;
    while (!salir)
    {
        Console.WriteLine("Seleccione el tipo de habitacion que desea agregar:");
        Console.WriteLine("1. Habitacion Simple");
        Console.WriteLine("2. Habitacion Doble");
        Console.WriteLine("3. Suite");
        Console.WriteLine("4. Deluxe");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");

        string tipoHabitacion = Console.ReadLine();

        switch (tipoHabitacion)
        {
            case "1":
                Console.Write("Ingrese el numero de camas: ");
                int numeroCamas = int.Parse(Console.ReadLine());
                break;
            case "2":
                Console.Write("Ingrese si desea vista al mar: ");
                double vistaAlMar = double.Parse(Console.ReadLine());
                break;
            case "3":
                Console.Write("Ingrese si desea que tenga Jacuzzi: ");
                double tieneJacuzzi = double.Parse(Console.ReadLine());
                Console.Write("Ingrese si desea que tenga Jacuzzi: ");
                double tieneJacuzzi = double.Parse(Console.ReadLine());
                break;
            case "4":
                Console.Write("Ingrese los servicios extras que desea agregar: ");
                string serviciosExtras = Console.ReadLine();
                break;
            case "5":
                salir = true;
                break;
            default:
                Console.WriteLine("Tipo de producto no válido.");
            break;
        }
    }
}

public string EliminarHabitacion()
{
    return;
}

public string MostrarHabitaciones()
{
    return;
}
public string AsignarHabitacionCliente()
{
    return;
}
public string LiberarHabitacion()
{
    return;
}
