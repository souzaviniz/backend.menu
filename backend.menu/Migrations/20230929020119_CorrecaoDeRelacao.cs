using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.menu.Migrations
{
    public partial class CorrecaoDeRelacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pratos_Categorias_IdPrato",
                table: "Pratos");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrato",
                table: "Pratos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Pratos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pratos_IdCategoria",
                table: "Pratos",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Pratos_Categorias_IdCategoria",
                table: "Pratos",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pratos_Categorias_IdCategoria",
                table: "Pratos");

            migrationBuilder.DropIndex(
                name: "IX_Pratos_IdCategoria",
                table: "Pratos");

            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "Pratos");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrato",
                table: "Pratos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Pratos_Categorias_IdPrato",
                table: "Pratos",
                column: "IdPrato",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
