using PersonasAutos.Dtos;
using PersonasAutos.Models;

namespace PersonasAutos.Metodos
{
    public interface IMetodosPersona
    {
        Respuesta Guardar(Persona persona);
        Respuesta Editar(Persona persona);
        Respuesta Eliminar(Persona persona);
        Persona Buscar(string curp);
        List<Persona> MostrarPersonas();
    }
}
