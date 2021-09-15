using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GeeksBakery.Data.Migrations
{
    public partial class addEntityConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SEOAlias",
                table: "Cakes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryDate",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Cakes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cakes",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Cakes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "CakeImages",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "CakeImages",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "CakeImages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "CakeImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeliveryDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeliveryDate",
                value: null);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Cakes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Cakes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "SEOAlias",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "CakeImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "CakeImages",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "CakeImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "CakeImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeliveryDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeliveryDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}