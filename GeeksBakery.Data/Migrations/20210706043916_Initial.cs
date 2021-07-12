using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GeeksBakery.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "default-avatar.png"),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    SEOAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cakes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CakeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.CakeId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Carts_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CakeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.CakeId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91054-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Bread", null },
                    { 2, "Mousse", null },
                    { 3, "Cookies", null },
                    { 4, "Donuts", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "1e0044b1-177a-4887-b420-1d2612650cb1", "Administrator role", "admin", "admin" },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "6ffe1469-6e31-4fa6-93c4-570fbe40f3e4", "Customer role", "customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, null, "45baddd5-768c-418e-929d-6ee3c0c056a1", new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "trung@gmail.com", true, false, null, "Pham Chi Trung", "trung@gmail.com", "admin", "AQAAAAEAACcQAAAAECNBhHCEX7z6GMuZ74YwJ0dv9KwDAn44rVZgAxXvvIScae3WPM8l0mlCEiB9YlsJ5g==", null, false, "", false, "admin" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, null, "d48b193e-a622-4c07-89de-5b1d4a982b59", new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@gmail.com", true, false, null, "Pham Chi Trung Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAEIy9PXWX2Enhv8m6lmm6HVnq1RkQ932i8Jl8UwD3V8Ejk2xrq98Iq7X37M5F6uViCw==", null, false, "", false, "customer 1" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, null, "6aa5e3b1-bb94-4b74-8ce7-c84b22b6a805", new DateTime(1996, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAEJ2WKOT4natBGglCWDPkv2ezDtY9w8z34I85kZV9ziDe6g5aH7XJUwm0rDB8MvmZDw==", null, false, "", false, "customer 2" }
                });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "DateDeleted", "DateModified", "Description", "Name", "OriginalPrice", "Price", "SEOAlias", "Size", "Stock" },
                values: new object[,]
                {
                    { 5, 1, null, null, "Gato, kem bơ vị rượu rum, socola.", "Dark chocolate cake", 150000m, 150000m, null, 20, 0 },
                    { 6, 1, null, null, "Gato, kem bơ vị rượu rum, socola bào trắng, dừa sấy.", "White chocolate and coconut cake", 300000m, 300000m, null, 19, 0 },
                    { 7, 2, null, null, "Gato, kem, có phụ kiện trên mặt bánh", "Car dollar cake", 290000m, 290000m, null, 21, 0 },
                    { 8, 2, null, null, "Gato, kem vị trà xanh.", "Green tea four love", 170000m, 170000m, null, 20, 0 },
                    { 1, 3, null, null, "Blueberry, Kem cheese, Kem tươi.", "Blue bery mousse", 300000m, 300000m, null, 19, 0 },
                    { 2, 3, null, null, "Caramel, Socola", "Caramel mousse", 250000m, 250000m, null, 21, 0 },
                    { 3, 3, null, null, "Cherry, Kem cheese ,Kem tươi.", "Cherry cheese mousse", 150000m, 150000m, null, 20, 0 },
                    { 4, 3, null, null, "Kem tươi, Socola,Trà xanh.", "Red chocolate mousse", 200000m, 200000m, null, 19, 0 },
                    { 9, 4, null, null, "Gato, kem tươi vị coffee", "Tiramisu", 160000m, 160000m, null, 21, 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateDeleted", "DateModified", "DeliveryDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, null, null, new DateTime(2021, 5, 22, 10, 50, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 3, null, null, new DateTime(2021, 5, 23, 9, 34, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, null, null, new DateTime(2021, 5, 23, 16, 23, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91054-dc92-421e-a233-d1080f630928") },
                    { 6, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bff91054-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "CakeId", "OrderId", "Amount" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 1, 3, 2 },
                    { 1, 4, 1 },
                    { 2, 2, 1 },
                    { 2, 5, 1 },
                    { 3, 3, 1 },
                    { 3, 5, 1 },
                    { 4, 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CakeImages_CakeId",
                table: "CakeImages",
                column: "CakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cakes_CategoryId",
                table: "Cakes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CakeId",
                table: "OrderDetails",
                column: "CakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "CakeImages");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Cakes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}