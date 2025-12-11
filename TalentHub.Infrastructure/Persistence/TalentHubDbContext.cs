using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TalentHub.Domain; 

namespace TalentHub.Infrastructure.Persistence;

public class TalentHubDbContext : DbContext
{ 
    // Constructor de la BD
    public TalentHubDbContext(DbContextOptions<TalentHubDbContext> options)
        : base(options)
    {
    }

    // Tabla en la BD
    public DbSet<JobOffer> JobOffers { get; set; } = default!;


    // Configurar cómo se mapean los nombres
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Esto le dice a EF que use el nombre exacto de la tabla o haga configuraciones
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TalentHubDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
