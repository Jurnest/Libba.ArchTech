using Libba.ArchTech.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Libba.ArchTech.Infrastructure.Persistance.EF.Context;

public class ArchTechContext : DbContext
{
    public ArchTechContext(DbContextOptions<ArchTechContext> options) : base(options) 
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArchTechContext).Assembly);

        var entityTypes = typeof(BaseEntity).Assembly
            .GetTypes()
            .Where(t => t.IsClass
                     && !t.IsAbstract
                     && typeof(BaseEntity).IsAssignableFrom(t));

        foreach (var entityType in entityTypes)
        {
            modelBuilder.Entity(entityType);
        }
    }
}
