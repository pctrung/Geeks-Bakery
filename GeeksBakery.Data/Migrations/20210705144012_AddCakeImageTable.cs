using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class AddCakeImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Cakes");

            migrationBuilder.CreateTable(
                name: "CakeImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CakeId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakeImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CakeImages_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "063fd6a1-78f1-4c13-8453-66a287e3561e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "77ee34d2-e8bf-4e38-8055-0b59ca4e8281");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce7a84aa-03d9-4fac-a7eb-790f70960f12", "AQAAAAEAACcQAAAAENGFpGukVtca+n5GX6wOOR93cP2OtdtQQQvg3UaWgysKShoaqv5ru9wBz7AB+Cj/Pg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92c3a48c-49ae-4976-b755-0d0daac7d082", "AQAAAAEAACcQAAAAEHtslppEfsreCKZJnAIxRKUPqS9yEwspc+Pq4nQwMm7xTAgtFMhb3IN1s4GYOVUsbg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d0067e3-f093-430c-9d05-489d43563eef", "AQAAAAEAACcQAAAAEJB+cbAg6bgPNap7g/FOKu2bIyNy/ulFykqec1AXlya7cxzzpEdmk54zNwJSCarUMg==" });

            migrationBuilder.CreateIndex(
                name: "IX_CakeImages_CakeId",
                table: "CakeImages",
                column: "CakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CakeImages");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 0, 13, 2, 92, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Cakes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 5, 0, 13, 2, 82, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "default-cake.png");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 22, 13, 41, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 22, 15, 23, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 23, 12, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 12, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "f91a8bb5-90a3-4ce7-8b38-c2be508fb859");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "978aa1c3-1f2b-41f7-a703-2497e87fd381");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "433e7efe-5d87-416c-bd07-269301ea7fbe", "AQAAAAEAACcQAAAAEMqeOAOtXQfe9ETfSdXWX1Lf1KK8vG5ANWzqffVt/TVFUvkomeKVWVUeVJVTKV850A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c862301-0420-4fdf-9557-83da4f2e8b30", "AQAAAAEAACcQAAAAELKfONU/3Adg4GGc9Rwp0BMFYl3YeG3aOeRgwcBHCrkY1PaRqJzfLt/fDPEI4NjGrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91ea369d-f62f-4bd3-b0a8-0975dcfdaa42", "AQAAAAEAACcQAAAAEJFveFitO2XgQ8lb27vIv8UrHO8g4XlDHM8qOeAcRZrZToZmzP3dUXQ2D/mW/KIiYw==" });
        }
    }
}
