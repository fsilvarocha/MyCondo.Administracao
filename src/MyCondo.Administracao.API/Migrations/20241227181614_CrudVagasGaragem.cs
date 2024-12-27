using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCondo.Administracao.API.Migrations
{
    /// <inheritdoc />
    public partial class CrudVagasGaragem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Moradores",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 565, DateTimeKind.Local).AddTicks(9970),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 373, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Condominios",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 564, DateTimeKind.Local).AddTicks(9198),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 372, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Blocos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 563, DateTimeKind.Local).AddTicks(3755),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 369, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "AreaComuns",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 560, DateTimeKind.Local).AddTicks(9956),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 367, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Apartamentos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 553, DateTimeKind.Local).AddTicks(2981),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 360, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.CreateTable(
                name: "VagasGaragem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    ApartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 567, DateTimeKind.Local).AddTicks(1410)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagasGaragem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VagasGaragem_Apartamentos_ApartamentoId",
                        column: x => x.ApartamentoId,
                        principalTable: "Apartamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VagasGaragem_ApartamentoId",
                table: "VagasGaragem",
                column: "ApartamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VagasGaragem");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Moradores",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 373, DateTimeKind.Local).AddTicks(2610),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 565, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Condominios",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 372, DateTimeKind.Local).AddTicks(649),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 564, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Blocos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 369, DateTimeKind.Local).AddTicks(8561),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 563, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "AreaComuns",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 367, DateTimeKind.Local).AddTicks(3781),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 560, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Apartamentos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 360, DateTimeKind.Local).AddTicks(2175),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 16, 13, 553, DateTimeKind.Local).AddTicks(2981));
        }
    }
}
