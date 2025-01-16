using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LatijnData.Migrations
{
    /// <inheritdoc />
    public partial class Session : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toetsen_Klassen_KlasEFId",
                table: "Toetsen");

            migrationBuilder.DropTable(
                name: "Klassen");

            migrationBuilder.RenameColumn(
                name: "KlasId",
                table: "Toetsen",
                newName: "SessionId");

            migrationBuilder.RenameColumn(
                name: "KlasEFId",
                table: "Toetsen",
                newName: "SessionEFId");

            migrationBuilder.RenameIndex(
                name: "IX_Toetsen_KlasEFId",
                table: "Toetsen",
                newName: "IX_Toetsen_SessionEFId");

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DocentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Toetsen_Sessions_SessionEFId",
                table: "Toetsen",
                column: "SessionEFId",
                principalTable: "Sessions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toetsen_Sessions_SessionEFId",
                table: "Toetsen");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "Toetsen",
                newName: "KlasId");

            migrationBuilder.RenameColumn(
                name: "SessionEFId",
                table: "Toetsen",
                newName: "KlasEFId");

            migrationBuilder.RenameIndex(
                name: "IX_Toetsen_SessionEFId",
                table: "Toetsen",
                newName: "IX_Toetsen_KlasEFId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Toetsen_Klassen_KlasEFId",
                table: "Toetsen",
                column: "KlasEFId",
                principalTable: "Klassen",
                principalColumn: "Id");
        }
    }
}
