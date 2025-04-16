using Conserge.Models;
using Microsoft.EntityFrameworkCore;

namespace Conserge.Data;

/// <summary>
/// The Application Database Context.
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // empty
    }
    
    /// <summary>
    /// The Personas DbSet.
    /// </summary>
    public DbSet<Persona> Personas => Set<Persona>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configura the Persona entity
        modelBuilder.Entity<Persona>();
        
        // Seed the database with initial data
        modelBuilder.Entity<Persona>().HasData(
            new Persona {Nombre = "Tomas", Apellidos = "Reimann", Rut = "196243232", Email = "tomas@gmail.com"}
        );
    }
}