using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class addressEntitiesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "ClosingTime",
                table: "Stores",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "OpeningTime",
                table: "Stores",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "StoreComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "9f11f25f-1aff-4a57-a817-d702d9a61cb1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("3733b194-d12e-4f3d-b1b3-30811da21f20"), "43b6a859-2412-4311-9b99-e56fc07b40b8", "Store", "STORE" });

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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CountryName", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "TR", "Türkiye", "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityCode", "CityName", "CountryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("000da6cd-6cf6-4ac8-8ba6-3987a365d6d6"), "20", "DENİZLİ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("00ad0fe7-69b5-44d9-a9b7-55be3abb5c1d"), "24", "ERZİNCAN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("076b7bd6-14bc-4fb0-a267-b54250050b15"), "75", "ARDAHAN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("08e7f6c4-945b-4df7-a665-add2e7a4a618"), "60", "TOKAT", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("0a989240-4ad1-4b86-848b-c9f1c1f05e5e"), "77", "YALOVA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("0b39dfca-59b8-4f31-86d3-4ae9ca4f2b9b"), "39", "KIRKLARELİ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("119f19bd-9bcc-43e8-b79b-298d2512b8c8"), "06", "ANKARA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("14e32643-0447-4f96-b063-988b3907af7d"), "13", "BİTLİS", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("19886235-a21e-451c-b5c7-9dd156d10cb6"), "49", "MUŞ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("207c8a7a-9bbd-49fa-8b6c-024e422e85be"), "30", "HAKKARİ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("2181e33c-af94-4462-9b9e-8ea81d9ae65f"), "26", "ESKİŞEHİR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("24dbcfcc-f0f6-47c7-8126-2bd503f0795a"), "79", "KİLİS", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("28315c53-3efe-4fa5-b770-b67ae030d801"), "73", "ŞIRNAK", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("2861d7aa-7771-42fa-b25e-04c32114e36d"), "07", "ANTALYA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("2d1d94df-4a1a-425b-ab96-6cadb1740c56"), "38", "KAYSERİ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("3468b7e2-31e2-4db4-bdf6-ef7236f5278e"), "63", "ŞANLIURFA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("38a110da-dbfc-44df-bae3-8112a1bb1afe"), "58", "SİVAS", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("3a0e5300-4339-4367-8179-05a161e61d46"), "28", "GİRESUN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("43d3f152-6faf-451c-b2c2-0c0a2c6b0844"), "27", "GAZİANTEP", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("4445d161-57da-4678-848e-545d22bf49b7"), "68", "AKSARAY", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("4492dccd-aa16-4368-9b8a-7b4a9de724f4"), "47", "MARDİN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("4883900e-8c4f-4973-9462-37ee7161c581"), "65", "VAN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("4a2fdffc-026d-48d0-86e8-5a8f29f91288"), "57", "SİNOP", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("4cf278e0-83b7-42d4-b372-c1205488f89b"), "46", "KAHRAMANMARAŞ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("4f28cb7d-f2d7-4ff1-a240-2cc59b011e61"), "12", "BİNGÖL", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("560ff615-1edc-4e27-b15f-1a19dcf30dc1"), "59", "TEKİRDAĞ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("58c9ebdf-12ee-41ca-a48d-db1af2bf5fae"), "55", "SAMSUN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("58fc1bdc-f107-4974-948a-c71752d91233"), "16", "BURSA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("5b778b1a-8d0b-421e-8f5b-2d7fc20a154d"), "54", "SAKARYA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("5c4841e1-45c7-4412-bcd8-5c1c9075d534"), "23", "ELAZIĞ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("60e48429-8d51-4ffc-9397-9331b8d4d0fa"), "80", "OSMANİYE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("62ccccf2-0c45-4cb0-8d83-73d378960d43"), "78", "KARABÜK", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("63085967-e8cb-4c07-aef3-593023d1c4a7"), "19", "ÇORUM", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("6aad2e1b-f444-40b5-bd37-69f701f4dc4c"), "09", "AYDIN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("6c666dcd-0922-4b06-a77c-0c319b8d6d9d"), "18", "ÇANKIRI", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("70ec3cbf-76e3-4309-a13b-59a6bf4fe9a5"), "08", "ARTVİN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("73761197-85fc-48b0-8caf-a3848c81331d"), "25", "ERZURUM", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("73a7dbe0-967b-4afb-8549-31a5048aa4a1"), "17", "ÇANAKKALE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "01", "ADANA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("76ae7192-2b2b-44ac-bd2b-6defd9557d1d"), "35", "İZMİR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("7c4768e3-feb2-4ba2-990b-bf28cc62c1e8"), "45", "MANİSA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("7f8fcbf4-9998-4696-b369-01122d3777bc"), "44", "MALATYA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("81744f52-0934-484e-ae12-1d393b7bc854"), "21", "DİYARBAKIR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("83d8f9f0-6881-4fd0-b357-1479a773e420"), "69", "BAYBURT", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("843cb178-724c-4356-b722-0aec3d3e3719"), "40", "KIRŞEHİR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("852ae3fa-ed4b-4966-bc7c-3d81373f8826"), "41", "KOCAELİ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("8670c127-a7be-4dae-a841-3e75d018c300"), "70", "KARAMAN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("879925d2-c58f-49db-ba0d-682217e75b84"), "62", "TUNCELİ", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("87f6b3c9-e7ea-452a-93b2-85af25db1cb1"), "33", "İÇEL", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("8b2f5d1f-9e23-48e2-bb8e-8ad30f0aca8f"), "71", "KIRIKKALE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("8f2ae84e-eb94-4494-939b-d3114e397e54"), "04", "AĞRI", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("90758c2e-1707-40e7-813f-bbc056f41e46"), "22", "EDİRNE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("90b18e75-8150-4d7e-badb-40c3b98448bb"), "05", "AMASYA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("91e1a2e4-9933-490e-9367-e72eb178544f"), "15", "BURDUR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("9661652c-5eee-4437-8c61-898683990f32"), "64", "UŞAK", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("97553ab3-5570-4c21-86e2-54e2c7ed8c7d"), "67", "ZONGULDAK", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("9d5c729b-c36e-4a84-9601-80905ad21c7a"), "51", "NİĞDE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("a6783483-6c0c-4345-8482-f064756fd5e7"), "72", "BATMAN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("a98b32f6-ed0e-4b47-b7b6-d83e183046f8"), "31", "HATAY", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("ac4e3529-393b-4284-a96e-442eef95d2a1"), "48", "MUĞLA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("ae800eac-ec3f-4e99-a86c-fc2328630293"), "74", "BARTIN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("b1c2f1e9-795e-46c0-becb-aee29b9d99db"), "52", "ORDU", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("bc58e55f-e0ce-4ed1-ab96-3c9abccc8055"), "56", "SİİRT", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("bdcfac30-a93b-4577-9fe5-71821abb6446"), "32", "ISPARTA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("bf65cd65-b63d-4f90-96d6-21f060daf156"), "76", "IĞDIR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("c3f47f5f-b620-4d48-a077-c1b84b270bae"), "50", "NEVŞEHİR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("cd98d7b2-a710-4536-9b62-d74f7fb054d0"), "61", "TRABZON", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "02", "ADIYAMAN", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("d31e6f41-babc-433c-b094-bf134168f453"), "37", "KASTAMONU", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("d401961f-0146-497d-b0f7-9412c25073d4"), "03", "AFYON", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("d698d997-f0b0-4994-bd84-6a18d142f878"), "66", "YOZGAT", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("d76ed0d1-f072-42e9-899b-384501da5b25"), "36", "KARS", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("d91084e0-a6cf-40ae-86ba-14ba6a44c0fb"), "29", "GÜMÜŞHANE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("db4e9dfe-b804-4f8c-b389-e1eef2f18ca1"), "10", "BALIKESİR", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("db637ede-2b00-4ed7-b7a9-8449cbe3a78c"), "53", "RİZE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("e045d15d-a4d2-460a-8fab-6cdb782d11f5"), "81", "DÜZCE", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("e8dcb038-b7e7-484f-9454-58dcf35f8725"), "14", "BOLU", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("e985dae1-25b1-482a-9cde-3a737447a305"), "34", "İSTANBUL", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("ebf47fcc-1959-4efd-82e6-b89e383d71a1"), "43", "KÜTAHYA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("f16beb91-4df1-4e2e-a8a2-37272de1e438"), "11", "BİLECİK", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null },
                    { new Guid("f499428c-bdd2-47f8-9e4a-87590b660103"), "42", "KONYA", new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "DistrictCode", "DistrictName", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0e0063c2-0621-41b7-9206-0348cc2f552d"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "ÇUKUROVA", false, null, null },
                    { new Guid("0f63c895-215d-4efe-b121-55fb832c9df3"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "KAHTA", false, null, null },
                    { new Guid("11ec0101-d748-481f-9da1-1de154209694"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "SEYHAN", false, null, null },
                    { new Guid("2083a543-f6df-4c6f-8d01-864f9424d465"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "GÖLBAŞI", false, null, null },
                    { new Guid("35c1305d-1443-48c2-b772-179985746711"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "SARIÇAM", false, null, null },
                    { new Guid("4833927c-be8c-4533-8001-f8f5fac28889"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "YÜREĞİR", false, null, null },
                    { new Guid("4876bb81-5125-49bc-9070-fa10f3376bf4"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MERKEZ", false, null, null },
                    { new Guid("5095eaeb-5b51-4d2b-aea8-33355bf0b42f"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "SAMSAT", false, null, null },
                    { new Guid("512809fd-7b48-4a50-a7b7-9de728f2e5e6"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "ALADAĞ", false, null, null },
                    { new Guid("5a57ca40-f365-4130-aaab-baee0e0c282a"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "KOZAN", false, null, null },
                    { new Guid("613e812d-5604-4b13-bb86-72f21fef94ae"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "TUFANBEYLİ", false, null, null },
                    { new Guid("6d38973e-425f-4525-bc8f-ffcb2dfe3fb2"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "KARAİSALI", false, null, null },
                    { new Guid("7a295a66-d91f-4a60-ba71-95262641dd4d"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "YUMURTALIK", false, null, null },
                    { new Guid("81bd3fd6-9baf-46d2-a264-c811431a6976"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "BESNİ", false, null, null },
                    { new Guid("98798a7d-6f73-497e-8e8c-9ae9da5d7fae"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "SAİMBEYLİ", false, null, null },
                    { new Guid("9a0fdb95-f2df-4853-93cb-8d72793f555d"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "CEYHAN", false, null, null },
                    { new Guid("a0170e47-e380-4ab1-a0cf-bffb821a1951"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "İMAMOĞLU", false, null, null },
                    { new Guid("afeea71e-d61d-46ce-b794-d24a3e336840"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "POZANTI", false, null, null },
                    { new Guid("b0f22411-44f9-46d1-89a8-4a7b89430857"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "KARATAŞ", false, null, null },
                    { new Guid("b8d91d22-4fc3-4017-ba4e-af2db2e2e59b"), new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "FEKE", false, null, null },
                    { new Guid("d3dd068c-1a08-40e2-bf0b-e2196c19025e"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "TUT", false, null, null },
                    { new Guid("d74ad0d8-ca87-4f8d-8a82-b159ee2ee72f"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "GERGER", false, null, null },
                    { new Guid("eb33397d-ff11-4965-9d91-05f455b6fd19"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "ÇELİKHAN", false, null, null },
                    { new Guid("f581c226-f011-4b1b-8cbb-46ec224a2f1c"), new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"), "SYSTEM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "SİNCİK", false, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3733b194-d12e-4f3d-b1b3-30811da21f20"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("000da6cd-6cf6-4ac8-8ba6-3987a365d6d6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00ad0fe7-69b5-44d9-a9b7-55be3abb5c1d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("076b7bd6-14bc-4fb0-a267-b54250050b15"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("08e7f6c4-945b-4df7-a665-add2e7a4a618"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0a989240-4ad1-4b86-848b-c9f1c1f05e5e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0b39dfca-59b8-4f31-86d3-4ae9ca4f2b9b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("119f19bd-9bcc-43e8-b79b-298d2512b8c8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("14e32643-0447-4f96-b063-988b3907af7d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("19886235-a21e-451c-b5c7-9dd156d10cb6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("207c8a7a-9bbd-49fa-8b6c-024e422e85be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2181e33c-af94-4462-9b9e-8ea81d9ae65f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("24dbcfcc-f0f6-47c7-8126-2bd503f0795a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("28315c53-3efe-4fa5-b770-b67ae030d801"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2861d7aa-7771-42fa-b25e-04c32114e36d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2d1d94df-4a1a-425b-ab96-6cadb1740c56"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3468b7e2-31e2-4db4-bdf6-ef7236f5278e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("38a110da-dbfc-44df-bae3-8112a1bb1afe"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3a0e5300-4339-4367-8179-05a161e61d46"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("43d3f152-6faf-451c-b2c2-0c0a2c6b0844"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4445d161-57da-4678-848e-545d22bf49b7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4492dccd-aa16-4368-9b8a-7b4a9de724f4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4883900e-8c4f-4973-9462-37ee7161c581"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4a2fdffc-026d-48d0-86e8-5a8f29f91288"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4cf278e0-83b7-42d4-b372-c1205488f89b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4f28cb7d-f2d7-4ff1-a240-2cc59b011e61"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("560ff615-1edc-4e27-b15f-1a19dcf30dc1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("58c9ebdf-12ee-41ca-a48d-db1af2bf5fae"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("58fc1bdc-f107-4974-948a-c71752d91233"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5b778b1a-8d0b-421e-8f5b-2d7fc20a154d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c4841e1-45c7-4412-bcd8-5c1c9075d534"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("60e48429-8d51-4ffc-9397-9331b8d4d0fa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("62ccccf2-0c45-4cb0-8d83-73d378960d43"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("63085967-e8cb-4c07-aef3-593023d1c4a7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6aad2e1b-f444-40b5-bd37-69f701f4dc4c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6c666dcd-0922-4b06-a77c-0c319b8d6d9d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("70ec3cbf-76e3-4309-a13b-59a6bf4fe9a5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("73761197-85fc-48b0-8caf-a3848c81331d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("73a7dbe0-967b-4afb-8549-31a5048aa4a1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("76ae7192-2b2b-44ac-bd2b-6defd9557d1d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7c4768e3-feb2-4ba2-990b-bf28cc62c1e8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7f8fcbf4-9998-4696-b369-01122d3777bc"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("81744f52-0934-484e-ae12-1d393b7bc854"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("83d8f9f0-6881-4fd0-b357-1479a773e420"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("843cb178-724c-4356-b722-0aec3d3e3719"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("852ae3fa-ed4b-4966-bc7c-3d81373f8826"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8670c127-a7be-4dae-a841-3e75d018c300"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("879925d2-c58f-49db-ba0d-682217e75b84"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("87f6b3c9-e7ea-452a-93b2-85af25db1cb1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b2f5d1f-9e23-48e2-bb8e-8ad30f0aca8f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8f2ae84e-eb94-4494-939b-d3114e397e54"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("90758c2e-1707-40e7-813f-bbc056f41e46"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("90b18e75-8150-4d7e-badb-40c3b98448bb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("91e1a2e4-9933-490e-9367-e72eb178544f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9661652c-5eee-4437-8c61-898683990f32"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("97553ab3-5570-4c21-86e2-54e2c7ed8c7d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9d5c729b-c36e-4a84-9601-80905ad21c7a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a6783483-6c0c-4345-8482-f064756fd5e7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a98b32f6-ed0e-4b47-b7b6-d83e183046f8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ac4e3529-393b-4284-a96e-442eef95d2a1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ae800eac-ec3f-4e99-a86c-fc2328630293"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b1c2f1e9-795e-46c0-becb-aee29b9d99db"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bc58e55f-e0ce-4ed1-ab96-3c9abccc8055"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bdcfac30-a93b-4577-9fe5-71821abb6446"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bf65cd65-b63d-4f90-96d6-21f060daf156"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c3f47f5f-b620-4d48-a077-c1b84b270bae"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cd98d7b2-a710-4536-9b62-d74f7fb054d0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d31e6f41-babc-433c-b094-bf134168f453"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d401961f-0146-497d-b0f7-9412c25073d4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d698d997-f0b0-4994-bd84-6a18d142f878"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d76ed0d1-f072-42e9-899b-384501da5b25"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d91084e0-a6cf-40ae-86ba-14ba6a44c0fb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("db4e9dfe-b804-4f8c-b389-e1eef2f18ca1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("db637ede-2b00-4ed7-b7a9-8449cbe3a78c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e045d15d-a4d2-460a-8fab-6cdb782d11f5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e8dcb038-b7e7-484f-9454-58dcf35f8725"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e985dae1-25b1-482a-9cde-3a737447a305"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ebf47fcc-1959-4efd-82e6-b89e383d71a1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f16beb91-4df1-4e2e-a8a2-37272de1e438"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f499428c-bdd2-47f8-9e4a-87590b660103"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("0e0063c2-0621-41b7-9206-0348cc2f552d"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("0f63c895-215d-4efe-b121-55fb832c9df3"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("11ec0101-d748-481f-9da1-1de154209694"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("2083a543-f6df-4c6f-8d01-864f9424d465"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("35c1305d-1443-48c2-b772-179985746711"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("4833927c-be8c-4533-8001-f8f5fac28889"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("4876bb81-5125-49bc-9070-fa10f3376bf4"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("5095eaeb-5b51-4d2b-aea8-33355bf0b42f"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("512809fd-7b48-4a50-a7b7-9de728f2e5e6"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("5a57ca40-f365-4130-aaab-baee0e0c282a"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("613e812d-5604-4b13-bb86-72f21fef94ae"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("6d38973e-425f-4525-bc8f-ffcb2dfe3fb2"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("7a295a66-d91f-4a60-ba71-95262641dd4d"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("81bd3fd6-9baf-46d2-a264-c811431a6976"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("98798a7d-6f73-497e-8e8c-9ae9da5d7fae"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("9a0fdb95-f2df-4853-93cb-8d72793f555d"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("a0170e47-e380-4ab1-a0cf-bffb821a1951"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("afeea71e-d61d-46ce-b794-d24a3e336840"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("b0f22411-44f9-46d1-89a8-4a7b89430857"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("b8d91d22-4fc3-4017-ba4e-af2db2e2e59b"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("d3dd068c-1a08-40e2-bf0b-e2196c19025e"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("d74ad0d8-ca87-4f8d-8a82-b159ee2ee72f"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("eb33397d-ff11-4965-9d91-05f455b6fd19"));

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: new Guid("f581c226-f011-4b1b-8cbb-46ec224a2f1c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("743531d8-793e-42fb-8ff0-b6bb128370c9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d2aff33b-0e7f-4032-8759-317fcc628775"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6506be3d-63b1-4707-8e20-1f01a2a63d86"));

            migrationBuilder.DropColumn(
                name: "ClosingTime",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "OpeningTime",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "StoreComments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17faf120-51a9-4917-bd6a-e43d60b2e910"),
                column: "ConcurrencyStamp",
                value: "04aead6b-83da-4224-9b6e-f3f132bada35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30144a78-fa5f-45d8-9dbc-eb595667add7"),
                column: "ConcurrencyStamp",
                value: "5222123a-bd8c-4953-bb7e-7f49bb9799e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("70d5392a-4f59-41c5-9dd0-1e026005f59c"),
                column: "ConcurrencyStamp",
                value: "3606b249-8c10-43e9-8312-8b60f945b3c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19b1856d-44a9-401b-b188-563b8b48ee21"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17442a89-c900-4a6b-ad70-31f26403543a", "AQAAAAIAAYagAAAAEGXwyuDtL9yhZ28MMlQEJR19kTPWxPxkAjSb2qNlb3dwKhAy6G1IIT9rjt+onWvdbw==", "27b0d6a0-dba4-471e-a163-5c1ff5f18a1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("361936ea-8c5d-410e-8a5a-7f3f5c302d87"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1333cd33-8b6f-41e4-89f0-eeeb9b5d5701", "AQAAAAIAAYagAAAAEEjSRS5FObQuz4kMDF3VvLv5ivb/KWjxYfdIVfRjJNPcNU2Wk7lj4lGU7pOHIw3bxw==", "cf38cd80-5e9d-43f4-aef3-6d88d07d4adb" });
        }
    }
}
