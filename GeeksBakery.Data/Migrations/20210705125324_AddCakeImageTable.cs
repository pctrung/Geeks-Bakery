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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "256bcbfa-47e3-423d-94f4-8e42b9c2fd90");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7972345a-8823-41fc-aab1-35450c41b14f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35cac859-f5f9-46fe-8fb2-06295ee87cb2", "AQAAAAEAACcQAAAAEGqJBwhd8AfBuQ1JtOKjd8uGnT8RZMo7EQwhMpwXKMOS9qVyry+gjqA6W0GAalJN/g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85d7bc04-cc23-46fd-9731-4e02c3c9d169", "AQAAAAEAACcQAAAAECpkM4rIPPWcKkE7fuGpri0u0v5BZJf6FmEQN6lX2kOIwWlqRFCyP1BytiOssp7AKA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b46d6535-a0a0-4bda-ac31-13c3f5fb7011", "AQAAAAEAACcQAAAAEGZXFZK0jf2uQCrecRFdpTGFc/+jIvmrRU/h071zzkEE4V1Y93eg5+IB1CmiF3X9+A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
