using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeeksBakery.Data.Migrations
{
    public partial class add_more_cake_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 311, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateDeleted", "DateModified", "Description", "Name", "OriginalPrice", "Price", "Size", "Slug", "Stock" },
                values: new object[,]
                {
                    { 17, 4, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3799), null, null, "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.", "Blackforest Cake With Cherries", 200000m, 150000m, 20, null, 1 },
                    { 23, 6, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3883), null, null, "This heart-shaped cake is nicely decorated with pink vanilla flavoured glazing and edible gems of vibrant colours like yellow, gold, red, blue, and white. The bonus of Cadbury chocolates and more gems comes when the hearty vanilla cake’s sweet crust is smashed.Note = Hammer will be given with the cake. ", "Hearty Choco Gems Pinata Cake", 250000m, 200000m, 20, null, 1 },
                    { 18, 4, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3801), null, null, "Award yourself with this rich chocolate cake wonderfully crammed with Cadbury Fuse and white chocolate chunks and draped lusciously with molten chocolate.This perfect work of art hides in every bite, the scrumptious flavours of heavily whipped chocolate cream and nutty bits of chocolate that is a little nutty and a lot of tasty! ", "Snicker Fuse Chocolate Cake", 250000m, 200000m, 20, null, 1 },
                    { 19, 5, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3803), null, null, "An exceptionally creamy Open - layered Red Velvet cake with a topping that tastes like a MASH UP between the tropical fruits is truly a luxurious treat.Experience the richness and smoothness in this delicacy which is laden with kiwis, cherries,apples, dragon fruits and black grapes.Who said healthy and delicious are poles apart ?", "Red Velvet Fruit Layer Cake", 260000m, 180000m, 20, null, 1 },
                    { 20, 5, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3874), null, null, "This round chocolaty cake is the perfect treat for someone who is absolutely in love with chocolate cakes.This cake covered in rich chocolate ganache and decorated with chocolate shavings is the best gift one can have on their special day. ", "Chocolaty Creamy Round Cake", 310000m, 290000m, 20, null, 1 },
                    { 21, 6, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3878), null, null, "Any celebration is incomplete without this funfetti cake. Pipped with beautiful creamy decorations, this towering beauty is a grandiose deliciousness is sure to sweep everyone off their feet.And not just this, along with this beautify their day with extra sweetness and some extra colors with each bite topped with sumptuous confetti. ", "Rainbow Sprinkles Cake", 400000m, 350000m, 20, null, 1 },
                    { 22, 6, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3880), null, null, "A toothsome treat for the sugar lovers who are just passionate about chocolate and relish the mushiness of cake.Made of two layers of impossibly moist chocolate filled with mushy rich cream, this cake carries the enticing aroma of Vanilla and sumptuousness of chocolate.On top of it, the cake is garnished with handcrafted white and brown chocolate.Need I say more ? ", "Half Chocolate Half Vanilla Cake", 170000m, 150000m, 20, null, 1 },
                    { 24, 7, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3885), null, null, "The heavenly taste of this Choco Truffle Cake will even leave the hardest-to - please chocolate addicts tranquil in every sense. Prepared with three layers of relishing chocolate cream filled in between the soft stacks of chocolate cake, and adorned with beautiful chocolate icing and rich glaze chocolate coating, this one is just irresistible. ", "Round Chocolate Truffle Cake", 430000m, 350000m, 20, null, 1 },
                    { 25, 7, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3887), null, null, "End the wait, break the ball with this black forest pinata cake, the true taste of surprise and luxury.It is a ball - shaped cake with a ball made of chocolate and a hammer that helps you break it loose. Next, what you see inside is a delicious black forest cake with icing, frosting and sponge, all chocolaty and mouth savouring.Make it your choice for all coming occasions.Note = Hammer will be given with the cake. ", "Birthday Black Forest Pinata Cake", 200000m, 150000m, 20, null, 1 },
                    { 27, 7, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3892), null, null, "The two celebratory flavours in a single cake--red velvet cake layers entirely covered in dark chocolate cream roses sprinkled with red velvet crumbs.A slice of the cake won't be enough to celebrate the fusion of flavours; you would need a whole cake. ", "Heavenly Red Velvet Chocolate Cake", 400000m, 350000m, 20, null, 1 },
                    { 26, 7, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3890), null, null, "Always and Forever Delight!This three layered moist and smooth cake filled with butterscotch chips and Vanilla cream is something not to be missed! Topped with Butterscotch glaze and brown chocolate flakes, adorned with scrumptious caramel dressing on the sides, it's time to feel the crunch! ", "Round Shape Butterscotch Cake", 370000m, 290000m, 20, null, 1 },
                    { 29, 8, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3896), null, null, "The deliciousness of red velvet has been baked into the shape of a heart that resembles your sheer love and affection for your sweetheart. Tender, moist, and fluffy in texture, this captivating red velvet cake is a perfect sweet to cast the spell of love. ", "Heart Shape Red Velvet Cake", 200000m, 180000m, 20, null, 1 },
                    { 30, 8, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3898), null, null, "Freshly baked Vanilla cake, Whipped cream and bountiful tropical fruits come together to create a treat that is even tastier than it looks.This combination of whipped cream and fresh fruit is a perfect start for any celebration and an enticing end to any meal. ", "Assorted Fruit and Almond Cake", 310000m, 260000m, 20, null, 1 },
                    { 31, 8, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3901), null, null, "Another winning treat in your list of favorite items, a delicious Red Velvet cake with vanilla cream and icing, bedded red velvet ruling like a crown along with fragrant bread, the richest baked good.Greedy much, do remember to share the delicious deity with your loved ones and send some across to those you direly miss. ", "Red Velvet Buttercream Creamy Cake", 280000m, 260000m, 20, null, 1 },
                    { 32, 8, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3903), null, null, "Both a joy to your sight as well as your taste buds, this pineapple flavoured scrumptious cake is a delight that you must indulge in every celebration!Frosted with pastel shades of buttercream, drizzling white chocolate ganache, and dollops of pink whipped cream on top, this delicious cake is loaded with copious amounts of gems in the center that spills out when you cut a slice! ", "Pineapple Gems Pinata Cake", 250000m, 150000m, 20, null, 1 },
                    { 28, 7, new DateTime(2021, 7, 17, 1, 18, 4, 312, DateTimeKind.Local).AddTicks(3894), null, null, "This cake is meant for all celebratory occasions! This three layered delicious pineapple flavoured cake filled with intensely whipped rich cream and pineapple fillings, perfectly defines simplicity at its best.Topped with pineapple slices, chocolate flakes and a further adorned with cherries, this cake is the perfect blend of sweetness and fluffiness. ", "Pineapple Cream Cake", 230000m, 150000m, 20, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 17, 1, 18, 4, 466, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "8f6ed192-cdb1-4ea9-8f66-11ea49881073");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0af71860-e60d-40aa-b465-2910a471b567");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1dea96d-da4b-4e0f-beb3-aa2914d211c6", "AQAAAAEAACcQAAAAEPsQ90h+rUqYYLlXTRs0tRmm556aUtCxJaTRRTo4mtOrTqaJm3V/RJwWB/rVVtjpgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab666401-5b84-4aac-ae2c-face8aebc92b", "AQAAAAEAACcQAAAAEO21qLyVFwqwn+j6vbBgf6r7c2DJwMNyM2GSoLzIC7P+lttjFW8aSbZ6FQoNpD/eSQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0818cdb8-3e26-4e78-ad72-2de258129bba", "AQAAAAEAACcQAAAAEB4EuWm8Fj756/jwH2/DftZ4n2zFcGurJYkJ6qKi8o4jK3iryd4lWxNJV1XYejzbmA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 29, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 30, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 15, 12, 54, 9, 185, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "81149cbe-98dd-43b0-ab33-8562cb33a392");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c071ad8c-96eb-48fa-8cea-5d6fcab08ea6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b82b70e-663a-4270-9847-f6ebea706131", "AQAAAAEAACcQAAAAEN7U3pjGbrlOtB0T8UCW9CG+3HDboiyvGpFXMmjpYfAqkTbwNXjP3Q7+RTkMV++L0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "142ff2dd-3e5b-4633-b2dd-e0c061b25693", "AQAAAAEAACcQAAAAENGvdZnndnr6f8iPPKCTVYiEydDjXcTFKgpx+sSABYRYKRyVm4Rw6kZzV10EcAHwtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83ca8ff4-5f9a-457b-a37d-5375ef15d855", "AQAAAAEAACcQAAAAEBn5ivYinX8DxBVZJNcrCnc9lrcSKdazNL7WOoAeP6qrdDdHKqQ6jueoiXNbVfjHrQ==" });
        }
    }
}
