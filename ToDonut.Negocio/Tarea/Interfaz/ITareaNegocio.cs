using ToDonut.Dto.Tareas.Actualizar;
using ToDonut.Dto.Tareas.Insertar;
using ToDonut.Dto.Tareas.Obtener;
using ToDonut.Utils;

namespace ToDonut.Negocio.Tarea.Interfaz;

public  interface ITareaNegocio
{
    Response<InsertarResponseDto> AgregarTarea(InsertarRequestDto tareaRequestDto);
    Response<IEnumerable<ObtenerRequestDto>> ObtenerTareas();
    Response<int> EliminarTarea(string idTarea);
    Response<UpdateDto> ActualizarTarea(UpdateDto tarea);
}
