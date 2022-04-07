using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K_O_Project.Migrations
{
    public partial class Initt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "123", "burak" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
