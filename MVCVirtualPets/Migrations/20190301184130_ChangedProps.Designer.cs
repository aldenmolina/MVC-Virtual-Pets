﻿// <auto-generated />
using MVCVirtualPets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCVirtualPets.Migrations
{
    [DbContext(typeof(PetContext))]
    [Migration("20190301184130_ChangedProps")]
    partial class ChangedProps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCVirtualPets.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("PetId");

                    b.ToTable("Pets");

                    b.HasData(
                        new { PetId = 1, Description = "Doofus is doofy", Name = "Doofus" },
                        new { PetId = 2, Description = "Graile is holy", Name = "Graile" },
                        new { PetId = 3, Description = "My boy blue", Name = "Blue" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}