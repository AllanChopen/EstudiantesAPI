# WebServiceVentas

API RESTful para la gestión de productos y ventas, desarrollada en ASP.NET Core y MySQL.

## Características

- CRUD de productos
- Conexión a base de datos MySQL (tabla `productos`)
- Ejemplo de modelo: Producto (`Id`, `Nombre`, `Precio`)
- API documentada con Swagger

## Requisitos

- .NET 6.0 o superior
- MySQL/MariaDB
- Visual Studio o VS Code

## Instalación

1. **Clona el repositorio**
   ```bash
   git clone https://github.com/AllanChopen/WebServiceVentas.git
   ```

2. **Configura la cadena de conexión en `appsettings.json`**
   ```json
   "ConnectionStrings": {
     "MySqlConnection": "Server=127.0.0.1;Database=VENTAS;User=root;Password=;"
   }
   ```

3. **Crea la tabla en MySQL**
   ```sql
   CREATE TABLE productos (
     id INT AUTO_INCREMENT PRIMARY KEY,
     nombre VARCHAR(255) NOT NULL,
     precio DECIMAL(18,2) NOT NULL
   );
   ```

4. **Restaura los paquetes y ejecuta el proyecto**
   ```bash
   dotnet restore
   dotnet run
   ```

5. **Abre Swagger para probar la API**
   - Normalmente en: `http://localhost:XXXX/swagger`

## Endpoints principales

- `GET /api/Productos` — Listar productos
- `POST /api/Productos` — Crear producto
- `PUT /api/Productos/{id}` — Actualizar producto
- `DELETE /api/Productos/{id}` — Eliminar producto

## Modelo de Producto

```csharp
public class Producto
{
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}
```

## Licencia

MIT


Uso:

POST /api/estudiantes para crear un estudiante (enviar JSON con carnet, nombre, apellido y semestre).

GET /api/estudiantes/{carnet} para obtener un estudiante específico.
