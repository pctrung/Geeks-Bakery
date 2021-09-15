using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class AddDateCreatedIntoReviewEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Reviews");

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
        }
    }
}
