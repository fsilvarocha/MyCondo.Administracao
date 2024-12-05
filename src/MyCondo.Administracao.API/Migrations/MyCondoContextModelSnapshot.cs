﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCondo.Administracao.Infra.Data;

#nullable disable

namespace MyCondo.Administracao.API.Migrations
{
    [DbContext(typeof(MyCondoContext))]
    partial class MyCondoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Condominio.Condominios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AreaTotal")
                        .HasColumnType("double(18,5)");

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DataAtualizado")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 12, 5, 17, 19, 0, 122, DateTimeKind.Local).AddTicks(2601));

                    b.Property<string>("Logo")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(15)");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoCondominio")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Condominios", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
