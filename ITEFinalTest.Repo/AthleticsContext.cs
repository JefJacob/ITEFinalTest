using System;
using System.Collections.Generic;
using System.Text;
using ITEFinalTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITEFinalTest.Repo
{
    public class AthleticsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VAIO;Database=AthleticsDBv1;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoachEntity>()
                .HasMany(c => c.Athletes)
                .WithOne(a => a.Coach);
        }
        public DbSet<AthleteEntity> Athletes { get; set; }

        public DbSet<CoachEntity> Coaches { get; set; }
    }
}
