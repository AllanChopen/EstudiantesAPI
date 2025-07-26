using EstudiantesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Configura DB
builder.Services.AddDbContext<EstudiantesContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("EstudiantesDB"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("EstudiantesDB"))
    ));

// Agrega controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Estudiantes API",
        Version = "v1",
        Description = "Web Service para gestión de estudiantes"
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Middleware Swagger siempre activo
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Estudiantes API v1");
});

app.UseAuthorization();
app.MapControllers();

app.Run();
