using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyCondo.Administracao.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialPostgree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condominios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: false),
                    TipoCondominio = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "varchar(500)", nullable: true),
                    AreaTotal = table.Column<double>(type: "double precision", nullable: false),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(150)", nullable: true),
                    Uf = table.Column<string>(type: "varchar(2)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(150)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(150)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(15)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tenante = table.Column<Guid>(type: "uuid", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 12, 6, 10, 33, 15, 183, DateTimeKind.Local).AddTicks(2666)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Condominios");
        }
    }
}
