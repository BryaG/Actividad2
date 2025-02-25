using PersonasAutos.Dtos;
using PersonasAutos.Models;

namespace PersonasAutos.Metodos
{
    public interface IMetodosAuto
    {
        Respuesta Guardar(Auto auto);
        Respuesta Editar(Auto auto);
        Respuesta Eliminar(Auto auto);
        Auto Buscar(string matricula);
        List<Auto> MostrarAuto();
    }
}
