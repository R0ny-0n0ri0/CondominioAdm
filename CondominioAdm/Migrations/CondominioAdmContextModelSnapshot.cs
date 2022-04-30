﻿// <auto-generated />
using CondominioAdm.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CondominioAdm.Migrations
{
    [DbContext(typeof(CondominioAdmContext))]
    partial class CondominioAdmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CondominioAdm.Models.Condominio", b =>
                {
                    b.Property<int>("CondominioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CondominioId"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CondominioId");

                    b.ToTable("Condominios");
                });

            modelBuilder.Entity("CondominioAdm.Models.Familia", b =>
                {
                    b.Property<int>("FamiliaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FamiliaId"), 1L, 1);

                    b.Property<int>("Apto")
                        .HasColumnType("int");

                    b.Property<int>("CondominioId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FamiliaId");

                    b.HasIndex("CondominioId");

                    b.ToTable("Familias");
                });

            modelBuilder.Entity("CondominioAdm.Models.Morador", b =>
                {
                    b.Property<int>("MoradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MoradorId"), 1L, 1);

                    b.Property<int>("FamiliaId")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MoradorId");

                    b.HasIndex("FamiliaId");

                    b.ToTable("Moradores");
                });

            modelBuilder.Entity("CondominioAdm.Models.Familia", b =>
                {
                    b.HasOne("CondominioAdm.Models.Condominio", "Condominio")
                        .WithMany("Familia")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condominio");
                });

            modelBuilder.Entity("CondominioAdm.Models.Morador", b =>
                {
                    b.HasOne("CondominioAdm.Models.Familia", "Familia")
                        .WithMany("Morador")
                        .HasForeignKey("FamiliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Familia");
                });

            modelBuilder.Entity("CondominioAdm.Models.Condominio", b =>
                {
                    b.Navigation("Familia");
                });

            modelBuilder.Entity("CondominioAdm.Models.Familia", b =>
                {
                    b.Navigation("Morador");
                });
#pragma warning restore 612, 618
        }
    }
}
