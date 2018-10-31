using BeerhallEF.Data.Mappers;
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Data {
    public class ApplicationDbContext : DbContext{
        public DbSet<Brewer> Brewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=BeerhallEF;Integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
        }
    }
}
