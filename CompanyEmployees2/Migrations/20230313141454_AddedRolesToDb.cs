using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees2.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "697710de-101f-4844-aa9e-d8916f003807", "0edcabc0-e181-4caf-adc9-e827c1982faa", "Administrator", "ADMINISTRATOR" },
                    { "e8a01337-4fe5-40eb-a9d4-ee8bd475e32d", "7b6a2152-7b85-4156-94e5-6d7cf23aa72d", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "697710de-101f-4844-aa9e-d8916f003807");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8a01337-4fe5-40eb-a9d4-ee8bd475e32d");
        }
    }
}
