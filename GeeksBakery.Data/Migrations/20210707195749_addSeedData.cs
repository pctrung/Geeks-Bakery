using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CakeImages",
                columns: new[] { "Id", "CakeId", "Caption", "DateCreated", "FileName", "FileSize", "IsDefault", "SortOrder" },
                values: new object[,]
                {
                    { 25, 7, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7.1.jpg", 0L, true, 1 },
                    { 18, 5, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.2.jpg", 0L, true, 1 },
                    { 19, 5, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.3.jpg", 0L, true, 1 },
                    { 20, 5, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.4.jpg", 0L, true, 1 },
                    { 21, 6, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6.1.jpg", 0L, true, 1 },
                    { 22, 6, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6.2.jpg", 0L, true, 1 },
                    { 23, 6, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6.3.jpg", 0L, true, 1 },
                    { 24, 6, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6.4.jpg", 0L, true, 1 },
                    { 26, 7, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7.2.jpg", 0L, true, 1 },
                    { 27, 8, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.1.jpg", 0L, true, 1 },
                    { 28, 8, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.2.jpg", 0L, true, 1 },
                    { 29, 8, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.3.jpg", 0L, true, 1 },
                    { 30, 8, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.4.jpg", 0L, true, 1 },
                    { 31, 9, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9.1.jpg", 0L, true, 1 },
                    { 32, 9, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9.2.jpg", 0L, true, 1 },
                    { 33, 9, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9.3.jpg", 0L, true, 1 },
                    { 17, 5, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.1.jpg", 0L, true, 1 },
                    { 15, 4, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4.3.jfif", 0L, true, 1 },
                    { 16, 4, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4.4.jfif", 0L, true, 1 },
                    { 13, 4, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4.1.jfif", 0L, true, 1 },
                    { 1, 1, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.1.jpg", 0L, true, 1 },
                    { 12, 3, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.4.jpg", 0L, true, 1 },
                    { 11, 3, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.3.jpg", 0L, true, 1 },
                    { 10, 3, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.2.jpg", 0L, true, 1 },
                    { 9, 3, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.1.jpg", 0L, true, 1 },
                    { 8, 2, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2.4.jpg", 0L, true, 1 },
                    { 7, 2, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2.3.jpg", 0L, true, 1 },
                    { 6, 2, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2.2.jpg", 0L, true, 1 },
                    { 5, 2, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2.1.jpg", 0L, true, 1 },
                    { 14, 4, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4.2.jfif", 0L, true, 1 },
                    { 4, 1, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.4.jpg", 0L, true, 1 },
                    { 3, 1, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.3.jpg", 0L, true, 1 },
                    { 2, 1, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.2.jpg", 0L, true, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 4, "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.", "Blackforest Cake With Cherries", 200000m, 150000m, 20, 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "Size", "Stock" },
                values: new object[] { 1, "Award yourself with this rich chocolate cake wonderfully crammed with Cadbury Fuse and white chocolate chunks and draped lusciously with molten chocolate.This perfect work of art hides in every bite, the scrumptious flavours of heavily whipped chocolate cream and nutty bits of chocolate that is a little nutty and a lot of tasty! ", "Snicker Fuse Chocolate Cake", 200000m, 20, 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Stock" },
                values: new object[] { 2, "An exceptionally creamy Open - layered Red Velvet cake with a topping that tastes like a MASH UP between the tropical fruits is truly a luxurious treat.Experience the richness and smoothness in this delicacy which is laden with kiwis, cherries,apples, dragon fruits and black grapes.Who said healthy and delicious are poles apart ?", "Red Velvet Fruit Layer Cake", 260000m, 180000m, 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 1, "This round chocolaty cake is the perfect treat for someone who is absolutely in love with chocolate cakes.This cake covered in rich chocolate ganache and decorated with chocolate shavings is the best gift one can have on their special day. ", "Chocolaty Creamy Round Cake", 310000m, 290000m, 20, 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { "A toothsome treat for the sugar lovers who are just passionate about chocolate and relish the mushiness of cake.Made of two layers of impossibly moist chocolate filled with mushy rich cream, this cake carries the enticing aroma of Vanilla and sumptuousness of chocolate.On top of it, the cake is garnished with handcrafted white and brown chocolate.Need I say more ? ", "Half Chocolate Half Vanilla Cake", 170000m, 150000m, 20, 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 1, "This heart-shaped cake is nicely decorated with pink vanilla flavoured glazing and edible gems of vibrant colours like yellow, gold, red, blue, and white. The bonus of Cadbury chocolates and more gems comes when the hearty vanilla cake’s sweet crust is smashed.Note = Hammer will be given with the cake. ", "Hearty Choco Gems Pinata Cake", 250000m, 200000m, 20, 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Stock" },
                values: new object[] { 1, "The heavenly taste of this Choco Truffle Cake will even leave the hardest-to - please chocolate addicts tranquil in every sense. Prepared with three layers of relishing chocolate cream filled in between the soft stacks of chocolate cake, and adorned with beautiful chocolate icing and rich glaze chocolate coating, this one is just irresistible. ", "Round Chocolate Truffle Cake", 430000m, 350000m, 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 2, "End the wait, break the ball with this black forest pinata cake, the true taste of surprise and luxury.It is a ball - shaped cake with a ball made of chocolate and a hammer that helps you break it loose. Next, what you see inside is a delicious black forest cake with icing, frosting and sponge, all chocolaty and mouth savouring.Make it your choice for all coming occasions.Note = Hammer will be given with the cake. ", "Birthday Black Forest Pinata Cake", 200000m, 150000m, 20, 1 });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "DateDeleted", "DateModified", "Description", "Name", "OriginalPrice", "Price", "SEOAlias", "Size", "Stock" },
                values: new object[] { 11, 1, null, null, "The two celebratory flavours in a single cake--red velvet cake layers entirely covered in dark chocolate cream roses sprinkled with red velvet crumbs.A slice of the cake won't be enough to celebrate the fusion of flavours; you would need a whole cake. ", "Heavenly Red Velvet Chocolate Cake", 400000m, 350000m, null, 20, 1 });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "DateDeleted", "DateModified", "Description", "Name", "OriginalPrice", "Price", "SEOAlias", "Size", "Stock" },
                values: new object[,]
                {
                    { 12, 2, null, null, "This cake is meant for all celebratory occasions! This three layered delicious pineapple flavoured cake filled with intensely whipped rich cream and pineapple fillings, perfectly defines simplicity at its best.Topped with pineapple slices, chocolate flakes and a further adorned with cherries, this cake is the perfect blend of sweetness and fluffiness. ", "Pineapple Cream Cake", 230000m, 150000m, null, 20, 1 },
                    { 14, 2, null, null, "Freshly baked Vanilla cake, Whipped cream and bountiful tropical fruits come together to create a treat that is even tastier than it looks.This combination of whipped cream and fresh fruit is a perfect start for any celebration and an enticing end to any meal. ", "Assorted Fruit and Almond Cake", 310000m, 260000m, null, 20, 1 },
                    { 15, 3, null, null, "Another winning treat in your list of favorite items, a delicious Red Velvet cake with vanilla cream and icing, bedded red velvet ruling like a crown along with fragrant bread, the richest baked good.Greedy much, do remember to share the delicious deity with your loved ones and send some across to those you direly miss. ", "Red Velvet Buttercream Creamy Cake", 280000m, 260000m, null, 20, 1 },
                    { 16, 2, null, null, "Both a joy to your sight as well as your taste buds, this pineapple flavoured scrumptious cake is a delight that you must indulge in every celebration!Frosted with pastel shades of buttercream, drizzling white chocolate ganache, and dollops of pink whipped cream on top, this delicious cake is loaded with copious amounts of gems in the center that spills out when you cut a slice! ", "Pineapple Gems Pinata Cake", 250000m, 150000m, null, 20, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Chocolate");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fruits");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Exotic");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Backforest");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 8, "Strawberry", null },
                    { 6, "Vanilla", null },
                    { 7, "Coffee", null },
                    { 5, "Butterscotch", null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "2d2ec228-d1e6-4c3f-bdf3-ebe626e83def");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6aebb6fb-3354-49d7-b8f0-ec06ca837aba");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "163f6ebd-40a4-4ee6-985b-7cf030a5f5ee", "AQAAAAEAACcQAAAAEL1sGkIA1YTiSUa8yGa1Yd03A/iCnvQYutFBdhF35UyHEYrHsQqOPGg/WiRU3IckgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "4cb3d5b7-8fb4-47ac-abb7-c496c0e7d468", "AQAAAAEAACcQAAAAENjCZnRMNgae9m0SMuhcTh2qIEpOy2unOVJifeiTOhvxWXhbPUS+PFCkjNWuV2k5Iw==", "customer2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "3eaa6e77-46a6-45ce-8d95-841d59cbad93", "AQAAAAEAACcQAAAAEAqyGu6z+fGfoZlFsgmmI97nmFx1iLUPgmNwln0al+uYVbUSuUZPnVvSxRnR2yZkmA==", "customer1" });

            migrationBuilder.InsertData(
                table: "CakeImages",
                columns: new[] { "Id", "CakeId", "Caption", "DateCreated", "FileName", "FileSize", "IsDefault", "SortOrder" },
                values: new object[,]
                {
                    { 37, 11, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "11.1.jfif", 0L, true, 1 },
                    { 54, 16, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.3.jpg", 0L, true, 1 },
                    { 53, 16, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.2.jpg", 0L, true, 1 },
                    { 52, 16, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.1.jpg", 0L, true, 1 },
                    { 51, 15, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15.3.jpg", 0L, true, 1 },
                    { 50, 15, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15.2.jpg", 0L, true, 1 },
                    { 49, 15, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15.1.jpg", 0L, true, 1 },
                    { 47, 14, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14.2.jpg", 0L, true, 1 },
                    { 48, 14, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14.3.jpg", 0L, true, 1 },
                    { 43, 12, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12.4.jpg", 0L, true, 1 },
                    { 42, 12, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12.3.jpg", 0L, true, 1 },
                    { 41, 12, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12.2.jpg", 0L, true, 1 },
                    { 40, 12, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12.1.jpg", 0L, true, 1 },
                    { 39, 11, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "11.3.jpg", 0L, true, 1 },
                    { 38, 11, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "11.2.jfif", 0L, true, 1 },
                    { 46, 14, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14.1.jpg", 0L, true, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Stock" },
                values: new object[] { 6, "Any celebration is incomplete without this funfetti cake. Pipped with beautiful creamy decorations, this towering beauty is a grandiose deliciousness is sure to sweep everyone off their feet.And not just this, along with this beautify their day with extra sweetness and some extra colors with each bite topped with sumptuous confetti. ", "Rainbow Sprinkles Cake", 400000m, 350000m, 1 });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "DateDeleted", "DateModified", "Description", "Name", "OriginalPrice", "Price", "SEOAlias", "Size", "Stock" },
                values: new object[,]
                {
                    { 10, 5, null, null, "Always and Forever Delight!This three layered moist and smooth cake filled with butterscotch chips and Vanilla cream is something not to be missed! Topped with Butterscotch glaze and brown chocolate flakes, adorned with scrumptious caramel dressing on the sides, it's time to feel the crunch! ", "Round Shape Butterscotch Cake", 370000m, 290000m, null, 20, 1 },
                    { 13, 8, null, null, "The deliciousness of red velvet has been baked into the shape of a heart that resembles your sheer love and affection for your sweetheart. Tender, moist, and fluffy in texture, this captivating red velvet cake is a perfect sweet to cast the spell of love. ", "Heart Shape Red Velvet Cake", 200000m, 180000m, null, 20, 1 }
                });

            migrationBuilder.InsertData(
                table: "CakeImages",
                columns: new[] { "Id", "CakeId", "Caption", "DateCreated", "FileName", "FileSize", "IsDefault", "SortOrder" },
                values: new object[,]
                {
                    { 34, 10, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10.1.jpg", 0L, true, 1 },
                    { 35, 10, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10.2.jpg", 0L, true, 1 },
                    { 36, 10, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10.3.jpg", 0L, true, 1 },
                    { 44, 13, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13.1.jpg", 0L, true, 1 },
                    { 45, 13, "Cake Images", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "13.2.jpg", 0L, true, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CakeImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 3, "Blueberry, Kem cheese, Kem tươi.", "Blue bery mousse", 300000m, 300000m, 19, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "Size", "Stock" },
                values: new object[] { 3, "Caramel, Socola", "Caramel mousse", 250000m, 21, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Stock" },
                values: new object[] { 3, "Cherry, Kem cheese ,Kem tươi.", "Cherry cheese mousse", 150000m, 150000m, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 3, "Kem tươi, Socola,Trà xanh.", "Red chocolate mousse", 200000m, 200000m, 19, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Stock" },
                values: new object[] { 1, "Gato, kem bơ vị rượu rum, socola.", "Dark chocolate cake", 150000m, 150000m, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { "Gato, kem bơ vị rượu rum, socola bào trắng, dừa sấy.", "White chocolate and coconut cake", 300000m, 300000m, 19, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 2, "Gato, kem, có phụ kiện trên mặt bánh", "Car dollar cake", 290000m, 290000m, 21, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Stock" },
                values: new object[] { 2, "Gato, kem vị trà xanh.", "Green tea four love", 170000m, 170000m, 0 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Name", "OriginalPrice", "Price", "Size", "Stock" },
                values: new object[] { 4, "Gato, kem tươi vị coffee", "Tiramisu", 160000m, 160000m, 21, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bread");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Mousse");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Cookies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Donuts");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "c5708f88-7dc2-4261-b10f-cf6762a20eac", "AQAAAAEAACcQAAAAEAtkR2o3z/ZV1P/8BpRuMOiRV8FYTvRz5FEXfWEvWL/JUfJpjV87vhSWyHwiKPtYkA==", "customer 2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "361f62ef-0ca8-4bc2-aea1-3e962c6adaea", "AQAAAAEAACcQAAAAEI6sAp229ACtqjHxK+vunyqapgYtuhTZTVvfTCbhMhUIZocGIrbbSoeEsz155xux2g==", "customer 1" });
        }
    }
}