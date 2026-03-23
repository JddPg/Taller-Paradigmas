PacienteServicio pacienteServicio = new PacienteServicio();
MedicoServicio medicoServicio = new MedicoServicio();

while (true)
{
    Console.WriteLine("\n--- SISTEMA HOSPITALARIO ---");
    Console.WriteLine("1. Crear paciente");
    Console.WriteLine("2. Listar pacientes");
    Console.WriteLine("3. Crear medico");
    Console.WriteLine("4. Listar medicos");
    Console.WriteLine("5. Salir");

    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        pacienteServicio.Crear(new Paciente
        {
            Nombre = nombre,
            Edad = edad
        });
    }

    else if (opcion == "2")
    {
        var lista = pacienteServicio.Leer();
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"{lista[i].Nombre} - {lista[i].Edad}");
        }
    }

    else if (opcion == "3")
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Especialidad: ");
        string esp = Console.ReadLine();

        medicoServicio.Crear(new Medico
        {
            Nombre = nombre,
            Edad = edad,
            Especialidad = esp
        });
    }

    else if (opcion == "4")
    {
        var lista = medicoServicio.Leer();
        foreach (var m in lista)
        {
            Console.WriteLine($"{m.Nombre} - {m.Especialidad}");
        }
    }

    else if (opcion == "5")
    {
        break;
    }
}