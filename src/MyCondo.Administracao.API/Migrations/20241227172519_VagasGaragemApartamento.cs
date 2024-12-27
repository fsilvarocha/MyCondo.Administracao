using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCondo.Administracao.API.Migrations
{
    /// <inheritdoc />
    public partial class VagasGaragemApartamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Moradores",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 373, DateTimeKind.Local).AddTicks(2610),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 608, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Condominios",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 372, DateTimeKind.Local).AddTicks(649),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 607, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Blocos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 369, DateTimeKind.Local).AddTicks(8561),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 605, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "AreaComuns",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 367, DateTimeKind.Local).AddTicks(3781),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 603, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Apartamentos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 360, DateTimeKind.Local).AddTicks(2175),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 596, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.AddColumn<int>(
                name: "PossuiVagasDemarcada",
                table: "Apartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalVagasDemarcada",
                table: "Apartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PossuiVagasDemarcada",
                table: "Apartamentos");

            migrationBuilder.DropColumn(
                name: "TotalVagasDemarcada",
                table: "Apartamentos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Moradores",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 608, DateTimeKind.Local).AddTicks(9253),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 373, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Condominios",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 607, DateTimeKind.Local).AddTicks(8020),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 372, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Blocos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 605, DateTimeKind.Local).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 369, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "AreaComuns",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 603, DateTimeKind.Local).AddTicks(1704),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 367, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Apartamentos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 22, 21, 10, 36, 596, DateTimeKind.Local).AddTicks(8984),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 25, 18, 360, DateTimeKind.Local).AddTicks(2175));
        }
    }
}
