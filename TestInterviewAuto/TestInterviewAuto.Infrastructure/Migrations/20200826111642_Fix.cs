using Microsoft.EntityFrameworkCore.Migrations;

namespace TestInterviewAuto.Infrastructure.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hex",
                table: "Colors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Colors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hex",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Colors");
        }
    }
}
