using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configurations
{
    public class FinePostConfiguration : IEntityTypeConfiguration<FinePost>
    {
        public void Configure(EntityTypeBuilder<FinePost> builder)
        {
            builder.Property(p => p.FinePostId)
                   .HasColumnName("FinePostId")
                   .IsRequired();

            builder.Property(p => p.FineId)
                   .HasColumnName("FineId")
                   .IsRequired();

            builder.Property(p => p.FineeId)
                   .HasColumnName("FineeId")
                   .IsRequired();

            builder.Property(p => p.FinerId)
                   .HasColumnName("FinerId")
                   .IsRequired();

            builder.HasMany(p => p.Votes).WithOne(v => v.FinePost);
        }
    }
}
