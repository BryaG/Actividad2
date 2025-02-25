using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonasAutos.Dtos;
using PersonasAutos.Models;
using PersonasAutos.Servicio;

namespace PersonasAutos.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private PersonaService _service = new PersonaService();

        [HttpGet("listar")]
        public List<Persona> Listar() 
        {
            return _service.MostrarPersonas();
        }
        [HttpPost("guardar")]
        public Respuesta Guardar([FromBody] Persona persona) 
        {
            return _service.Guardar(persona);
        }
        [HttpPost("editar")]
        public Respuesta Editar([FromBody] Persona persona)
        {
            return _service.Editar(persona);
        }
        [HttpPost("eliminar")]
        public Respuesta Eliminar([FromBody] Persona persona)
        {
            return _service.Eliminar(persona);
        }
        [HttpGet("buscar")]
        public Persona Buscar(string curp)
        {
            return _service.Buscar(curp);
        }
    }
}
