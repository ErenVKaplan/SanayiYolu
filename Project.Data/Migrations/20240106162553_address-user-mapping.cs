using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class addressusermapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Addresses_AddressId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_AddressId",
                table: "Stores");

            migrationBuilder.AddColumn<Guid>(
                name: "StoreId",
                table: "Addresses",
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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StoreId",
                table: "Addresses",
                column: "StoreId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Stores_StoreId",
                table: "Addresses",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Stores_StoreId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_StoreId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "2d3fda02-569d-4905-80cd-a48c1c1fe8b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "3c881527-36eb-41f4-b15c-cd747870b8f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3733b194-d12e-4f3d-b1b3-30811da21f20"),
                column: "ConcurrencyStamp",
                value: "43b6a859-2412-4311-9b99-e56fc07b40b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "9f11f25f-1aff-4a57-a817-d702d9a61cb1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ada1f1b-1ba4-440c-85f8-dc6b4bb56a2b", "AQAAAAIAAYagAAAAELoyN49LM+5XjkzK50FOt7K+fXZhjFVI3yUX56by3eM0ke4pQjRosr0PIIiDlc1ApQ==", "e75897c1-1d6d-40e1-9792-77fb50a7c92f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8979544a-03fc-40f3-ae4c-f471f4a15eb6", "AQAAAAIAAYagAAAAEBPdpoSnzrcTz7V6pCo/Dtc0RcsgvmQzwecmFpsHYOiButt8/G2cgPTUSsoL7q8OUA==", "a90b8ba3-8f87-4f10-a3a3-66f7d09b7930" });

            migrationBuilder.CreateIndex(
                name: "IX_Stores_AddressId",
                table: "Stores",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Addresses_AddressId",
                table: "Stores",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
