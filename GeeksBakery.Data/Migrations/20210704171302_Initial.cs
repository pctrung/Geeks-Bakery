using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "default-cake.png"),
                    SEOAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 5, 0, 13, 2, 82, DateTimeKind.Local).AddTicks(7927))
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
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 7, 5, 0, 13, 2, 92, DateTimeKind.Local).AddTicks(5706))
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
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "978aa1c3-1f2b-41f7-a703-2497e87fd381", "Administrator role", "admin", "admin" },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "f91a8bb5-90a3-4ce7-8b38-c2be508fb859", "Customer role", "customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, null, "433e7efe-5d87-416c-bd07-269301ea7fbe", new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "trung@gmail.com", true, false, null, "Pham Chi Trung", "trung@gmail.com", "admin", "AQAAAAEAACcQAAAAEMqeOAOtXQfe9ETfSdXWX1Lf1KK8vG5ANWzqffVt/TVFUvkomeKVWVUeVJVTKV850A==", null, false, "", false, "admin" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, null, "91ea369d-f62f-4bd3-b0a8-0975dcfdaa42", new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@gmail.com", true, false, null, "Pham Chi Trung Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAEJFveFitO2XgQ8lb27vIv8UrHO8g4XlDHM8qOeAcRZrZToZmzP3dUXQ2D/mW/KIiYw==", null, false, "", false, "customer 1" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, null, "5c862301-0420-4fdf-9557-83da4f2e8b30", new DateTime(1996, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAELKfONU/3Adg4GGc9Rwp0BMFYl3YeG3aOeRgwcBHCrkY1PaRqJzfLt/fDPEI4NjGrg==", null, false, "", false, "customer 2" }
                });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "DateDeleted", "DateModified", "Description", "Name", "OriginalPrice", "Price", "SEOAlias", "Size", "Stock" },
                values: new object[,]
                {
                    { 5, 1, null, null, "Gato, kem bơ vị rượu rum, socola.", "Dark chocolate cake", 150000m, 150000m, null, 20, null },
                    { 6, 1, null, null, "Gato, kem bơ vị rượu rum, socola bào trắng, dừa sấy.", "White chocolate and coconut cake", 300000m, 300000m, null, 19, null },
                    { 7, 2, null, null, "Gato, kem, có phụ kiện trên mặt bánh", "Car dollar cake", 290000m, 290000m, null, 21, null },
                    { 8, 2, null, null, "Gato, kem vị trà xanh.", "Green tea four love", 170000m, 170000m, null, 20, null },
                    { 1, 3, null, null, "Blueberry, Kem cheese, Kem tươi.", "Blue bery mousse", 300000m, 300000m, null, 19, null },
                    { 2, 3, null, null, "Caramel, Socola", "Caramel mousse", 250000m, 250000m, null, 21, null },
                    { 3, 3, null, null, "Cherry, Kem cheese ,Kem tươi.", "Cherry cheese mousse", 150000m, 150000m, null, 20, null },
                    { 4, 3, null, null, "Kem tươi, Socola,Trà xanh.", "Red chocolate mousse", 200000m, 200000m, null, 19, null },
                    { 9, 4, null, null, "Gato, kem tươi vị coffee", "Tiramisu", 160000m, 160000m, null, 21, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateModified", "DeliveryDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, new DateTime(2021, 5, 22, 13, 41, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2021, 5, 22, 10, 50, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 3, new DateTime(2021, 5, 22, 15, 23, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2021, 5, 23, 9, 34, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 5, new DateTime(2021, 5, 24, 12, 11, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, new DateTime(2021, 5, 23, 12, 11, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2021, 5, 23, 16, 23, 0, 0, DateTimeKind.Unspecified), 4, new Guid("bff91054-dc92-421e-a233-d1080f630928") },
                    { 6, new DateTime(2021, 5, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("bff91054-dc92-421e-a233-d1080f630928") }
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
