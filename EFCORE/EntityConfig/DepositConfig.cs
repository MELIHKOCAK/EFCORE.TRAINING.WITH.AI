using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCORE.TRAINING.WITH.AI.EFCORE.EntityConfig
{
    internal class DepositConfig : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            //Primary Key
            builder.HasKey(d => d.Id);

            //Property Features
            #region Property Features
            builder.Property(d => d.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(d => d.DepositDate)
                .IsRequired();

            builder.Property(d => d.DeliveryDate)
                .IsRequired();
            #endregion

            //Relationship
            builder.HasOne(d => d.Book)
                .WithMany(b => b.Deposit)
                .HasForeignKey(b =>b.BookId);

        }
    }
}
