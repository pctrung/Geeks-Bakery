using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GeeksBakery.Data.Migrations
{
    public partial class editCategoryType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "be6a9e02-6768-4c95-9fa4-be03ceb7e45a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cd6a8b69-2588-4daa-9dfd-4ba4ac3a9172");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c56ca71c-21db-4875-beff-54fc6dd59095", "AQAAAAEAACcQAAAAEO33dqVj9hp73ixCxhx8W7P+ox/E/z/jmKNn4mimRwc4YrJZTpXs1T5fbejQOwjTmQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77c2da27-5ed5-4741-8f42-835390de4da3", "AQAAAAEAACcQAAAAEBPpjtHshP72bA/cFkSxPqPL5PXowY0r7lisDlXxw93YYFuMENmpfyh0wZcsE1fPjA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96bb88be-ce05-45e9-86c7-fa130d177777", "AQAAAAEAACcQAAAAENe0U2rGYxtp6Kek/zosUoDPjKzVckvIjuY/dC/9VdHQx2Oy0LZGaET+uohxjFc3cg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
