﻿// <auto-generated />
using System;
using Chocolateria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chocolateria.Migrations
{
    [DbContext(typeof(ChocolateriaContext))]
    [Migration("20210426142024_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Chocolateria.Models.Chocolate", b =>
                {
                    b.Property<int>("id_Chocolate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cupom_Desconto")
                        .HasColumnType("double");

                    b.Property<DateTime>("Data_Validade")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Marca_Chocolate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Peso_Chocolate")
                        .HasColumnType("double");

                    b.Property<double>("Porcentagem_Cacau")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade_Disponivel")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_Chocolate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Valor_Chocolate")
                        .HasColumnType("double");

                    b.HasKey("id_Chocolate");

                    b.ToTable("Chocolates");
                });
#pragma warning restore 612, 618
        }
    }
}
