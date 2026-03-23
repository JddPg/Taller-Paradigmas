using System.Collections.Generic;

public class PacienteServicio : ICRUD<Paciente>
{
    private List<Paciente> pacientes = new List<Paciente>();

    public void Crear(Paciente p)
    {
        pacientes.Add(p);
    }

    public List<Paciente> Leer()
    {
        return pacientes;
    }

    public void Actualizar(int index, Paciente p)
    {
        pacientes[index] = p;
    }

    public void Eliminar(int index)
    {
        pacientes.RemoveAt(index);
    }
}