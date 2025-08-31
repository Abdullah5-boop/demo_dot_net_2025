using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace demoApp0818.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a926cd9-ced1-4c9c-be02-ae0bf50db476");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "312076bc-d7b8-4ee9-a31d-209a3faea542");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af53252c-ff51-43c7-a953-6e844adbdee1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a026253-d7b2-4be5-b8a4-44b7d7bee7b9", "1", "Admin", "Admin" },
                    { "77fbb75f-b48b-4c4f-a72f-e2d71751a05f", "2", "User", "User" },
                    { "8c0a743a-f961-40d3-90af-603d0e4d3b3a", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a026253-d7b2-4be5-b8a4-44b7d7bee7b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77fbb75f-b48b-4c4f-a72f-e2d71751a05f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c0a743a-f961-40d3-90af-603d0e4d3b3a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a926cd9-ced1-4c9c-be02-ae0bf50db476", "1", "Admin", "Admin" },
                    { "312076bc-d7b8-4ee9-a31d-209a3faea542", "2", "User", "User" },
                    { "af53252c-ff51-43c7-a953-6e844adbdee1", "3", "HR", "HR" }
                });
        }
    }
}
