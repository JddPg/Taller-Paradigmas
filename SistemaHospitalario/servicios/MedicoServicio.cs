using System.Collections.Generic;

public class MedicoServicio : ICRUD<Medico>
{
    private List<Medico> medicos = new List<Medico>();

    public void Crear(Medico m)
    {
        medicos.Add(m);
    }

    public List<Medico> Leer()
    {
        return medicos;
    }

    public void Actualizar(int index, Medico m)
    {
        medicos[index] = m;
    }

    public void Eliminar(int index)
    {
        medicos.RemoveAt(index);
    }
}