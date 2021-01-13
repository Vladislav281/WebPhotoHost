using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPhotoHostL.Services.Migrations
{
    public partial class InitializeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Publication");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Publication",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Publication");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Publication",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
