using GeeksBakery.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeeksBakery.Data.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>().HasData(
             new Cake()
             {
                 Id = 1,
                 Name = "Blackforest Cake With Cherries",
                 Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 4,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 200000
             },
             new Cake()
             {
                 Id = 2,
                 Name = "Snicker Fuse Chocolate Cake",
                 Description = "Award yourself with this rich chocolate cake wonderfully crammed with Cadbury Fuse and white chocolate chunks and draped lusciously with molten chocolate.This perfect work of art hides in every bite, the scrumptious flavours of heavily whipped chocolate cream and nutty bits of chocolate that is a little nutty and a lot of tasty! ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 200000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 250000
             },
             new Cake()
             {
                 Id = 3,
                 Name = "Red Velvet Fruit Layer Cake",
                 Description = "An exceptionally creamy Open - layered Red Velvet cake with a topping that tastes like a MASH UP between the tropical fruits is truly a luxurious treat.Experience the richness and smoothness in this delicacy which is laden with kiwis, cherries,apples, dragon fruits and black grapes.Who said healthy and delicious are poles apart ?",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 2,
                 Price = 180000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 260000
             },
             new Cake()
             {
                 Id = 4,
                 Name = "Chocolaty Creamy Round Cake",
                 Description = "This round chocolaty cake is the perfect treat for someone who is absolutely in love with chocolate cakes.This cake covered in rich chocolate ganache and decorated with chocolate shavings is the best gift one can have on their special day. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 290000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 310000
             },
             new Cake()
             {
                 Id = 5,
                 Name = "Rainbow Sprinkles Cake",
                 Description = "Any celebration is incomplete without this funfetti cake. Pipped with beautiful creamy decorations, this towering beauty is a grandiose deliciousness is sure to sweep everyone off their feet.And not just this, along with this beautify their day with extra sweetness and some extra colors with each bite topped with sumptuous confetti. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 6,
                 Price = 350000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 400000
             },
             new Cake()
             {
                 Id = 6,
                 Name = "Half Chocolate Half Vanilla Cake",
                 Description = "A toothsome treat for the sugar lovers who are just passionate about chocolate and relish the mushiness of cake.Made of two layers of impossibly moist chocolate filled with mushy rich cream, this cake carries the enticing aroma of Vanilla and sumptuousness of chocolate.On top of it, the cake is garnished with handcrafted white and brown chocolate.Need I say more ? ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 170000
             },
             new Cake()
             {
                 Id = 7,
                 Name = "Hearty Choco Gems Pinata Cake",
                 Description = "This heart-shaped cake is nicely decorated with pink vanilla flavoured glazing and edible gems of vibrant colours like yellow, gold, red, blue, and white. The bonus of Cadbury chocolates and more gems comes when the hearty vanilla cake’s sweet crust is smashed.Note = Hammer will be given with the cake. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 200000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 250000
             },
             new Cake()
             {
                 Id = 8,
                 Name = "Round Chocolate Truffle Cake",
                 Description = "The heavenly taste of this Choco Truffle Cake will even leave the hardest-to - please chocolate addicts tranquil in every sense. Prepared with three layers of relishing chocolate cream filled in between the soft stacks of chocolate cake, and adorned with beautiful chocolate icing and rich glaze chocolate coating, this one is just irresistible. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 350000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 430000
             },
             new Cake()
             {
                 Id = 9,
                 Name = "Birthday Black Forest Pinata Cake",
                 Description = "End the wait, break the ball with this black forest pinata cake, the true taste of surprise and luxury.It is a ball - shaped cake with a ball made of chocolate and a hammer that helps you break it loose. Next, what you see inside is a delicious black forest cake with icing, frosting and sponge, all chocolaty and mouth savouring.Make it your choice for all coming occasions.Note = Hammer will be given with the cake. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 2,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 200000
             },
             new Cake()
             {
                 Id = 10,
                 Name = "Round Shape Butterscotch Cake",
                 Description = "Always and Forever Delight!This three layered moist and smooth cake filled with butterscotch chips and Vanilla cream is something not to be missed! Topped with Butterscotch glaze and brown chocolate flakes, adorned with scrumptious caramel dressing on the sides, it's time to feel the crunch! ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 5,
                 Price = 290000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 370000
             },
             new Cake()
             {
                 Id = 11,
                 Name = "Heavenly Red Velvet Chocolate Cake",
                 Description = "The two celebratory flavours in a single cake--red velvet cake layers entirely covered in dark chocolate cream roses sprinkled with red velvet crumbs.A slice of the cake won't be enough to celebrate the fusion of flavours; you would need a whole cake. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 350000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 400000
             },
             new Cake()
             {
                 Id = 12,
                 Name = "Pineapple Cream Cake",
                 Description = "This cake is meant for all celebratory occasions! This three layered delicious pineapple flavoured cake filled with intensely whipped rich cream and pineapple fillings, perfectly defines simplicity at its best.Topped with pineapple slices, chocolate flakes and a further adorned with cherries, this cake is the perfect blend of sweetness and fluffiness. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 2,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 230000
             },
             new Cake()
             {
                 Id = 13,
                 Name = "Heart Shape Red Velvet Cake",
                 Description = "The deliciousness of red velvet has been baked into the shape of a heart that resembles your sheer love and affection for your sweetheart. Tender, moist, and fluffy in texture, this captivating red velvet cake is a perfect sweet to cast the spell of love. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 8,
                 Price = 180000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 200000
             },
             new Cake()
             {
                 Id = 14,
                 Name = "Assorted Fruit and Almond Cake",
                 Description = "Freshly baked Vanilla cake, Whipped cream and bountiful tropical fruits come together to create a treat that is even tastier than it looks.This combination of whipped cream and fresh fruit is a perfect start for any celebration and an enticing end to any meal. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 2,
                 Price = 260000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 310000
             },
             new Cake()
             {
                 Id = 15,
                 Name = "Red Velvet Buttercream Creamy Cake",
                 Description = "Another winning treat in your list of favorite items, a delicious Red Velvet cake with vanilla cream and icing, bedded red velvet ruling like a crown along with fragrant bread, the richest baked good.Greedy much, do remember to share the delicious deity with your loved ones and send some across to those you direly miss. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 3,
                 Price = 260000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 280000
             },
             new Cake()
             {
                 Id = 16,
                 Name = "Pineapple Gems Pinata Cake",
                 Description = "Both a joy to your sight as well as your taste buds, this pineapple flavoured scrumptious cake is a delight that you must indulge in every celebration!Frosted with pastel shades of buttercream, drizzling white chocolate ganache, and dollops of pink whipped cream on top, this delicious cake is loaded with copious amounts of gems in the center that spills out when you cut a slice! ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 2,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 250000
             },
             new Cake()
             {
                 Id = 17,
                 Name = "Blackforest Cake With Cherries",
                 Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 4,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 200000
             },
             new Cake()
             {
                 Id = 18,
                 Name = "Snicker Fuse Chocolate Cake",
                 Description = "Award yourself with this rich chocolate cake wonderfully crammed with Cadbury Fuse and white chocolate chunks and draped lusciously with molten chocolate.This perfect work of art hides in every bite, the scrumptious flavours of heavily whipped chocolate cream and nutty bits of chocolate that is a little nutty and a lot of tasty! ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 4,
                 Price = 200000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 250000
             },
             new Cake()
             {
                 Id = 19,
                 Name = "Red Velvet Fruit Layer Cake",
                 Description = "An exceptionally creamy Open - layered Red Velvet cake with a topping that tastes like a MASH UP between the tropical fruits is truly a luxurious treat.Experience the richness and smoothness in this delicacy which is laden with kiwis, cherries,apples, dragon fruits and black grapes.Who said healthy and delicious are poles apart ?",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 5,
                 Price = 180000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 260000
             },
             new Cake()
             {
                 Id = 20,
                 Name = "Chocolaty Creamy Round Cake",
                 Description = "This round chocolaty cake is the perfect treat for someone who is absolutely in love with chocolate cakes.This cake covered in rich chocolate ganache and decorated with chocolate shavings is the best gift one can have on their special day. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 5,
                 Price = 290000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 310000
             },
             new Cake()
             {
                 Id = 21,
                 Name = "Rainbow Sprinkles Cake",
                 Description = "Any celebration is incomplete without this funfetti cake. Pipped with beautiful creamy decorations, this towering beauty is a grandiose deliciousness is sure to sweep everyone off their feet.And not just this, along with this beautify their day with extra sweetness and some extra colors with each bite topped with sumptuous confetti. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 6,
                 Price = 350000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 400000
             },
             new Cake()
             {
                 Id = 22,
                 Name = "Half Chocolate Half Vanilla Cake",
                 Description = "A toothsome treat for the sugar lovers who are just passionate about chocolate and relish the mushiness of cake.Made of two layers of impossibly moist chocolate filled with mushy rich cream, this cake carries the enticing aroma of Vanilla and sumptuousness of chocolate.On top of it, the cake is garnished with handcrafted white and brown chocolate.Need I say more ? ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 6,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 170000
             },
             new Cake()
             {
                 Id = 23,
                 Name = "Hearty Choco Gems Pinata Cake",
                 Description = "This heart-shaped cake is nicely decorated with pink vanilla flavoured glazing and edible gems of vibrant colours like yellow, gold, red, blue, and white. The bonus of Cadbury chocolates and more gems comes when the hearty vanilla cake’s sweet crust is smashed.Note = Hammer will be given with the cake. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 6,
                 Price = 200000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 250000
             },
             new Cake()
             {
                 Id = 24,
                 Name = "Round Chocolate Truffle Cake",
                 Description = "The heavenly taste of this Choco Truffle Cake will even leave the hardest-to - please chocolate addicts tranquil in every sense. Prepared with three layers of relishing chocolate cream filled in between the soft stacks of chocolate cake, and adorned with beautiful chocolate icing and rich glaze chocolate coating, this one is just irresistible. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 7,
                 Price = 350000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 430000
             },
             new Cake()
             {
                 Id = 25,
                 Name = "Birthday Black Forest Pinata Cake",
                 Description = "End the wait, break the ball with this black forest pinata cake, the true taste of surprise and luxury.It is a ball - shaped cake with a ball made of chocolate and a hammer that helps you break it loose. Next, what you see inside is a delicious black forest cake with icing, frosting and sponge, all chocolaty and mouth savouring.Make it your choice for all coming occasions.Note = Hammer will be given with the cake. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 7,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 200000
             },
             new Cake()
             {
                 Id = 26,
                 Name = "Round Shape Butterscotch Cake",
                 Description = "Always and Forever Delight!This three layered moist and smooth cake filled with butterscotch chips and Vanilla cream is something not to be missed! Topped with Butterscotch glaze and brown chocolate flakes, adorned with scrumptious caramel dressing on the sides, it's time to feel the crunch! ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 7,
                 Price = 290000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 370000
             },
             new Cake()
             {
                 Id = 27,
                 Name = "Heavenly Red Velvet Chocolate Cake",
                 Description = "The two celebratory flavours in a single cake--red velvet cake layers entirely covered in dark chocolate cream roses sprinkled with red velvet crumbs.A slice of the cake won't be enough to celebrate the fusion of flavours; you would need a whole cake. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 7,
                 Price = 350000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 400000
             },
             new Cake()
             {
                 Id = 28,
                 Name = "Pineapple Cream Cake",
                 Description = "This cake is meant for all celebratory occasions! This three layered delicious pineapple flavoured cake filled with intensely whipped rich cream and pineapple fillings, perfectly defines simplicity at its best.Topped with pineapple slices, chocolate flakes and a further adorned with cherries, this cake is the perfect blend of sweetness and fluffiness. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 7,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 230000
             },
             new Cake()
             {
                 Id = 29,
                 Name = "Heart Shape Red Velvet Cake",
                 Description = "The deliciousness of red velvet has been baked into the shape of a heart that resembles your sheer love and affection for your sweetheart. Tender, moist, and fluffy in texture, this captivating red velvet cake is a perfect sweet to cast the spell of love. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 8,
                 Price = 180000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 200000
             },
             new Cake()
             {
                 Id = 30,
                 Name = "Assorted Fruit and Almond Cake",
                 Description = "Freshly baked Vanilla cake, Whipped cream and bountiful tropical fruits come together to create a treat that is even tastier than it looks.This combination of whipped cream and fresh fruit is a perfect start for any celebration and an enticing end to any meal. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 8,
                 Price = 260000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 310000
             },
             new Cake()
             {
                 Id = 31,
                 Name = "Red Velvet Buttercream Creamy Cake",
                 Description = "Another winning treat in your list of favorite items, a delicious Red Velvet cake with vanilla cream and icing, bedded red velvet ruling like a crown along with fragrant bread, the richest baked good.Greedy much, do remember to share the delicious deity with your loved ones and send some across to those you direly miss. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 8,
                 Price = 260000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 280000
             },
             new Cake()
             {
                 Id = 32,
                 Name = "Pineapple Gems Pinata Cake",
                 Description = "Both a joy to your sight as well as your taste buds, this pineapple flavoured scrumptious cake is a delight that you must indulge in every celebration!Frosted with pastel shades of buttercream, drizzling white chocolate ganache, and dollops of pink whipped cream on top, this delicious cake is loaded with copious amounts of gems in the center that spills out when you cut a slice! ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 8,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 250000
             });

            string jsonString = "[{\"Id\":1,\"CakeId\":1,\"FileName\":\"1.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":2,\"CakeId\":1,\"FileName\":\"1.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":3,\"CakeId\":1,\"FileName\":\"1.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":4,\"CakeId\":1,\"FileName\":\"1.4.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":5,\"CakeId\":2,\"FileName\":\"2.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":6,\"CakeId\":2,\"FileName\":\"2.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":7,\"CakeId\":2,\"FileName\":\"2.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":8,\"CakeId\":2,\"FileName\":\"2.4.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":9,\"CakeId\":3,\"FileName\":\"3.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":10,\"CakeId\":3,\"FileName\":\"3.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":11,\"CakeId\":3,\"FileName\":\"3.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":12,\"CakeId\":3,\"FileName\":\"3.4.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":13,\"CakeId\":4,\"FileName\":\"4.1.jfif\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":14,\"CakeId\":4,\"FileName\":\"4.2.jfif\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":15,\"CakeId\":4,\"FileName\":\"4.3.jfif\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":16,\"CakeId\":4,\"FileName\":\"4.4.jfif\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":17,\"CakeId\":5,\"FileName\":\"5.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":18,\"CakeId\":5,\"FileName\":\"5.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":19,\"CakeId\":5,\"FileName\":\"5.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":20,\"CakeId\":5,\"FileName\":\"5.4.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":21,\"CakeId\":6,\"FileName\":\"6.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":22,\"CakeId\":6,\"FileName\":\"6.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":23,\"CakeId\":6,\"FileName\":\"6.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":24,\"CakeId\":6,\"FileName\":\"6.4.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":25,\"CakeId\":7,\"FileName\":\"7.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":26,\"CakeId\":7,\"FileName\":\"7.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":27,\"CakeId\":8,\"FileName\":\"8.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":28,\"CakeId\":8,\"FileName\":\"8.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":29,\"CakeId\":8,\"FileName\":\"8.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":30,\"CakeId\":8,\"FileName\":\"8.4.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":31,\"CakeId\":9,\"FileName\":\"9.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":32,\"CakeId\":9,\"FileName\":\"9.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":33,\"CakeId\":9,\"FileName\":\"9.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":34,\"CakeId\":10,\"FileName\":\"10.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":35,\"CakeId\":10,\"FileName\":\"10.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":36,\"CakeId\":10,\"FileName\":\"10.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":37,\"CakeId\":11,\"FileName\":\"11.1.jfif\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":38,\"CakeId\":11,\"FileName\":\"11.2.jfif\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":39,\"CakeId\":11,\"FileName\":\"11.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":40,\"CakeId\":12,\"FileName\":\"12.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":41,\"CakeId\":12,\"FileName\":\"12.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":42,\"CakeId\":12,\"FileName\":\"12.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":43,\"CakeId\":12,\"FileName\":\"12.4.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":44,\"CakeId\":13,\"FileName\":\"13.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":45,\"CakeId\":13,\"FileName\":\"13.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":46,\"CakeId\":14,\"FileName\":\"14.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":47,\"CakeId\":14,\"FileName\":\"14.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":48,\"CakeId\":14,\"FileName\":\"14.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":49,\"CakeId\":15,\"FileName\":\"15.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":50,\"CakeId\":15,\"FileName\":\"15.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":51,\"CakeId\":15,\"FileName\":\"15.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":52,\"CakeId\":16,\"FileName\":\"16.1.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":53,\"CakeId\":16,\"FileName\":\"16.2.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0},{\"Id\":54,\"CakeId\":16,\"FileName\":\"16.3.jpg\",\"Caption\":\"Cake Images\",\"IsDefault\":true,\"SortOrder\":1,\"FileSize\":0}]";
            IList<CakeImage> objects = JsonConvert.DeserializeObject<IList<CakeImage>>(jsonString);

            modelBuilder.Entity<CakeImage>().HasData(
                    objects.Select(x => x)
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Chocolate", Description = "For Choco Addicts" },
                new Category { Id = 2, Name = "Fruits", Description = "A taste of tropics" },
                new Category { Id = 3, Name = "Exotic", Description = "Oreo, Rochers & more" },
                new Category { Id = 4, Name = "Blackforest", Description = "The all time Favourite" },
                new Category { Id = 5, Name = "Butterscotch", Description = "For Candy Fans" },
                new Category { Id = 6, Name = "Vanilla", Description = "The Evergreen" },
                new Category { Id = 7, Name = "Coffee", Description = "For Expresso Lover" },
                new Category { Id = 8, Name = "Strawberry", Description = "An ideal Complement" }
                );
            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, CakeId = 1, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Bánh ngon", Star = 5, DateCreated = DateTime.Now },
                new Review() { Id = 2, CakeId = 1, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Bánh hơi ngon", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 3, CakeId = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Bánh dở", Star = 2, DateCreated = DateTime.Now },
                new Review() { Id = 4, CakeId = 2, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Bánh không ngon", Star = 3, DateCreated = DateTime.Now },
                new Review() { Id = 5, CakeId = 6, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Ngon đó", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 6, CakeId = 3, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Delicious", Star = 5, DateCreated = DateTime.Now },
                new Review() { Id = 7, CakeId = 3, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Yeah", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 8, CakeId = 7, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Đây là comment", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 9, CakeId = 8, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Màu sắc đẹp", Star = 5, DateCreated = DateTime.Now },
                new Review() { Id = 10, CakeId = 9, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Hương vị thật ngon", Star = 5, DateCreated = DateTime.Now }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 21, 12, 45, 0), DeliveryDate = new DateTime(2021, 5, 21, 12, 45, 0), Status = Enums.Status.Completed },
                new Order { Id = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 22, 13, 41, 0), DeliveryDate = new DateTime(2021, 5, 22, 10, 50, 0), Status = Enums.Status.Completed },
                new Order { Id = 3, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 22, 15, 23, 0), DeliveryDate = new DateTime(2021, 5, 23, 9, 34, 0), Status = Enums.Status.Completed },
                new Order { Id = 4, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 23, 12, 11, 0), DeliveryDate = new DateTime(2021, 5, 23, 16, 23, 0), Status = Enums.Status.Completed },
                new Order { Id = 5, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 24, 12, 11, 0), Status = Enums.Status.Shipping },
                new Order { Id = 6, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), DateCreated = new DateTime(2021, 5, 24, 12, 30, 0), Status = Enums.Status.Pending });

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderId = 1, CakeId = 1, Amount = 2 },
                new OrderDetail { OrderId = 2, CakeId = 2, Amount = 1 },
                new OrderDetail { OrderId = 3, CakeId = 3, Amount = 1 },
                new OrderDetail { OrderId = 3, CakeId = 1, Amount = 2 },
                new OrderDetail { OrderId = 4, CakeId = 1, Amount = 1 },
                new OrderDetail { OrderId = 5, CakeId = 3, Amount = 1 },
                new OrderDetail { OrderId = 5, CakeId = 2, Amount = 1 },
                new OrderDetail { OrderId = 6, CakeId = 4, Amount = 1 });

            // create any guid
            var adminRoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var customerRoleId = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var customerId = new Guid("BFF91064-DC92-421E-A233-D1080F630928");
            var customerId2 = new Guid("BFF91054-DC92-421E-A233-D1080F630928");
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                new AppRole
                {
                    Id = customerRoleId,
                    Name = "customer",
                    NormalizedName = "customer",
                    Description = "Customer role"
                });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "trung@gmail.com",
                    NormalizedEmail = "trung@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Pham Chi Trung",
                    DoB = new DateTime(2000, 02, 11)
                },
                new AppUser
                {
                    Id = customerId,
                    UserName = "customer1",
                    NormalizedUserName = "customer",
                    Email = "customer1@gmail.com",
                    NormalizedEmail = "customer1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Pham Chi Trung Customer",
                    DoB = new DateTime(2000, 02, 22)
                },
                new AppUser
                {
                    Id = customerId2,
                    UserName = "customer2",
                    NormalizedUserName = "customer",
                    Email = "customer2@gmail.com",
                    NormalizedEmail = "customer2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "David",
                    DoB = new DateTime(1996, 02, 22)
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = adminRoleId,
                    UserId = adminId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId2,
                });
        }
    }
}