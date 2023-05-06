using ToDonut.Dto.Tareas.Actualizar;
using ToDonut.Dto.Tareas.Insertar;
using ToDonut.Dto.Tareas.Obtener;

namespace ToDonut.Datos.Repositorios.Tareas.Interfaces;

public interface ITareasRepositorio
{
    public InsertarResponseDto AgregarTarea(InsertarRequestDto tarea);
    public IEnumerable<ObtenerRequestDto> ObtenerTareas();

    public bool EliminarTarea(int IdTarea);
    public UpdateDto ActualizarTarea(UpdateDto tarea);
}
