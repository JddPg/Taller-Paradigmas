using System.Collections.Generic;

public interface ICRUD<T>
{
    void Crear(T obj);
    List<T> Leer();
    void Actualizar(int index, T obj);
    void Eliminar(int index);
}