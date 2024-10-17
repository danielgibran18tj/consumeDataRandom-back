using ConsumeAgrosotf.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ConsumeAgrosotf.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
    }
}
