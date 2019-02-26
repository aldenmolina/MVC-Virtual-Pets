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
                new Pet() { Id = 1, Name = "Doofus" } ,
                new Pet() { Id = 2, Name = "Graile" } ,
                new Pet() { Id = 3, Name = "Blue" } 
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
