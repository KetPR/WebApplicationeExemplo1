﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationeExemplo1.Data;

#nullable disable

namespace WebApplicationeExemplo1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230904201824_migrationv1")]
    partial class migrationv1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplicationeExemplo1.Models.Alunos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<int>("turmasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("turmasId");

                    b.ToTable("alunos");
                });

            modelBuilder.Entity("WebApplicationeExemplo1.Models.Turmas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("turno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("turmas");
                });

            modelBuilder.Entity("WebApplicationeExemplo1.Models.Alunos", b =>
                {
                    b.HasOne("WebApplicationeExemplo1.Models.Turmas", "turmas")
                        .WithMany("Alunos")
                        .HasForeignKey("turmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("turmas");
                });

            modelBuilder.Entity("WebApplicationeExemplo1.Models.Turmas", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
