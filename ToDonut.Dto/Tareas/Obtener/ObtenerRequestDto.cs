
namespace ToDonut.Dto.Tareas.Obtener;

public class ObtenerRequestDto
{
    public int IdTarea { get; set; }
    public string Nombre { get; set; }
    public string Accion { get; set; }
    public string Responsable { get; set; }
    public string Duracion { get; set; }
    public int Estado { get; set; }
    public string FechaInicio { get; set; }
    public string FechaFinal { get; set; }
}
