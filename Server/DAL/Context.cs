using Microsoft.EntityFrameworkCore;
using Parcial2_Luis_Miguel_Jerez_Caceres.Shared.Models;

namespace Parcial2_Luis_Miguel_Jerez_Caceres.Server.DAL;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> Option)
        : base(Option) { }

    public DbSet<Entradas> Entradas { get; set; }
    public DbSet<Productos> Productos { get; set; }
    public DbSet<EntradasDetalle> EntradasDetalle { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Productos>().HasData(new List<Productos>()
        {
            new Productos(){ProductoId=1, Descripcion="Maní", Existencia = 40, Tipo = 0},
            new Productos(){ProductoId=2, Descripcion="Pistachos", Existencia = 600, Tipo = 0},
            new Productos(){ProductoId=3, Descripcion="Pasas", Existencia = 500, Tipo = 0},
            new Productos(){ProductoId=4, Descripcion="Ciruelas", Existencia = 700, Tipo = 0},
            new Productos(){ProductoId=5, Descripcion="Mixto MPP 0.5lb", Existencia = 0, Tipo = 1},
            new Productos(){ProductoId=6, Descripcion="Mixto MPC 0.5lb", Existencia = 0, Tipo = 1},
            new Productos(){ProductoId=7, Descripcion="Mixto MPP 0.2lb", Existencia = 0, Tipo = 1}
        });
    }
}