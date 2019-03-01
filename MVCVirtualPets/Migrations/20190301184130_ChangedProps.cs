using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCVirtualPets.Migrations
{
    public partial class ChangedProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pets",
                newName: "PetId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                column: "Description",
                value: "Doofus is doofy");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                column: "Description",
                value: "Graile is holy");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                column: "Description",
                value: "My boy blue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "Pets",
                newName: "Id");
        }
    }
}
