
namespace ToDonut.Dto.Tareas.Actualizar;

public  class UpdateDto
{
    public int idTarea { get; set; }
    public string nombre { get; set; }
    public string accion { get; set; }
    public string responsable { get; set; }
    public string duracion { get; set; }
    public int estado { get; set; }
    public string fechaInicio { get; set; }
    public string fechaFinal { get; set; }
}
