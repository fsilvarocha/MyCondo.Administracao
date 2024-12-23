using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCondo.Administracao.API.Migrations
{
    /// <inheritdoc />
    public partial class Crud_AreaComum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Moradores",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 608, DateTimeKind.Local).AddTicks(9253),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 441, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Condominios",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 607, DateTimeKind.Local).AddTicks(8020),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 440, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Blocos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 605, DateTimeKind.Local).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 438, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Apartamentos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 596, DateTimeKind.Local).AddTicks(8984),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 432, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.CreateTable(
                name: "AreaComuns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(500)", nullable: false),
                    ValorLocacao = table.Column<decimal>(type: "TEXT", nullable: false, defaultValue: 0m),
                    ExcluirBoletoAoCancelar = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    LiberarBoletoAtoReserva = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    PagarBoletoAposReserva = table.Column<bool>(type: "INTEGER", nullable: true, defaultValue: true),
                    DiasAntecedenciaLocacao = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 5),
                    HoraMinima = table.Column<TimeSpan>(type: "TEXT", nullable: true),
                    HoraMaxima = table.Column<TimeSpan>(type: "TEXT", nullable: true),
                    HorarioInicial = table.Column<TimeSpan>(type: "TEXT", nullable: true),
                    HorarioMaxima = table.Column<TimeSpan>(type: "TEXT", nullable: true),
                    PermitirLocacaoInadimplentes = table.Column<bool>(type: "INTEGER", nullable: false),
                    PrazoReserva = table.Column<int>(type: "INTEGER", nullable: false),
                    PrazoCancelamento = table.Column<int>(type: "INTEGER", nullable: false),
                    QuantidadeLocacaoTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    DataVencimentoBoleto = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PermitirMaisDeUmaReservaDia = table.Column<bool>(type: "INTEGER", nullable: false),
                    ExibirReservaCancelada = table.Column<bool>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CondominiosId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 603, DateTimeKind.Local).AddTicks(1704)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaComuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaComuns_Condominios_CondominiosId",
                        column: x => x.CondominiosId,
                        principalTable: "Condominios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaComuns_CondominiosId",
                table: "AreaComuns",
                column: "CondominiosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaComuns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Moradores",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 441, DateTimeKind.Local).AddTicks(8342),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 608, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Condominios",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 440, DateTimeKind.Local).AddTicks(6272),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 607, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Blocos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 438, DateTimeKind.Local).AddTicks(5278),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 605, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Apartamentos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 19, 46, 14, 432, DateTimeKind.Local).AddTicks(1322),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 596, DateTimeKind.Local).AddTicks(8984));
        }
    }
}
