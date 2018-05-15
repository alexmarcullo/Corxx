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
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder
                .OwnsOne(x=> x.Name)
                .Property(x=> x.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(60)
                .HasColumnType(ColType.Varchar(60))
                .IsRequired();

            builder
                .OwnsOne(x => x.Name)
                .Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(60)
                .HasColumnType(ColType.Varchar(60))
                .IsRequired();

            builder
                .OwnsOne(x=> x.Email)
                .Property(x => x.Address)
                .HasColumnName("Email")
                .HasMaxLength(60)
                .HasColumnType(ColType.Varchar(200))
                .IsRequired();
        }
    }
}
