﻿// <auto-generated />
using AgendaMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgendaMVC.Migrations
{
    [DbContext(typeof(AgendaMVCContext))]
    partial class AgendaMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("AgendaMVC.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Numero")
                        .IsRequired();

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Contacto");
                });
#pragma warning restore 612, 618
        }
    }
}
