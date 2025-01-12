using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LatijnData.Migrations
{
    /// <inheritdoc />
    public partial class Toetsen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToetsEFId",
                table: "Vervoegingen",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Klassen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DocentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klassen", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Toetsen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AantalVragen = table.Column<int>(type: "int", nullable: false),
                    AantalGoed = table.Column<int>(type: "int", nullable: false),
                    KlasId = table.Column<int>(type: "int", nullable: false),
                    KlasEFId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toetsen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Toetsen_Klassen_KlasEFId",
                        column: x => x.KlasEFId,
                        principalTable: "Klassen",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vervoegingen_ToetsEFId",
                table: "Vervoegingen",
                column: "ToetsEFId");

            migrationBuilder.CreateIndex(
                name: "IX_Toetsen_KlasEFId",
                table: "Toetsen",
                column: "KlasEFId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vervoegingen_Toetsen_ToetsEFId",
                table: "Vervoegingen",
                column: "ToetsEFId",
                principalTable: "Toetsen",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vervoegingen_Toetsen_ToetsEFId",
                table: "Vervoegingen");

            migrationBuilder.DropTable(
                name: "Toetsen");

            migrationBuilder.DropTable(
                name: "Klassen");

            migrationBuilder.DropIndex(
                name: "IX_Vervoegingen_ToetsEFId",
                table: "Vervoegingen");

            migrationBuilder.DropColumn(
                name: "ToetsEFId",
                table: "Vervoegingen");
        }
    }
}
