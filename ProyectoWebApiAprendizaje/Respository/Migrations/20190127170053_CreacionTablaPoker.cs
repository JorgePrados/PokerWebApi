using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class CreacionTablaPoker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cartas",
                columns: table => new
                {
                    Codigo = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Palo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartas", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    stackInicial = table.Column<decimal>(nullable: false),
                    Jugadores = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jugadas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PartidaId = table.Column<int>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    CartaFlop1Codigo = table.Column<string>(nullable: true),
                    CartaFlop2Codigo = table.Column<string>(nullable: true),
                    CartaFlop3Codigo = table.Column<string>(nullable: true),
                    CartaTurnCodigo = table.Column<string>(nullable: true),
                    CartaRiverCodigo = table.Column<string>(nullable: true),
                    BotePreFlop = table.Column<decimal>(nullable: false),
                    BoteFlop = table.Column<decimal>(nullable: false),
                    BoteTurn = table.Column<decimal>(nullable: false),
                    BoteRiver = table.Column<decimal>(nullable: false),
                    JugadoresRestantesPreFlop = table.Column<int>(nullable: false),
                    JugadoresRestantesFlop = table.Column<int>(nullable: false),
                    JugadoresRestantesTurn = table.Column<int>(nullable: false),
                    JugadoresRestantesRiver = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadas_Cartas_CartaFlop1Codigo",
                        column: x => x.CartaFlop1Codigo,
                        principalTable: "Cartas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadas_Cartas_CartaFlop2Codigo",
                        column: x => x.CartaFlop2Codigo,
                        principalTable: "Cartas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadas_Cartas_CartaFlop3Codigo",
                        column: x => x.CartaFlop3Codigo,
                        principalTable: "Cartas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadas_Cartas_CartaRiverCodigo",
                        column: x => x.CartaRiverCodigo,
                        principalTable: "Cartas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadas_Cartas_CartaTurnCodigo",
                        column: x => x.CartaTurnCodigo,
                        principalTable: "Cartas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadas_Partida_PartidaId",
                        column: x => x.PartidaId,
                        principalTable: "Partida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ManosIniciales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JugadaId = table.Column<int>(nullable: true),
                    Carta1Codigo = table.Column<string>(nullable: true),
                    Carta2Codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManosIniciales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManosIniciales_Cartas_Carta1Codigo",
                        column: x => x.Carta1Codigo,
                        principalTable: "Cartas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManosIniciales_Cartas_Carta2Codigo",
                        column: x => x.Carta2Codigo,
                        principalTable: "Cartas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManosIniciales_Jugadas_JugadaId",
                        column: x => x.JugadaId,
                        principalTable: "Jugadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugadas_CartaFlop1Codigo",
                table: "Jugadas",
                column: "CartaFlop1Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadas_CartaFlop2Codigo",
                table: "Jugadas",
                column: "CartaFlop2Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadas_CartaFlop3Codigo",
                table: "Jugadas",
                column: "CartaFlop3Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadas_CartaRiverCodigo",
                table: "Jugadas",
                column: "CartaRiverCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadas_CartaTurnCodigo",
                table: "Jugadas",
                column: "CartaTurnCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadas_PartidaId",
                table: "Jugadas",
                column: "PartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ManosIniciales_Carta1Codigo",
                table: "ManosIniciales",
                column: "Carta1Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_ManosIniciales_Carta2Codigo",
                table: "ManosIniciales",
                column: "Carta2Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_ManosIniciales_JugadaId",
                table: "ManosIniciales",
                column: "JugadaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManosIniciales");

            migrationBuilder.DropTable(
                name: "Jugadas");

            migrationBuilder.DropTable(
                name: "Cartas");

            migrationBuilder.DropTable(
                name: "Partida");
        }
    }
}
