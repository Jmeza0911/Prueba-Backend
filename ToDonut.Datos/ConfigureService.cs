
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDonut.Datos.Contexts;
using ToDonut.Datos.Repositorios.Tareas.Implementacion;
using ToDonut.Datos.Repositorios.Tareas.Interfaces;

namespace ToDonut.Datos;

public static class ConfigureService
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<DapperContext>();
        services.AddScoped<ITareasRepositorio, TareasRepositorio>();
        return services;
    }
}
