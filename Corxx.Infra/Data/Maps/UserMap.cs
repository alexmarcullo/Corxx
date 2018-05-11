using Corxx.Domain.Entities;
using Corxx.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Corxx.Infra.Data.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Email.Address)
                .HasColumnName("Email")
                .HasMaxLength(60)
                .HasColumnType(ColType.Varchar(200))
                .IsRequired();

            builder
                .Property(x => x.Name.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(60)
                .HasColumnType(ColType.Varchar(60))
                .IsRequired();

            builder
                .Property(x => x.Name.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(60)
                .HasColumnType(ColType.Varchar(60))
                .IsRequired();
        }
    }
}
