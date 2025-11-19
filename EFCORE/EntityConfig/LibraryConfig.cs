using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE.TRAINING.WITH.AI.EFCORE.EntityConfig;

public class LibraryConfig : IEntityTypeConfiguration<Library>
{
    public void Configure(EntityTypeBuilder<Library> builder)
    {
        //Primary Key
        builder.HasKey(l => l.Id);

        //Property Features
        #region Property Features
        builder.Property(l => l.Id)
            .UseIdentityColumn(seed: 1, increment: 1);

        builder.Property(l => l.Name)
            .HasMaxLength(100)
            .IsRequired();

        #endregion

        //Relationships
        builder.HasOne(l => l.Address)
            .WithOne(a => a.Library)
            .HasForeignKey<Library>(l => l.AddressId);
    }
}

