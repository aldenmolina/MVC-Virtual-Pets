using Microsoft.EntityFrameworkCore;
using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets
{
    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AldenPets;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasData(
                new Pet() { PetId = 1, Name = "Doofus", Description = "Doofus is doofy" } ,
                new Pet() { PetId = 2, Name = "Graile", Description = "Graile is holy" } ,
                new Pet() { PetId = 3, Name = "Blue", Description = "My boy blue" } 
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
