using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GeeksBakery.Data.Migrations
{
    public partial class EditNameFilePathToFileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "CakeImages",
                newName: "FileName");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "18145669-3ab6-4bf4-9a0c-f430bfc29095");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8b7068cc-6a0d-4340-ac32-1ee9b73d91a6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9662acc4-1c57-47ae-a8ac-ef3696296359", "AQAAAAEAACcQAAAAEPOexrHBCtJtIuojLvwWnopAlMhjQ/eIdiXawdWcPIUwaHh+TblFfCS686l6EYHtog==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5708f88-7dc2-4261-b10f-cf6762a20eac", "AQAAAAEAACcQAAAAEAtkR2o3z/ZV1P/8BpRuMOiRV8FYTvRz5FEXfWEvWL/JUfJpjV87vhSWyHwiKPtYkA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "361f62ef-0ca8-4bc2-aea1-3e962c6adaea", "AQAAAAEAACcQAAAAEI6sAp229ACtqjHxK+vunyqapgYtuhTZTVvfTCbhMhUIZocGIrbbSoeEsz155xux2g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "CakeImages",
                newName: "ImagePath");

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
    }
}