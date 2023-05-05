
using Dapper;
using System;
using System.Data;
using ToDonut.Datos.Repositorios.Tareas.Interfaces;
using ToDonut.Dto.Tareas.Actualizar;
using ToDonut.Dto.Tareas.Insertar;
using ToDonut.Dto.Tareas.Obtener;
using ToDonut.Negocio.Tarea.Interfaz;
using ToDonut.Utils;

namespace ToDonut.Negocio.Tarea.Implementacion;

public class TareaNegocio : ITareaNegocio
{
    private readonly ITareasRepositorio _tareasRepositorio;
    public TareaNegocio(ITareasRepositorio tareasRepositorio)
    {
        _tareasRepositorio = tareasRepositorio;
    }

    #region'Metodos'
    public Response<InsertarResponseDto> AgregarTarea(InsertarRequestDto tareaRequestDto)
    {
      var response = new Response<InsertarResponseDto>();

        try
        {
            var Tarea = _tareasRepositorio.AgregarTarea(tareaRequestDto);

            if (Tarea.IdTarea > 0)
            {
                response.Data = Tarea;
                response.IsSuccess = true;
                response.Message = "Regristro Exitoso!!!";

            }
        }

        catch (Exception ex)
        { 
            response.Message = ex.Message;
        }
        return response;
    }


    public Response<IEnumerable<ObtenerRequestDto>> ObtenerTareas()
    {
        var response = new Response<IEnumerable<ObtenerRequestDto>>();

        try
        {
            var Tareas = _tareasRepositorio.ObtenerTareas();

            response.Data = Tareas;
            response.IsSuccess = true;
            response.Message = "Consulta realizada!!!";

        }

        catch (Exception ex)
        {
            response.Message = ex.Message;
        }
        return response;
    }
    public Response<int> Delete(string IdTarea)
    {
        var response = new Response<int>();

        try
        {
            var eliminado = _tareasRepositorio.Delete(Convert.ToInt32(IdTarea));
            if (eliminado)
            {
                response.Data = Convert.ToInt32(IdTarea);
                response.IsSuccess = true;
                response.Message = "Registro eliminado!!!";
            }
        }
        catch (Exception ex)
        {
            response.Message = ex.Message;
        }
        return response;
    }

    public Response<UpdateDto> ActualizarTarea(UpdateDto tarea)
    {
        var response = new Response<UpdateDto>();

        try
        {
            var actualizado = _tareasRepositorio.ActualizarTarea(tarea);
            if (actualizado != null)
            {
                response.Data = actualizado;
                response.IsSuccess = true;
                response.Message = "Registro Actualizado!!!";
            }
        }
        catch (Exception ex)
        {
            response.Message = ex.Message;
        }
        return response;
    }


    #endregion
}
