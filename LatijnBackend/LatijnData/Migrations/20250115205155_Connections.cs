using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LatijnData.Migrations
{
    /// <inheritdoc />
    public partial class Connections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toetsen_Sessions_SessionEFId",
                table: "Toetsen");

            migrationBuilder.DropForeignKey(
                name: "FK_Vervoegingen_Toetsen_ToetsEFId",
                table: "Vervoegingen");

            migrationBuilder.DropIndex(
                name: "IX_Vervoegingen_ToetsEFId",
                table: "Vervoegingen");

            migrationBuilder.DropIndex(
                name: "IX_Toetsen_SessionEFId",
                table: "Toetsen");

            migrationBuilder.DropColumn(
                name: "ToetsEFId",
                table: "Vervoegingen");

            migrationBuilder.DropColumn(
                name: "SessionEFId",
                table: "Toetsen");

            migrationBuilder.AlterColumn<int>(
                name: "ToetsId",
                table: "Vervoegingen",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Toetsen",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Toetsen",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vervoegingen_ToetsId",
                table: "Vervoegingen",
                column: "ToetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Toetsen_SessionId",
                table: "Toetsen",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toetsen_Sessions_SessionId",
                table: "Toetsen",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vervoegingen_Toetsen_ToetsId",
                table: "Vervoegingen",
                column: "ToetsId",
                principalTable: "Toetsen",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toetsen_Sessions_SessionId",
                table: "Toetsen");

            migrationBuilder.DropForeignKey(
                name: "FK_Vervoegingen_Toetsen_ToetsId",
                table: "Vervoegingen");

            migrationBuilder.DropIndex(
                name: "IX_Vervoegingen_ToetsId",
                table: "Vervoegingen");

            migrationBuilder.DropIndex(
                name: "IX_Toetsen_SessionId",
                table: "Toetsen");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Toetsen");

            migrationBuilder.AlterColumn<int>(
                name: "ToetsId",
                table: "Vervoegingen",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToetsEFId",
                table: "Vervoegingen",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Toetsen",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SessionEFId",
                table: "Toetsen",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vervoegingen_ToetsEFId",
                table: "Vervoegingen",
                column: "ToetsEFId");

            migrationBuilder.CreateIndex(
                name: "IX_Toetsen_SessionEFId",
                table: "Toetsen",
                column: "SessionEFId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toetsen_Sessions_SessionEFId",
                table: "Toetsen",
                column: "SessionEFId",
                principalTable: "Sessions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vervoegingen_Toetsen_ToetsEFId",
                table: "Vervoegingen",
                column: "ToetsEFId",
                principalTable: "Toetsen",
                principalColumn: "Id");
        }
    }
}
