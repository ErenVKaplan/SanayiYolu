using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "c3958510-67e0-41f1-ae62-b23121f85201");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "dcb880e3-8f51-47f2-ad62-d9e37a78152b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "4a260552-98f3-4a13-a5d9-846338d22971");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24ea3d27-c78c-4674-8beb-0aa17b02c040", "AQAAAAIAAYagAAAAEO0frE1PRh5hCA+L/uv4P8lm+n0SVI/xW5vGrXkIoQKxli3TJyB26Lajv38NdX2Nkg==", "add82308-2ad5-4b2d-8968-3b6e236bba8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7116ab2-6ffb-49b3-a1a2-3d2c214895ea", "AQAAAAIAAYagAAAAEEQmPTOaU7U2SAyrdUM0/cADClpENyq922CFharH5fxWg5BEz+6wJRyDESwUhGL0fg==", "cf36839c-465b-484c-ad7a-520cb7e285f2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "7f02960d-651c-4c20-a01b-ff0cfe2c8226");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "9d7e604c-a493-4f78-a3d5-e8287dcf5ff8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "e17f552f-da6c-4a0b-94eb-70f2d0307066");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "065f0064-01a4-47fb-b3c6-c43d2aa692a1", "AQAAAAIAAYagAAAAENb7ix24smoUhxuWBfIOXGyaqcGk6SS2fMk4EsIJ/pWZt5CWKHV4r+WWAzZvr8AaVg==", "8b9c3006-d537-4ece-8379-74053c163de0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f74162d2-5813-422b-be18-2456c6ce8599", "AQAAAAIAAYagAAAAEEiCtd7vcUGwJ19r77USeSnTNhgdT3NNcgXxUvKXJjboKmKmsAo81kApdQF/g6hjGw==", "1b6a4250-8969-4af3-9522-7d87265b96e9" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("7348efa8-8646-4561-9f6a-8aa7f673b96b"), "Admin", new DateTime(2023, 10, 11, 23, 45, 10, 388, DateTimeKind.Local).AddTicks(4553), null, null, false, null, null, "Python" },
                    { new Guid("8505d0dd-ac44-4243-8a08-f14bf2c3b7aa"), "Admin", new DateTime(2023, 10, 11, 23, 45, 10, 388, DateTimeKind.Local).AddTicks(4556), null, null, false, null, null, "ASP.NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("40fc14eb-7c40-48e5-bd6b-1d960b960d94"), new Guid("7348efa8-8646-4561-9f6a-8aa7f673b96b"), "Bu Makalenin Açıklama Metni Buradadır.", "Admin", new DateTime(2023, 10, 11, 23, 45, 10, 388, DateTimeKind.Local).AddTicks(3458), null, null, false, null, null, "Python Makalesi 2", new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"), 15 },
                    { new Guid("54749cfe-8586-4454-b65b-6e93dd0f2f33"), new Guid("8505d0dd-ac44-4243-8a08-f14bf2c3b7aa"), "Bu Makalenin Açıklama Metni Buradadır.", "Admin", new DateTime(2023, 10, 11, 23, 45, 10, 388, DateTimeKind.Local).AddTicks(3452), null, null, false, null, null, ".NET Core Makalesi 1", new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"), 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");
        }
    }
}
