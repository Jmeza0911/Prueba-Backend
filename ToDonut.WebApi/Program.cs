using ToDonut.Negocio;
using ToDonut.Datos;
using ToDonut.WebApi.Modules.Feature;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddFeature(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("policyApiTodo");
app.UseAuthorization();
app.MapControllers();
app.Run();
