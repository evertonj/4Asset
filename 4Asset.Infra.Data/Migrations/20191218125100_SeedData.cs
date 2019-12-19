using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FourAsset.Infra.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    TarefaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    DataDeCriacao = table.Column<DateTime>(nullable: false),
                    DataDeEdicao = table.Column<DateTime>(nullable: false),
                    DataDeRemocao = table.Column<DateTime>(nullable: false),
                    DataDeConclusao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.TarefaId);
                });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "DataDeConclusao", "DataDeCriacao", "DataDeEdicao", "DataDeRemocao", "Descricao", "Status", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 12, 18, 10, 6, 0, 380, DateTimeKind.Local).AddTicks(7092), new DateTime(2019, 12, 18, 9, 51, 0, 377, DateTimeKind.Local).AddTicks(6992), new DateTime(2019, 12, 18, 10, 11, 0, 380, DateTimeKind.Local).AddTicks(5341), new DateTime(2019, 12, 18, 10, 16, 0, 380, DateTimeKind.Local).AddTicks(8039), "Tarefa de teste 1", false, "Tarefa 1" },
                    { 2, new DateTime(2019, 12, 18, 10, 11, 0, 380, DateTimeKind.Local).AddTicks(9080), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9048), new DateTime(2019, 12, 18, 10, 16, 0, 380, DateTimeKind.Local).AddTicks(9071), new DateTime(2019, 12, 18, 10, 21, 0, 380, DateTimeKind.Local).AddTicks(9089), "Tarefa de teste 2", false, "Tarefa 2" },
                    { 3, new DateTime(2019, 12, 18, 10, 16, 0, 380, DateTimeKind.Local).AddTicks(9107), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9098), new DateTime(2019, 12, 18, 10, 21, 0, 380, DateTimeKind.Local).AddTicks(9103), new DateTime(2019, 12, 18, 10, 26, 0, 380, DateTimeKind.Local).AddTicks(9111), "Tarefa de teste 3", false, "Tarefa 2" },
                    { 4, new DateTime(2019, 12, 18, 10, 21, 0, 380, DateTimeKind.Local).AddTicks(9125), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9117), new DateTime(2019, 12, 18, 10, 26, 0, 380, DateTimeKind.Local).AddTicks(9120), new DateTime(2019, 12, 18, 10, 31, 0, 380, DateTimeKind.Local).AddTicks(9129), "Tarefa de teste 4", false, "Tarefa 4" },
                    { 5, new DateTime(2019, 12, 18, 10, 26, 0, 380, DateTimeKind.Local).AddTicks(9142), new DateTime(2019, 12, 18, 9, 51, 0, 380, DateTimeKind.Local).AddTicks(9134), new DateTime(2019, 12, 18, 10, 31, 0, 380, DateTimeKind.Local).AddTicks(9138), new DateTime(2019, 12, 18, 10, 36, 0, 380, DateTimeKind.Local).AddTicks(9146), "Tarefa de teste 5", false, "Tarefa 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
