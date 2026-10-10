# EmpresaAPI

API REST creada con **ASP.NET Core 8** y **Entity Framework Core 8** para la gestión de clientes.

## Requisitos
- .NET 8.0 SDK
- SQL Server 
- Visual Studio 2022

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tuusuario/EmpresaAPI.git

2. Entrar a la carpeta:
   - cd EmpresaAPI

3. Configura la cadena de conexión en appsettings.json:
   - "ConnectionStrings": {
  "EmpresaDB": "Server=localhost;Database=EmpresaDB;Trusted_Connection=True;"
}

4. Aplica las migraciones:
   - dotnet ef database update

5. Endpoints CRUD
   CLIENTES
   - GET /api/clientes → Lista todos los clientes
   - GET /api/clientes/{id} → Obtiene un cliente por ID
   - POST /api/clientes → Crea un nuevo cliente
   - PUT /api/clientes/{id} → Actualiza un cliente existente
   - DELETE /api/clientes/{id} → Elimina un cliente
  
   EJEMPLO DE JSON PARA CREAR CLIENTE
   - {
  "nombre": "Juan Pérez",
  "email": "juan.perez@example.com"
}

6. Pruebas con Swagger
   - Al ejecutar el proyecto, abre en tu navegador:
   - https://localhost:5001/swagger

7. Estructura del proyecto
   EmpresaAPI/
   │
   ├── Controllers/
   │   └── ClientesController.cs
   │
   ├── Data/
   │   └── EmpresaContext.cs
   │
   ├── Models/
   │   └── Cliente.cs
   │
   ├── Migrations/
   │   └── (archivos generados por EF Core)
   │
   ├── Program.cs
   ├── appsettings.json
   └── README.md

8. Resultado esperado
   - Crear, leer, actualizar y eliminar clientes desde la API.
   - Probar los endpoints fácilmente con Swagger.
   - Tener tu repositorio en GitHub con documentación clara y profesional.

9. VIDEO
    - Cargado por commit

   
