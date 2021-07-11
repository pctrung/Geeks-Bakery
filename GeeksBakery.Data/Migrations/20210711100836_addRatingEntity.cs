using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GeeksBakery.Data.Migrations
{
    public partial class addRatingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CakeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => new { x.UserId, x.CakeId });
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
                value: new DateTime(2021, 7, 11, 17, 8, 35, 406, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 17, 8, 35, 407, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "7752c827-e9e1-4eee-bef2-bdfa5a4fb35d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "96a7af9b-c7e4-4f97-a2f5-3389f6a2d814");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9f5e759-8416-4957-bd8d-6ea65b502f34", "AQAAAAEAACcQAAAAEMMZh4afpErDUnxNqQcl59Uo4pgJTpBabOLYGlhKMDTkM48KCYH6NWP2SIuSESv1oA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3add2b9-efad-4d0a-937e-6c2c06aeb484", "AQAAAAEAACcQAAAAEHk7txMdJuKv0hq+YSDQ9ZIBy8k+mIFfKP46FM2c+JmdD8WYHHLh3Oztm2bzq1wOxg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e4fcf92-840b-47ad-b4ed-a0b01bcec654", "AQAAAAEAACcQAAAAEAXITaQYd2rKWO78+GgE1OAfcQkq/VYiakDarypJVDcs3qouaA/J71Oth+tOgnelow==" });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_CakeId",
                table: "Rates",
                column: "CakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 39, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 11, 16, 59, 21, 40, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "3204a52e-7255-4d16-b803-226bb4edf788");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "99e11e42-3d1d-4758-a206-82876c4a60cd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0dc5610e-e007-4e70-b01a-d46e039bf53b", "AQAAAAEAACcQAAAAEGRhXxxJlyoNWKby2leZXL3Nyz9nxcCZdjeHjsNAl7AYMVvObat3zimr04/6z1udLA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1eefd838-92d6-4388-8cda-6817e8377219", "AQAAAAEAACcQAAAAEDEuF3H619SlUMatVfl+0l8pyfUYDTzjTG8cpeLePqdXktW7BSCmLWZnCoOn7caf9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41c39126-1f7a-4456-a2fd-00a40d70f93e", "AQAAAAEAACcQAAAAEGmpNLDNzThqBCd7fxZJkVhVSqC0DFRTMhWGQv8B6hTH8A+aRoWeKASBvCIf3BG1Yw==" });
        }
    }
}