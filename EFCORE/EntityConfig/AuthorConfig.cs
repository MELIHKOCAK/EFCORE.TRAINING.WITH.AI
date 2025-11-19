using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE.TRAINING.WITH.AI.EFCORE.EntityConfig;

internal class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        //Primary Key
        builder.HasKey(a => a.Id);

        //Property Features
        #region Property Features
        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(a => a.Surname)
            .IsRequired()
            .HasMaxLength(50);
        #endregion

        //Relationship

    }
}

