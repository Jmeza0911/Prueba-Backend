using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDonut.Dto.Tareas.Actualizar;
using ToDonut.Dto.Tareas.Insertar;
using ToDonut.Negocio.Tarea.Interfaz;

namespace ToDonut.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly ITareaNegocio _tareaNegocio;

        public TareasController(ITareaNegocio tareaNegocio)
        {
            _tareaNegocio = tareaNegocio;
        }
        [HttpPost("AgregarTarea")]
        public IActionResult AgregarTarea([FromBody]InsertarRequestDto tareasRequestDto)
        {
            if (tareasRequestDto == null)
                return BadRequest();

            var response = _tareaNegocio.AgregarTarea(tareasRequestDto);
            if(response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
   
        }

        [HttpGet("ObtenerTareas")]
        public IActionResult ObtenerTareas()
        {
            var response = _tareaNegocio.ObtenerTareas();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        [HttpDelete("Delete/{IdTarea}")]
        public IActionResult Delete(string IdTarea)
        {
            if (string.IsNullOrEmpty(IdTarea))
                return BadRequest();
            var response = _tareaNegocio.Delete(IdTarea);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("ActualizarTarea")]
        public IActionResult ActualizarTarea(UpdateDto tarea)
        {
            if (tarea == null)
                return BadRequest();
            var response = _tareaNegocio.ActualizarTarea(tarea);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
    }
}
