using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint1_C_.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CP_FILIAIS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Pais = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP_FILIAIS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CP_PATIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Largura = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Comprimento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FilialId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP_PATIOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CP_PATIOS_CP_FILIAIS_FilialId",
                        column: x => x.FilialId,
                        principalTable: "CP_FILIAIS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CP_MOTOS",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Modelo = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Marca = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PatioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP_MOTOS", x => x.Placa);
                    table.ForeignKey(
                        name: "FK_CP_MOTOS_CP_PATIOS_PatioId",
                        column: x => x.PatioId,
                        principalTable: "CP_PATIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CP_MOTOS_PatioId",
                table: "CP_MOTOS",
                column: "PatioId");

            migrationBuilder.CreateIndex(
                name: "IX_CP_PATIOS_FilialId",
                table: "CP_PATIOS",
                column: "FilialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CP_MOTOS");

            migrationBuilder.DropTable(
                name: "CP_PATIOS");

            migrationBuilder.DropTable(
                name: "CP_FILIAIS");
        }
    }
}
