
using Microsoft.Extensions.DependencyInjection;
using ToDonut.Negocio.Tarea.Implementacion;
using ToDonut.Negocio.Tarea.Interfaz;

namespace ToDonut.Negocio;

public static class ConfigureServices
{
    public static IServiceCollection AddAplicationServices( this IServiceCollection services)
    {
        services.AddScoped<ITareaNegocio, TareaNegocio>();
        return services;
    }
}
