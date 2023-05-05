using Dapper;
using System.Data;
using ToDonut.Datos.Contexts;
using ToDonut.Datos.Repositorios.Tareas.Interfaces;
using ToDonut.Dto.Tareas.Actualizar;
using ToDonut.Dto.Tareas.Insertar;
using ToDonut.Dto.Tareas.Obtener;

namespace ToDonut.Datos.Repositorios.Tareas.Implementacion;

public class TareasRepositorio : ITareasRepositorio
{

    private readonly DapperContext _context;

    public TareasRepositorio(DapperContext context)
    {
        _context = context;
    }
    public InsertarResponseDto AgregarTarea(InsertarRequestDto tarea)
    {
        using (var connection = _context.CreateConnection())
        {
            var query = "AgregarTarea";
            var parameters = new DynamicParameters();
            parameters.Add("Nombre", tarea.Nombre);
            parameters.Add("Accion", tarea.Accion);
            parameters.Add("Responsable", tarea.Responsable);
            parameters.Add("Duracion", tarea.Duracion);
            parameters.Add("Estado", tarea.Estado);
            parameters.Add("FechaInicio", tarea.FechaInicio);
            parameters.Add("FechaFinal", tarea.FechaFinal);

         
            var result = connection.QuerySingle<InsertarResponseDto>(query, param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }
    }

    public IEnumerable<ObtenerRequestDto> ObtenerTareas()
    {
        using (var connection = _context.CreateConnection())
        {
            var query = "ObtenerTareas";
            var tareas= connection.Query<ObtenerRequestDto>(query,commandType:CommandType.StoredProcedure);

            return tareas;
        }
    }

    public bool Delete(int IdTarea)
    {
        using (var connection = _context.CreateConnection())
        {
            var query = "EliminarTarea";
            var parameters = new DynamicParameters();
            parameters.Add("IdTarea", IdTarea);
            var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
            return result > 0;
        }
    }

    public UpdateDto ActualizarTarea(UpdateDto tarea)
    {
        using (var connection = _context.CreateConnection())
        {
            var query = "ActualizarTarea";
            var parameters = new DynamicParameters();
            parameters.Add("IdTarea", tarea.idTarea);
            parameters.Add("nombre", tarea.nombre);
            parameters.Add("accion", tarea.accion);
            parameters.Add("responsable", tarea.responsable);
            parameters.Add("duracion", tarea.duracion);
            parameters.Add("estado", tarea.estado);
            parameters.Add("fechaInicio", tarea.fechaInicio);
            parameters.Add("fechaFinal", tarea.fechaFinal);
            var result = connection.QuerySingle<UpdateDto>(query, param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
