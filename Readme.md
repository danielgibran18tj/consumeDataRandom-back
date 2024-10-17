
Abre Visual Studio y crear un proyecto ASP.NET Core Web API.

Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Swashbuckle.AspNetCore

Crea un archivo AppDbContext para definir las tablas:

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Producto> Productos { get; set; }
    public DbSet<Imagen> Imagenes { get; set; }
}


En el archivo appsettings.json, añade la conexión a tu base de datos SQL Server:

"ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=LoggingProyect;Trusted_Connection=True;"
}


luego sigue con la configuración del program y crea el controlador
