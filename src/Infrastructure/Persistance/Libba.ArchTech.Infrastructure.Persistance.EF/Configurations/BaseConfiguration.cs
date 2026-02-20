using Libba.ArchTech.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libba.ArchTech.Infrastructure.Persistance.EF.Configurations;

public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(e => e.Id);

        #region Columns
        builder.Property(e => e.Id).HasColumnName("ID").HasColumnOrder(0);
        builder.Property(e => e.CreatedBy).HasColumnName("CREATED_BY").HasColumnOrder(1);
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT").HasColumnOrder(2);
        builder.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY").HasColumnOrder(3);
        builder.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT").HasColumnOrder(4);
        #endregion
    }
}
