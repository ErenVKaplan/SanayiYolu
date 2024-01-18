using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class stores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Stores");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af0c9cd0-c184-41cf-b0aa-7fbf59c822e3", "AQAAAAIAAYagAAAAEFpuKs9kSuRi75q9QIhI/oINc7nLVobKYFTNZlkSlnHMSG6YOheOZqRyyqkeASjWhw==", "8d79e724-9528-4041-b909-16a2bf03af5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84ca8ae-66b9-4d1e-8239-ea47c3318872", "AQAAAAIAAYagAAAAEMyUIc700Z5a/7GFrtMSvD0WccGy5fm2hJulGfaYaAaYRma39XrwNyNEO+OyEqy5wA==", "b971951a-bce9-41ef-a6b5-2667e8fda730" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Stores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "0b940fd6-1672-4995-bc3a-f5aaf4bf6cf6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "dbb9808c-bd51-4ab5-b4cf-2c682314bbed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3733b194-d12e-4f3d-b1b3-30811da21f20"),
                column: "ConcurrencyStamp",
                value: "f39338d2-bd19-4974-8d6d-7b444b97987a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "d274a781-ffef-468b-8473-c15a0fdcd78b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef84fcd7-0b8a-4175-98bd-1a7048983925", "AQAAAAIAAYagAAAAEK09qLvvF27mL+uCLFlGBi2luuFuQTurFLbWJbNHlZR53w/6vaN60gZ/XeQ7Gqetvg==", "a0a38054-555a-49b0-b1bb-fea51bc44fd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cec642c-de73-48ed-a1cb-2f40dbbffbd0", "AQAAAAIAAYagAAAAEKm6lOhx6Gy/x2+PkQ2tuLduNmWPdB/Uthk99sYScE5OOBc1jE0NeHSIN0SwKX3+eQ==", "57f4a4e4-afd0-4345-8273-8a2c97e296a9" });
        }
    }
}
