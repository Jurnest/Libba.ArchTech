using Libba.ArchTech.Core.Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libba.ArchTech.Infrastructure.Persistance.EF.Configurations.Auth;

public class UserConfiguration : BaseConfiguration<UserEntity>
{
    public override void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        base.Configure(builder);

        builder.ToTable("USER");

        #region Columns
        builder.Property(e => e.Username).HasColumnName("USERNAME");
        builder.Property(e => e.EMail).HasColumnName("E_MAIL");
        builder.Property(e => e.PhoneCode).HasColumnName("PHONE_CODE");
        builder.Property(e => e.PhoneNumber).HasColumnName("PHONE_NUMBER");
        builder.Property(e => e.PasswordHash).HasColumnName("PASSWORD_HASH");
        #endregion

    }
}
