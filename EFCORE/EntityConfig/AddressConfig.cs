using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE.TRAINING.WITH.AI.EFCORE.EntityConfig;

public class AddressConfig : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        //Primary Key
        builder.HasKey(a => a.ID);


        //Property Feauters
        #region Property Feauters
        builder.Property(a => a.ID)
           .UseIdentityColumn(seed: 1, increment: 1);

        builder.Property(a => a.City)
           .HasMaxLength(50)
           .IsRequired();

        builder.Property(a => a.Quarter)
           .HasMaxLength(100)
           .IsRequired();

        builder.Property(a => a.Country)
           .HasMaxLength(50)
           .IsRequired();

        builder.Property(a => a.Street)
          .HasMaxLength(100)
          .IsRequired();

        builder.Property(a => a.BuildingNo)
          .HasMaxLength(10)
          .IsRequired();

        builder.Property(a => a.ZipCode)
         .HasMaxLength(10)
         .IsRequired();
        #endregion

        //Relationship
        builder.HasMany(a => a.Users)
            .WithOne(u => u.Address)
            .HasForeignKey(u => u.AddressId);

    }
}

