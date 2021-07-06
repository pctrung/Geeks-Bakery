using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class edittype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "10e251c2-3c67-4ad7-a5cd-6bbee2ab3496");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b634202b-6f53-4759-8f5b-93fdf8035ff1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddaefde3-e604-49a3-b39a-94ac40d3120a", "AQAAAAEAACcQAAAAEDdYaJ/rKeE+S126y/OGuAwWgf3HNmYJZjRso//rXzebe+sXQqbAMx5v/yvBoTqprA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3eeb188-5df9-404b-8ee9-0bece168eaa0", "AQAAAAEAACcQAAAAED9i9goN4oNfYUZWNr39Fu8WgPgK7PJq43HHPZh62XE43NMu26C56leRMxXTNVXlHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e8a13cd-d7f0-4996-87a2-9417b05660c7", "AQAAAAEAACcQAAAAEFplZgvixzNbD5lnnZ25uezCv/FX91+6SDcvofNhOm9PfLBb+jwxYHJbkaCFK6A7/w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "6ffe1469-6e31-4fa6-93c4-570fbe40f3e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1e0044b1-177a-4887-b420-1d2612650cb1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45baddd5-768c-418e-929d-6ee3c0c056a1", "AQAAAAEAACcQAAAAECNBhHCEX7z6GMuZ74YwJ0dv9KwDAn44rVZgAxXvvIScae3WPM8l0mlCEiB9YlsJ5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6aa5e3b1-bb94-4b74-8ce7-c84b22b6a805", "AQAAAAEAACcQAAAAEJ2WKOT4natBGglCWDPkv2ezDtY9w8z34I85kZV9ziDe6g5aH7XJUwm0rDB8MvmZDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d48b193e-a622-4c07-89de-5b1d4a982b59", "AQAAAAEAACcQAAAAEIy9PXWX2Enhv8m6lmm6HVnq1RkQ932i8Jl8UwD3V8Ejk2xrq98Iq7X37M5F6uViCw==" });
        }
    }
}
