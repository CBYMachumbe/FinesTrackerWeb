using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configurations
{
    public class FinesConfiguration: IEntityTypeConfiguration<Fines>
    {
        public void Configure(EntityTypeBuilder<Fines> builder)
        {

            builder.HasKey(e => e.FineId);

            builder.Property(e => e.FineId).HasColumnName("FineId");

            builder.Property(e => e.FineText)
                    .HasColumnName("FineText")
                    .HasMaxLength(255)
                    .IsUnicode(false);

            builder.Property(e => e.FineTitle)
                    .HasColumnName("FineTitle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

            //builder.HasMany(p => p.FinePosts).WithOne(f => f.Fine).HasForeignKey(f => f.FineId);
           
        }
    }
}
