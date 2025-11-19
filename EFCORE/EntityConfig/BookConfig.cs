using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE.TRAINING.WITH.AI.EFCORE.EntityConfig;

internal class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        //Primary Key
        builder.HasKey(b => b.Id);

        //Property Features
        #region Property Features
        builder.Property(b => b.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(b => b.PageCount)
            .IsRequired();

        #endregion

        //Relationships
        #region Relationships
        builder.HasMany(b => b.Categories)
               .WithMany(c => c.Books);

        builder.HasMany(b => b.Author)
            .WithMany(a => a.Books);


        builder.HasMany(b => b.Libraries)
            .WithMany(l => l.Books)
            .UsingEntity<Dictionary<string, object>>(
                "LibraryBooks",
                x => x.HasOne<Library>().WithMany().HasForeignKey("LibraryId").HasConstraintName("FK_LibraryId"),
                x => x.HasOne<Book>().WithMany().HasForeignKey("BookId").HasConstraintName("FK_BookID"),

                join =>
                {
                    join.Property<int>("Count").HasDefaultValueSql("int");
                }
            );
        #endregion
    }
}

