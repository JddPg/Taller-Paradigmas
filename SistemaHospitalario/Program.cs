using System;
using System.Collections.Generic;

// 1. Inicialización de los servicios (Fuera del while para que tengan persistencia)
PacienteServicio pacienteServicio = new PacienteServicio();
MedicoServicio medicoServicio = new MedicoServicio();
CitaServicio citaServicio = new CitaServicio(); // <--- Esto resuelve tu error de contexto

while (true)
{
    Console.WriteLine("\n--- SISTEMA HOSPITALARIO ---");
    Console.WriteLine("1. Crear paciente");
    Console.WriteLine("2. Listar pacientes");
    Console.WriteLine("3. Crear medico");
    Console.WriteLine("4. Listar medicos");
    Console.WriteLine("5. Agendar Cita");
    Console.WriteLine("6. Listar Citas");
    Console.WriteLine("7. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("ID Paciente: ");
        string id = Console.ReadLine();

        pacienteServicio.Crear(new Paciente { Nombre = nombre, Edad = edad, IdPaciente = id });
        Console.WriteLine("¡Paciente creado!");
    }
    else if (opcion == "2")
    {
        var lista = pacienteServicio.Leer();
        Console.WriteLine("\n--- LISTA DE PACIENTES ---");
        foreach (var p in lista)
        {
            Console.WriteLine($"ID: {p.IdPaciente} | Nombre: {p.Nombre} | Edad: {p.Edad}");
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

        medicoServicio.Crear(new Medico { Nombre = nombre, Edad = edad, Especialidad = esp });
        Console.WriteLine("¡Médico creado!");
    }
    else if (opcion == "4")
    {
        var lista = medicoServicio.Leer();
        Console.WriteLine("\n--- LISTA DE MÉDICOS ---");
        foreach (var m in lista)
        {
            Console.WriteLine($"Nombre: {m.Nombre} | Especialidad: {m.Especialidad}");
        }
    }
    else if (opcion == "5")
    {
        var pacientes = pacienteServicio.Leer();
        var medicos = medicoServicio.Leer();

        if (pacientes.Count == 0 || medicos.Count == 0)
        {
            Console.WriteLine("Error: Debe haber al menos un paciente y un médico registrados.");
            continue;
        }

        Console.WriteLine("\n--- AGENDAR CITA ---");
        for (int i = 0; i < pacientes.Count; i++) 
            Console.WriteLine($"{i}. {pacientes[i].Nombre}");
        Console.Write("Seleccione índice del paciente: ");
        int iP = int.Parse(Console.ReadLine());

        for (int i = 0; i < medicos.Count; i++) 
            Console.WriteLine($"{i}. {medicos[i].Nombre}");
        Console.Write("Seleccione índice del médico: ");
        int iM = int.Parse(Console.ReadLine());

        Console.Write("Fecha (dd/mm/aaaa): ");
        string fecha = Console.ReadLine();

        citaServicio.Crear(new Cita { 
            Paciente = pacientes[iP], 
            Medico = medicos[iM], 
            Fecha = fecha 
        });
        Console.WriteLine("¡Cita agendada!");
    }
    else if (opcion == "6")
    {
        var citas = citaServicio.Leer();
        Console.WriteLine("\n--- TODAS LAS CITAS ---");
        foreach (var c in citas)
        {
            Console.WriteLine($"Fecha: {c.Fecha} | Paciente: {c.Paciente.Nombre} | Médico: {c.Medico.Nombre}");
        }
    }
    else if (opcion == "7")
    {
        break;
    }
}