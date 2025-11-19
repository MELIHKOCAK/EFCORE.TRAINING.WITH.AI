using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE.TRAINING.WITH.AI.EFCORE.EntityConfig;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        //Primary Key
        builder.HasKey(u => u.Id);

        //Property Features
        #region Property Features

        builder.Property(u => u.Id)
            .UseIdentityColumn(1, 1);

        builder.Property(u => u.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(u => u.Surname)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(u => u.Gender)
            .IsRequired();

        builder.Property(u => u.Mail)
           .IsRequired();

        builder.Property(u => u.PhoneNumber)
            .HasMaxLength(10)
            .IsRequired();
        #endregion

        //Relationship
        builder.HasMany(u => u.Deposits)
               .WithOne(d => d.User)
               .HasForeignKey(d => d.UserId);

    }
}

