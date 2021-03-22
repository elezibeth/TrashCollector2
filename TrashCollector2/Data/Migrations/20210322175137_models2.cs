using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class models2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f0b7dc5-7f1e-4757-aa2d-65cfe3f3d76c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0e6c743-159a-4b7b-b6bc-b5d045323b7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6457945-0770-4495-8c9c-9cee78f57a5b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6c1ab0e-8ef3-4c60-b45e-e2f148a3e24c", "b724251a-1804-42e0-998b-9ecb79b7e8c0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e315b120-a264-4894-880d-fdd45919b05e", "f76eb53a-1442-490f-bdbd-bee385b222d3", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4666309-15f6-42ad-b06a-c19e70eeb07f", "5c04b229-502a-4a99-b8da-160c9d9635d1", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4666309-15f6-42ad-b06a-c19e70eeb07f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6c1ab0e-8ef3-4c60-b45e-e2f148a3e24c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e315b120-a264-4894-880d-fdd45919b05e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6457945-0770-4495-8c9c-9cee78f57a5b", "499a764a-373c-404a-bb8b-c21b7f083877", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f0b7dc5-7f1e-4757-aa2d-65cfe3f3d76c", "23f0a189-f8d9-4fd9-b336-e08689e862ae", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0e6c743-159a-4b7b-b6bc-b5d045323b7f", "9e22875d-9d95-4b31-bc51-fb988036c639", "Customer", "CUSTOMER" });
        }
    }
}
