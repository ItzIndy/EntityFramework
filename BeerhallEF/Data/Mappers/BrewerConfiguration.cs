using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data.Mappers {
    public class BrewerConfiguration : IEntityTypeConfiguration<Brewer> {
        public void Configure(EntityTypeBuilder<Brewer> builder) {
            builder.ToTable("Brouwer");
            builder.Property(e => e.Name).HasMaxLength(30).IsRequired();
            builder.Property(e => e.Street).IsFixedLength(true).HasMaxLength(50).IsFixedLength();
            builder.HasMany(e => e.Beers).WithOne().IsRequired().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
