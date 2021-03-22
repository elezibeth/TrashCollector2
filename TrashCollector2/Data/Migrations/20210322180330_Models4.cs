using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class Models4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    AddressNumber = table.Column<int>(nullable: false),
                    StreetName = table.Column<string>(nullable: false),
                    StreetType = table.Column<string>(nullable: false),
                    UnitNumber = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    SuspendServiceStartDate = table.Column<DateTime>(nullable: false),
                    SuspendServiceEndDate = table.Column<DateTime>(nullable: false),
                    AmountOwed = table.Column<double>(nullable: false),
                    PaymentAmountDisplay = table.Column<double>(nullable: false),
                    DayOfWeekForTrashPickup = table.Column<int>(nullable: false),
                    OneTimePickupRequest = table.Column<DateTime>(nullable: false),
                    LastPickupDate = table.Column<DateTime>(nullable: false),
                    LastPickupCharge = table.Column<double>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZipCode = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EmployeeIdentifierName = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf770341-7c07-4088-b267-937cc912cd29", "de50c546-dbfc-408b-90bc-65bb3172fe49", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "600367dd-c7c9-4449-9823-a4795fea26eb", "7ac81524-d221-4306-8832-93261544f636", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fec7325-fa4e-4e87-a567-beb27bf82020", "8f5d7e6f-f76f-4a4c-93eb-74ac010d82c2", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fec7325-fa4e-4e87-a567-beb27bf82020");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "600367dd-c7c9-4449-9823-a4795fea26eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf770341-7c07-4088-b267-937cc912cd29");

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
    }
}
