using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPhotoHostL.Services.Migrations
{
    public partial class @finally : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Publication",
                table: "Publications");

            migrationBuilder.RenameTable(
                name: "Publication",
                newName: "Publication");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publication",
                table: "Publication",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Publication",
                table: "Publication");

            migrationBuilder.RenameTable(
                name: "Publication",
                newName: "Publication");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publication",
                table: "Publication",
                column: "Id");
        }
    }
}
