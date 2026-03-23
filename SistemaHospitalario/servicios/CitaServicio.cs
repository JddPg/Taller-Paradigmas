using System.Collections.Generic;

public class CitaServicio : ICRUD<Cita>
{
    private List<Cita> citas = new List<Cita>();

    public void Crear(Cita c)
    {
        citas.Add(c);
    }

    public List<Cita> Leer()
    {
        return citas;
    }

    public void Actualizar(int index, Cita c)
    {
        citas[index] = c;
    }

    public void Eliminar(int index)
    {
        citas.RemoveAt(index);
    }
}