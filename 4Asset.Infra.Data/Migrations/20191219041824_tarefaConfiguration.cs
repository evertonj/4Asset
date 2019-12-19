using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FourAsset.Infra.Data.Migrations
{
    public partial class tarefaConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tarefas",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 19, 1, 33, 23, 678, DateTimeKind.Local).AddTicks(2681), new DateTime(2019, 12, 19, 1, 18, 23, 678, DateTimeKind.Local).AddTicks(1363), new DateTime(2019, 12, 19, 1, 38, 23, 678, DateTimeKind.Local).AddTicks(1412), new DateTime(2019, 12, 19, 1, 43, 23, 678, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 19, 1, 38, 23, 678, DateTimeKind.Local).AddTicks(5504), new DateTime(2019, 12, 19, 1, 18, 23, 678, DateTimeKind.Local).AddTicks(5478), new DateTime(2019, 12, 19, 1, 43, 23, 678, DateTimeKind.Local).AddTicks(5486), new DateTime(2019, 12, 19, 1, 48, 23, 678, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 19, 1, 43, 23, 678, DateTimeKind.Local).AddTicks(5559), new DateTime(2019, 12, 19, 1, 18, 23, 678, DateTimeKind.Local).AddTicks(5544), new DateTime(2019, 12, 19, 1, 48, 23, 678, DateTimeKind.Local).AddTicks(5552), new DateTime(2019, 12, 19, 1, 53, 23, 678, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 4,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 19, 1, 48, 23, 678, DateTimeKind.Local).AddTicks(5595), new DateTime(2019, 12, 19, 1, 18, 23, 678, DateTimeKind.Local).AddTicks(5582), new DateTime(2019, 12, 19, 1, 53, 23, 678, DateTimeKind.Local).AddTicks(5588), new DateTime(2019, 12, 19, 1, 58, 23, 678, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 5,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 19, 1, 53, 23, 678, DateTimeKind.Local).AddTicks(5631), new DateTime(2019, 12, 19, 1, 18, 23, 678, DateTimeKind.Local).AddTicks(5618), new DateTime(2019, 12, 19, 1, 58, 23, 678, DateTimeKind.Local).AddTicks(5624), new DateTime(2019, 12, 19, 2, 3, 23, 678, DateTimeKind.Local).AddTicks(5638) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tarefas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 18, 10, 6, 0, 380, DateTimeKind.Local).AddTicks(7092), new DateTime(2019, 12, 18, 9, 51, 0, 377, DateTimeKind.Local).AddTicks(6992), new DateTime(2019, 12, 18, 10, 11, 0, 380, DateTimeKind.Local).AddTicks(5341), new DateTime(2019, 12, 18, 10, 16, 0, 380, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 18, 10, 11, 0, 380, DateTimeKind.Local).AddTicks(9080), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9048), new DateTime(2019, 12, 18, 10, 16, 0, 380, DateTimeKind.Local).AddTicks(9071), new DateTime(2019, 12, 18, 10, 21, 0, 380, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 18, 10, 16, 0, 380, DateTimeKind.Local).AddTicks(9107), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9098), new DateTime(2019, 12, 18, 10, 21, 0, 380, DateTimeKind.Local).AddTicks(9103), new DateTime(2019, 12, 18, 10, 26, 0, 380, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 4,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 18, 10, 21, 0, 380, DateTimeKind.Local).AddTicks(9125), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9117), new DateTime(2019, 12, 18, 10, 26, 0, 380, DateTimeKind.Local).AddTicks(9120), new DateTime(2019, 12, 18, 10, 31, 0, 380, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 5,
                columns: new[] { "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao" },
                values: new object[] { new DateTime(2019, 12, 18, 10, 26, 0, 380, DateTimeKind.Local).AddTicks(9142), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9134), new DateTime(2019, 12, 18, 10, 31, 0, 380, DateTimeKind.Local).AddTicks(9138), new DateTime(2019, 12, 18, 10, 36, 0, 380, DateTimeKind.Local).AddTicks(9146) });
        }
    }
}
