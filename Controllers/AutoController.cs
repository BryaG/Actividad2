using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonasAutos.Dtos;
using PersonasAutos.Models;
using PersonasAutos.Servicio;

namespace PersonasAutos.Controllers
{
    [Route("api/autos")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private AutoService _service = new AutoService();

        [HttpGet("listar")]
        public List<Auto> Listar() 
        {
            return _service.MostrarAuto();
        }
        [HttpPost("guardar")]
        public Respuesta Guardar(Auto auto) 
        {
            return _service.Guardar(auto);
        }
        [HttpPost("editar")]
        public Respuesta Editar(Auto auto) 
        {
            return _service.Editar(auto);
        }
        [HttpPost("eliminar")]
        public Respuesta Eliminar(Auto auto) 
        {
            return _service.Eliminar(auto);
        }
        [HttpGet("buscar")]
        public Auto Buscar(string matricula)
        {
            return _service.Buscar(matricula);
        }
    }
}
