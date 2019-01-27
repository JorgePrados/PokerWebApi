﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190127170053_CreacionTablaPoker")]
    partial class CreacionTablaPoker
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Model.Carta", b =>
                {
                    b.Property<string>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Numero");

                    b.Property<string>("Palo");

                    b.HasKey("Codigo");

                    b.ToTable("Cartas");
                });

            modelBuilder.Entity("Models.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Models.Model.Jugada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BoteFlop");

                    b.Property<decimal>("BotePreFlop");

                    b.Property<decimal>("BoteRiver");

                    b.Property<decimal>("BoteTurn");

                    b.Property<string>("CartaFlop1Codigo");

                    b.Property<string>("CartaFlop2Codigo");

                    b.Property<string>("CartaFlop3Codigo");

                    b.Property<string>("CartaRiverCodigo");

                    b.Property<string>("CartaTurnCodigo");

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("JugadoresRestantesFlop");

                    b.Property<int>("JugadoresRestantesPreFlop");

                    b.Property<int>("JugadoresRestantesRiver");

                    b.Property<int>("JugadoresRestantesTurn");

                    b.Property<int?>("PartidaId");

                    b.HasKey("Id");

                    b.HasIndex("CartaFlop1Codigo");

                    b.HasIndex("CartaFlop2Codigo");

                    b.HasIndex("CartaFlop3Codigo");

                    b.HasIndex("CartaRiverCodigo");

                    b.HasIndex("CartaTurnCodigo");

                    b.HasIndex("PartidaId");

                    b.ToTable("Jugadas");
                });

            modelBuilder.Entity("Models.Model.ManoInicial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Carta1Codigo");

                    b.Property<string>("Carta2Codigo");

                    b.Property<int?>("JugadaId");

                    b.HasKey("Id");

                    b.HasIndex("Carta1Codigo");

                    b.HasIndex("Carta2Codigo");

                    b.HasIndex("JugadaId");

                    b.ToTable("ManosIniciales");
                });

            modelBuilder.Entity("Models.Model.Partida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("Jugadores");

                    b.Property<decimal>("stackInicial");

                    b.HasKey("Id");

                    b.ToTable("Partida");
                });

            modelBuilder.Entity("Models.Model.Jugada", b =>
                {
                    b.HasOne("Models.Model.Carta", "CartaFlop1")
                        .WithMany()
                        .HasForeignKey("CartaFlop1Codigo");

                    b.HasOne("Models.Model.Carta", "CartaFlop2")
                        .WithMany()
                        .HasForeignKey("CartaFlop2Codigo");

                    b.HasOne("Models.Model.Carta", "CartaFlop3")
                        .WithMany()
                        .HasForeignKey("CartaFlop3Codigo");

                    b.HasOne("Models.Model.Carta", "CartaRiver")
                        .WithMany()
                        .HasForeignKey("CartaRiverCodigo");

                    b.HasOne("Models.Model.Carta", "CartaTurn")
                        .WithMany()
                        .HasForeignKey("CartaTurnCodigo");

                    b.HasOne("Models.Model.Partida", "Partida")
                        .WithMany()
                        .HasForeignKey("PartidaId");
                });

            modelBuilder.Entity("Models.Model.ManoInicial", b =>
                {
                    b.HasOne("Models.Model.Carta", "Carta1")
                        .WithMany()
                        .HasForeignKey("Carta1Codigo");

                    b.HasOne("Models.Model.Carta", "Carta2")
                        .WithMany()
                        .HasForeignKey("Carta2Codigo");

                    b.HasOne("Models.Model.Jugada", "Jugada")
                        .WithMany()
                        .HasForeignKey("JugadaId");
                });
#pragma warning restore 612, 618
        }
    }
}