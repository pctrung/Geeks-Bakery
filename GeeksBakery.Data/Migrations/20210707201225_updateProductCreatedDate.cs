using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class updateProductCreatedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Cakes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 457, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 8, 3, 12, 24, 459, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "17c8004b-e9b2-4480-bcbd-23d44fdc9907");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b2f7903a-b649-4854-897a-b74ae5c21613");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29bbfd10-546f-4f7e-b774-251cfd9c9a8f", "AQAAAAEAACcQAAAAENUheXGskMt9vItnwxmbFPTDNK5tU2W71RIF/JNZapvdxgBLnKfX7xLLnCECawSC3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d36fd17-063f-48e9-8308-52a3601de07b", "AQAAAAEAACcQAAAAEP34WT55OI3V04fb0OelAcW1QfUaz/YqKNYJbWLf4kXN0P1Yvd0y01U/O+uTPJFLeg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "470f4772-9eae-4b27-af10-1a37e6de2060", "AQAAAAEAACcQAAAAEMtcwPLuZO4owdUA9L6/07EszqMxUbFuvZat0jip+N3I17XXh4sqxLQn+J1JL3Fdjw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Cakes");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "2d2ec228-d1e6-4c3f-bdf3-ebe626e83def");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6aebb6fb-3354-49d7-b8f0-ec06ca837aba");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "163f6ebd-40a4-4ee6-985b-7cf030a5f5ee", "AQAAAAEAACcQAAAAEL1sGkIA1YTiSUa8yGa1Yd03A/iCnvQYutFBdhF35UyHEYrHsQqOPGg/WiRU3IckgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cb3d5b7-8fb4-47ac-abb7-c496c0e7d468", "AQAAAAEAACcQAAAAENjCZnRMNgae9m0SMuhcTh2qIEpOy2unOVJifeiTOhvxWXhbPUS+PFCkjNWuV2k5Iw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eaa6e77-46a6-45ce-8d95-841d59cbad93", "AQAAAAEAACcQAAAAEAqyGu6z+fGfoZlFsgmmI97nmFx1iLUPgmNwln0al+uYVbUSuUZPnVvSxRnR2yZkmA==" });
        }
    }
}
