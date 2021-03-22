using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class Models3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "55f11540-c393-4fa0-9a3a-7bc18372b30e", "2d2f1962-4dc8-4669-87db-aa9716be6d73", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c8c2ae7-87f1-43c1-97c9-9ef78435bc7b", "27335682-7b6e-4706-93c9-454d50cf6fa0", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da117688-400b-45de-ae8e-98fcc94b62b2", "b6567538-7cb7-4b31-ac96-d3d1a6b3bd71", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55f11540-c393-4fa0-9a3a-7bc18372b30e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c8c2ae7-87f1-43c1-97c9-9ef78435bc7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da117688-400b-45de-ae8e-98fcc94b62b2");

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
    }
}
