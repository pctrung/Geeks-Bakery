using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class EditPriceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cakes",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "Cakes",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 648, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 650, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 13, 19, 4, 46, 834, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "fff5485d-6642-4716-a22e-1b48f5e87f39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5ee545fe-e6c3-4422-9e40-1e3eaa923e11");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "228d016a-8f26-4a49-8fb7-4cf4b3068b71", "AQAAAAEAACcQAAAAEFSTfiMQFnDd9NGlfWnXHX0L7111b0HpP13K2KTtKAxEP/op30NuG1UF9FIyBpVi7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c819877c-ec33-4110-8412-9ba5547c325d", "AQAAAAEAACcQAAAAEFqVRJajfvVTO7CgTQiww96HYTe62IvCgLwDCR2w+GE0XswW3uIocA6eza/hSsB8iQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ad51bae-7fd5-4d0a-991d-209c892432d9", "AQAAAAEAACcQAAAAEKE1O1IJ3N1eH9FZA4J7HNy21Iee0Oo0WOvcbSQXF2a4pAIkp/8GAunIj3F1xEDNKg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cakes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "Cakes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 682, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 684, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 12, 22, 28, 3, 804, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "f9ad9a8b-5a6b-427c-a289-14fb7923a16f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3cd05e52-a246-4690-9c42-a0bfe569e195");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e89a66e-34f0-446d-8920-61853e99461d", "AQAAAAEAACcQAAAAEPvuHLUp6aS1ZwHUIjf1jZG5kx2U6bJOPGSQqDyd3oZGksD9q8tP5ZecpZCbJvIQQw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "959605f6-c776-4f5f-978b-afc200b26db2", "AQAAAAEAACcQAAAAENrl05szPxtjFZzHbDfzAEyPR4kskI8/Jr0MCUt6HvfnMT6Lnp1vrO2V1LNvom2P4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82d1e458-fdda-44c6-bc38-e24974886b07", "AQAAAAEAACcQAAAAEDROmDkiMW1qYrQMs6Xft5euYYLG3SHzd/OkA8JQSrcjJd5o1hh91Qq7oq2USOViWw==" });
        }
    }
}
