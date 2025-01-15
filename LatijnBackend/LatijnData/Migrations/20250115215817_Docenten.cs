using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LatijnData.Migrations
{
    /// <inheritdoc />
    public partial class Docenten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_DocentEF_DocentId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocentEF",
                table: "DocentEF");

            migrationBuilder.RenameTable(
                name: "DocentEF",
                newName: "Docenten");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Docenten",
                table: "Docenten",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Docenten_DocentId",
                table: "Sessions",
                column: "DocentId",
                principalTable: "Docenten",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Docenten_DocentId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Docenten",
                table: "Docenten");

            migrationBuilder.RenameTable(
                name: "Docenten",
                newName: "DocentEF");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocentEF",
                table: "DocentEF",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_DocentEF_DocentId",
                table: "Sessions",
                column: "DocentId",
                principalTable: "DocentEF",
                principalColumn: "Id");
        }
    }
}
