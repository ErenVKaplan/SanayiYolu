using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "36ab3ca1-2c41-461f-aecc-51990db89882");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "afa88e0e-681a-4889-a6cb-60e885324b07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "2d609a0f-a7f9-46fc-8e85-33fa6da04e76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebc18300-b900-4fba-a34c-1f90b748597b", "AQAAAAIAAYagAAAAEGFl90IahGHc4NB98kSjlPni2Di8ZfdqhTwuIWYLAMdPAd/KM27IdSVOjbSX8/DNvw==", "b2af4f65-bc51-49ea-87ae-26746a1c29cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e9023a9-ff8d-4ef4-b640-be7d723b4b0b", "AQAAAAIAAYagAAAAEIW8sX2oKv1RrWmtfAodncIofJpyEGmsaS2P5SlQBXZpbtxDMdIxfHp5mjDpTLhtBw==", "a0e8e562-d977-44a9-8b0f-c319a0b8de44" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
