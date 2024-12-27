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

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Apartamento.Apartamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Andar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("BlocosId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAtualizado")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 12, 27, 15, 16, 13, 553, DateTimeKind.Local).AddTicks(2981));

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("PossuiVagasDemarcada")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoApartamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("TotalVagasDemarcada")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BlocosId");

                    b.ToTable("Apartamentos", (string)null);
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.AreaComun.AreaComuns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CondominiosId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAtualizado")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 12, 27, 15, 16, 13, 560, DateTimeKind.Local).AddTicks(9956));

                    b.Property<DateTime?>("DataVencimentoBoleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<int>("DiasAntecedenciaLocacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(5);

                    b.Property<bool>("ExcluirBoletoAoCancelar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<bool>("ExibirReservaCancelada")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan?>("HoraMaxima")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("HoraMinima")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("HorarioInicial")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("HorarioMaxima")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LiberarBoletoAtoReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<bool?>("PagarBoletoAposReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<bool>("PermitirLocacaoInadimplentes")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PermitirMaisDeUmaReservaDia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrazoCancelamento")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrazoReserva")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantidadeLocacaoTotal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorLocacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.HasIndex("CondominiosId");

                    b.ToTable("AreaComuns", (string)null);
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Bloco.Blocos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CondominiosId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAtualizado")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 12, 27, 15, 16, 13, 563, DateTimeKind.Local).AddTicks(3755));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("QuantidadeAndar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CondominiosId");

                    b.ToTable("Blocos", (string)null);
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Condominio.Condominios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AreaTotal")
                        .HasColumnType("decimal(18,5)");

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
                        .HasDefaultValue(new DateTime(2024, 12, 27, 15, 16, 13, 564, DateTimeKind.Local).AddTicks(9198));

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

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Morador.Moradores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataAtualizado")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 12, 27, 15, 16, 13, 565, DateTimeKind.Local).AddTicks(9970));

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoMorador")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ApartamentoId");

                    b.ToTable("Moradores", (string)null);
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.VagaGaragem.VagasGaragem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataAtualizado")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2024, 12, 27, 15, 16, 13, 567, DateTimeKind.Local).AddTicks(1410));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Tenante")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ApartamentoId");

                    b.ToTable("VagasGaragem", (string)null);
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Apartamento.Apartamentos", b =>
                {
                    b.HasOne("MyCondo.Administracao.Domain.Entities.Bloco.Blocos", "Blocos")
                        .WithMany("Apartamentos")
                        .HasForeignKey("BlocosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blocos");
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.AreaComun.AreaComuns", b =>
                {
                    b.HasOne("MyCondo.Administracao.Domain.Entities.Condominio.Condominios", "Condominios")
                        .WithMany("AreaComuns")
                        .HasForeignKey("CondominiosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condominios");
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Bloco.Blocos", b =>
                {
                    b.HasOne("MyCondo.Administracao.Domain.Entities.Condominio.Condominios", "Condominios")
                        .WithMany("Blocos")
                        .HasForeignKey("CondominiosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condominios");
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Morador.Moradores", b =>
                {
                    b.HasOne("MyCondo.Administracao.Domain.Entities.Apartamento.Apartamentos", "Apartamentos")
                        .WithMany("Moradores")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartamentos");
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.VagaGaragem.VagasGaragem", b =>
                {
                    b.HasOne("MyCondo.Administracao.Domain.Entities.Apartamento.Apartamentos", "Apartamentos")
                        .WithMany("VagasGaragem")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartamentos");
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Apartamento.Apartamentos", b =>
                {
                    b.Navigation("Moradores");

                    b.Navigation("VagasGaragem");
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Bloco.Blocos", b =>
                {
                    b.Navigation("Apartamentos");
                });

            modelBuilder.Entity("MyCondo.Administracao.Domain.Entities.Condominio.Condominios", b =>
                {
                    b.Navigation("AreaComuns");

                    b.Navigation("Blocos");
                });
#pragma warning restore 612, 618
        }
    }
}
