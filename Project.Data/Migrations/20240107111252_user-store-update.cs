using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class userstoreupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "StoreDescription",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "OpeningTime",
                table: "Stores",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ClosingTime",
                table: "Stores",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<int>(
                name: "CrewSize",
                table: "Stores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnAir",
                table: "Stores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StoreSlogan",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "18f632cf-d2bb-4aa8-8267-03d86fd45c48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "8f0b553f-bc81-42d5-a1ca-7cf5cac3097d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3733b194-d12e-4f3d-b1b3-30811da21f20"),
                column: "ConcurrencyStamp",
                value: "9ceadadb-3249-4fac-9f1c-efe8cc34b870");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "c094893f-6f26-44af-935a-07300af888e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b41ccc6f-dd05-4b02-b978-caaf7c85f4ef", "AQAAAAIAAYagAAAAEArF52GCQ11KYcLuElOWg2lTCYE2lmazZwQhF6PIovAf/uu2viR+ZgBMSBKicjXJsw==", "ab295e87-ad08-4d29-a004-ae5b17317792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff921a2f-9132-4b66-a9b5-ffc784f742be", "AQAAAAIAAYagAAAAEJ2XO1Pb6O+TYW+jCGwqcdW9av0mqp5J5KRDmISNVpEVSSJbBTztOffJN3IoH2+bOQ==", "bc8d8eaf-d4bd-4a94-97cb-d4dd1aa5d3db" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrewSize",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "OnAir",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "StoreSlogan",
                table: "Stores");

            migrationBuilder.AlterColumn<string>(
                name: "StoreDescription",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "OpeningTime",
                table: "Stores",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ClosingTime",
                table: "Stores",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StoreId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "c8b05d87-72ea-41d6-afe4-b66ef5ec10aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "22255f08-d5ae-4a69-bcd2-c2280566b3c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3733b194-d12e-4f3d-b1b3-30811da21f20"),
                column: "ConcurrencyStamp",
                value: "59c5cabb-137c-4901-aa82-f0bf2bcc3ed8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "4fc22ac6-07af-4815-b303-039ffc086a1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StoreId" },
                values: new object[] { "af0c9cd0-c184-41cf-b0aa-7fbf59c822e3", "AQAAAAIAAYagAAAAEFpuKs9kSuRi75q9QIhI/oINc7nLVobKYFTNZlkSlnHMSG6YOheOZqRyyqkeASjWhw==", "8d79e724-9528-4041-b909-16a2bf03af5e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StoreId" },
                values: new object[] { "b84ca8ae-66b9-4d1e-8239-ea47c3318872", "AQAAAAIAAYagAAAAEMyUIc700Z5a/7GFrtMSvD0WccGy5fm2hJulGfaYaAaYRma39XrwNyNEO+OyEqy5wA==", "b971951a-bce9-41ef-a6b5-2667e8fda730", null });
        }
    }
}
