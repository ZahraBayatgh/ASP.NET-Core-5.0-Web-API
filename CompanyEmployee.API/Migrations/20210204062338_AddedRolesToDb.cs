using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployee.API.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c81c47b3-088e-4940-ab94-e0297e7a84fb", "0d9a1a18-fb30-49ec-846f-fdb04f41c89a", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d9e45fd-50e5-4016-860a-5d15e605b527", "0ec324a1-dba2-4786-a9b6-38285b4a9b4c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d9e45fd-50e5-4016-860a-5d15e605b527");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c81c47b3-088e-4940-ab94-e0297e7a84fb");
        }
    }
}
