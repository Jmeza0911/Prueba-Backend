namespace ToDonut.Dto.Tareas.Insertar;

public class InsertarRequestDto
{
    public string Nombre { get; set; }
    public string Accion { get; set; }
    public string Responsable { get; set; }
    public string Duracion { get; set; }
    public int Estado { get; set; }
    public string FechaInicio { get; set; }
    public string FechaFinal { get; set; }
}
