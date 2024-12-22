using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCondo.Administracao.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condominios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: false),
                    TipoCondominio = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "varchar(500)", nullable: true),
                    AreaTotal = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(150)", nullable: true),
                    Uf = table.Column<string>(type: "varchar(2)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(150)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(150)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(15)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 440, DateTimeKind.Local).AddTicks(6272)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blocos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    QuantidadeAndar = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CondominiosId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 438, DateTimeKind.Local).AddTicks(5278)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blocos_Condominios_CondominiosId",
                        column: x => x.CondominiosId,
                        principalTable: "Condominios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<string>(type: "varchar(20)", nullable: false),
                    Andar = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    TipoApartamento = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    BlocosId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 432, DateTimeKind.Local).AddTicks(1322)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartamentos_Blocos_BlocosId",
                        column: x => x.BlocosId,
                        principalTable: "Blocos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    TipoMorador = table.Column<int>(type: "INTEGER", nullable: false),
                    ApartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Foto = table.Column<string>(type: "TEXT", nullable: false),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 441, DateTimeKind.Local).AddTicks(8342)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moradores_Apartamentos_ApartamentoId",
                        column: x => x.ApartamentoId,
                        principalTable: "Apartamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartamentos_BlocosId",
                table: "Apartamentos",
                column: "BlocosId");

            migrationBuilder.CreateIndex(
                name: "IX_Blocos_CondominiosId",
                table: "Blocos",
                column: "CondominiosId");

            migrationBuilder.CreateIndex(
                name: "IX_Moradores_ApartamentoId",
                table: "Moradores",
                column: "ApartamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moradores");

            migrationBuilder.DropTable(
                name: "Apartamentos");

            migrationBuilder.DropTable(
                name: "Blocos");

            migrationBuilder.DropTable(
                name: "Condominios");
        }
    }
}
