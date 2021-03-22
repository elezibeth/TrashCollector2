using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class ModelsOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2383860a-3746-4149-929d-9d10f6d9fb93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98f35a28-fc94-476d-bc5f-eaa6c1ad98c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd795d69-08a1-463d-8f46-a883828470ee");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2383860a-3746-4149-929d-9d10f6d9fb93", "fa61ca10-614c-46bd-ae47-4d3f91e8a4bf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd795d69-08a1-463d-8f46-a883828470ee", "19db875a-b9b0-4aa8-bc92-c6ebf0dfc303", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98f35a28-fc94-476d-bc5f-eaa6c1ad98c1", "01583025-8aa3-461c-901b-194a7382f2f4", "Customer", "CUSTOMER" });
        }
    }
}
