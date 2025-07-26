# EstudiantesAPI

Descripción
EstudiantesAPI es un servicio web RESTful desarrollado en ASP.NET Core que permite la gestión básica de estudiantes en un sistema académico. Proporciona endpoints para crear y obtener estudiantes mediante HTTP POST y GET. Utiliza Entity Framework Core con MySQL para persistencia de datos.

Características principales:

Crear estudiantes con información básica (carnet, nombre, apellido, semestre).

Consultar estudiantes por carnet.

Documentación automática de la API mediante Swagger/OpenAPI.

Código limpio y comentado para facilitar mantenimiento y ampliación.

Tecnologías utilizadas:

.NET 8.0

ASP.NET Core Web API

Entity Framework Core con Pomelo MySQL

Swagger / Swashbuckle para documentación API

Requisitos:

MySQL (o MariaDB) funcionando y accesible.

Cadena de conexión configurada en appsettings.json.

.NET SDK 8.0 instalado.

Instalación y ejecución:

Clonar el repositorio.

Configurar la cadena de conexión en appsettings.json con los datos de tu base MySQL.

Restaurar paquetes:

bash
Copy code
dotnet restore
Ejecutar la aplicación:

bash
Copy code
dotnet run
Acceder a Swagger UI para probar la API en:
http://localhost:5000/swagger/index.html (ajustar puerto según configuración).

Uso:

POST /api/estudiantes para crear un estudiante (enviar JSON con carnet, nombre, apellido y semestre).

GET /api/estudiantes/{carnet} para obtener un estudiante específico.
