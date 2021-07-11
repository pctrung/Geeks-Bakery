using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class renameRateToReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CakeId = table.Column<int>(type: "int", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 153, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 22, 2, 11, 155, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CakeId", "Comment", "DateDeleted", "DateModified", "Star", "UserId" },
                values: new object[,]
                {
                    { 10, 9, "Hương vị thật ngon", null, null, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 9, 8, "Màu sắc đẹp", null, null, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 8, 7, "Đây là comment", null, null, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 7, 3, "Yeah", null, null, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, 3, "Delicious", null, null, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 5, 6, "Ngon đó", null, null, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, 2, "Bánh không ngon", null, null, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 3, 2, "Bánh dở", null, null, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, 1, "Bánh hơi ngon", null, null, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 1, 1, "Bánh ngon", null, null, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "e18eaf9e-694b-4b36-8581-e796ddd565e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "94b6ac5f-8ffa-4a68-81c8-168be9d163a2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dc04347-64ba-46b0-a35e-4512d9eee075", "AQAAAAEAACcQAAAAEActFEGD13NNCvU7ffbtOC32RjGfVkA9RxLjwBA6MLSOeQ0q1s9TfhMJ1JbWzT/RUg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a80d5ffa-309b-4f16-b3f6-e57d8c05d1a4", "AQAAAAEAACcQAAAAENlWGzNX9iNYeCdjKLqTvW9N7jkOGnbXcLfmEh3oBK5hR3vSfMyOVXwFo+yIb9lGKA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51c4dcf7-2500-4a03-9585-8494555d3589", "AQAAAAEAACcQAAAAEOMOB5BzlWc3hZ841vP9rFr2OWLVh7ZD2nhtKrvVtwpmkTAyhSuspAugJ39R9CnvyQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CakeId",
                table: "Reviews",
                column: "CakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CakeId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Star = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rates_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 551, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 20, 46, 33, 552, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "Id", "CakeId", "Comment", "DateDeleted", "DateModified", "Star", "UserId" },
                values: new object[,]
                {
                    { 10, 9, "Hương vị thật ngon", null, null, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 9, 8, "Màu sắc đẹp", null, null, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 8, 7, "Đây là comment", null, null, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 7, 3, "Yeah", null, null, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, 3, "Delicious", null, null, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 5, 6, "Ngon đó", null, null, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, 2, "Bánh không ngon", null, null, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 3, 2, "Bánh dở", null, null, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, 1, "Bánh hơi ngon", null, null, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 1, 1, "Bánh ngon", null, null, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "d86e09e4-6b0d-42f6-ab95-e4e354214a6b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8399fe23-ef27-4b8d-a0f9-52c6bb795191");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ca611fe-7d36-4d19-9b5c-fbc578eb29c1", "AQAAAAEAACcQAAAAEPhuVHgYyXLaw5EA4N5ugmxnta/t8+B25dTtnYVupNIgJCp0SK4YJrszggEeOhOnMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcaa66c4-ee43-452b-81eb-d41f1bab672e", "AQAAAAEAACcQAAAAEBaZR7k29SR/l/l3zREMaR1hZM7F3gOqQwhMA5T0oNU0RFrCS9AIq7NsjxS9zet6gA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "582ae877-e9d7-450b-8b36-8653d2d659d1", "AQAAAAEAACcQAAAAEIkcAeaJzu8Xyz4avq8l3OxP4W/l+nzVUtWDqDP2NLQTIYATFJzjWua3pEBsgbwdqQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_CakeId",
                table: "Rates",
                column: "CakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_UserId",
                table: "Rates",
                column: "UserId");
        }
    }
}
