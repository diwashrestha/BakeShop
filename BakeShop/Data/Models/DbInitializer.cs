using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.GetRequiredService<AppDbContext>();
            if(!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if(!context.BakeryItems.Any())
            {
                context.AddRange(
                    new BakeryItem
                    {
                        Name = "Flourless Cake",
                        Price = 20.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_1.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_1.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Hummingbird Cake",
                        Price = 30.95M,
                        ShortDescription = "The best Hummingbird Cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_2.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_2.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Lady Baltimore Cake",
                        Price = 25.95M,
                        ShortDescription = "The best Lady Baltimore Cake",
                        Longdescription = "Fluffy white cake is layered with a fruit and nut filling and topped with a pillowy meringue type frosting. The origin of the cake is somewhat in dispute, but it’s believed to have been created in the southern part of the United States.",
                        Category = Categories["Cake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_3.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_3.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Pound Cake",
                        Price = 22.95M,
                        ShortDescription = "The best Pound Cake",
                        Longdescription = "Genoise is what a sponge cake is called in Italy or France. In this cake, egg yolks, whites and sugar are beaten together until mousse-like. Next, flour, and either oil or butter, are folded in. This type of sponge cake is more moist and tender than its sponge cake cousin.",
                        Category = Categories["Cake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_4.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_4.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Genoise Cake",
                        Price = 25.95M,
                        ShortDescription = "The best Genoise Cake",
                        Longdescription = "Genoise is what a sponge cake is called in Italy or France. In this cake, egg yolks, whites and sugar are beaten together until mousse-like. Next, flour, and either oil or butter, are folded in. This type of sponge cake is more moist and tender than its sponge cake cousin.",
                        Category = Categories["Cake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_5.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_5.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Opera Cake",
                        Price = 40.95M,
                        ShortDescription = "The best Opera Cake",
                        Longdescription = "The history of this type of cake is a bit muddled. One thing we do know, however, is that its thin layers of coffee-soaked almond cake are sandwiched between an espresso-flavored buttercream, a bittersweet chocolate ganache, and topped off with a second rich chocolate ganache. Light but rich, this pastry is a real showstopper.",
                        Category = Categories["Cake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_7.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cake_7.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Frosted Doughnut",
                        Price = 10.95M,
                        ShortDescription = "Doughnut with frosted chocolate",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Doughnut"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_2.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_2.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Old-Fashioned Doughnut",
                        Price = 5.95M,
                        ShortDescription = "The best Old-Fashioned Doughnuts",
                        Longdescription = "An old-fashioned doughnut, as the name suggests, dates all the way back to the 1830s. It has a similar glaze to the classic glazed doughnut, but with a more cakey base. It's a little rough around the edges, with a crunchy exterior but a soft inside. It has a larger hole in the center than most doughnuts, and it's peppered with cracks and ridges that soak up all the sweet glaze. You can also get them with chocolate glaze.",
                        Category = Categories["Doughnut"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_3.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_3.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Frosted Doughnut",
                        Price = 8.95M,
                        ShortDescription = "The best Frosted Doughnuts",
                        Longdescription = "Potentially the most picturesque of all doughnut types, frosted doughnuts get their name for what's on top: frosting. They can be either cake or yeast doughnuts, but cake doughnuts provide a sturdier base for thick frosting. Get creative with frosted doughnuts—sprinkles are a must!",
                        Category = Categories["Doughnut"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_7.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_7.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Cider Doughnut",
                        Price = 9.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "These fabulous fall doughnuts are round with a hole in the middle, but are typically smaller in size and more dense. Cider doughnuts fall within the cake doughnut category. They're infused with apple-cider and sprinkled generously with cinnamon or sugar (and perfect for dunking in coffee!). Synonymous with apple orchards, fall festivals, and hayrides—cider doughnuts are like a warm hug on a cool fall day.",
                        Category = Categories["Doughnut"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_8.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_8.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Doughnut",
                        Price = 10.95M,
                        ShortDescription = "The best Chocolate doughnut",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Doughnut"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_5.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_5.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Strawberry Doughnut",
                        Price = 12.95M,
                        ShortDescription = "The best Strawberry Frosted Doughnut",
                        Longdescription = "With fresh strawberries baked in, and a sweet, tangy pink strawberry icing, these are a perfect treat for breakfast.",
                        Category = Categories["Doughnut"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_6.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_6.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Jelly Doughnut",
                        Price = 11.95M,
                        ShortDescription = "The best Jelly Doughnut",
                        Longdescription = "A jelly (or jam) doughnut is a doughnut stuffed with jelly filling. These light doughnuts will be the hit of any autumn or winter brunch. ",
                        Category = Categories["Doughnut"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_4.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/doughnut_4.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Butterbeer Cupcake",
                        Price = 4.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_1.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_1.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Lavender Cupcake",
                        Price = 5.95M,
                        ShortDescription = "The best Lavender Frost Cupcake",
                        Longdescription = "This springtime cupcake pairs the refreshing flavor of lemon with an oh-la-la lavender frosting for a dynamic-and delightful-anytime treat. ",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_7.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_7.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Blueberry Cupcake",
                        Price = 4.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_5.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_5.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Strawberry Cupcake",
                        Price = 8.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_2.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_2.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Coffee Cupcake",
                        Price = 2.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_3.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_3.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Coconut Cupcake",
                        Price = 10.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_7.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_7.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Coconut Cupcake",
                        Price = 9.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_6.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_6.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Orange Cupcake",
                        Price = 7.95M,
                        ShortDescription = "The best Orange Cupcake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_4.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_4.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cupcake",
                        Price = 6.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cupcake"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_8.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cupcake_8.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Gingersnaps Cookies",
                        Price = 6.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "These spicy treats are popular all around the world. Powdered ginger, cinnamon, molasses, and nutmeg make this popular holiday cookie the perfect blend of sweet and spicy.",
                        Category = Categories["Cookie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_3.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_3.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Oatmeal Raisin Cookies",
                        Price = 10.95M,
                        ShortDescription = "The best Oatmeal Raisin Cookies",
                        Longdescription = "A seriously underrated cookie, oatmeal raisin is another type of drop cookie. Its dough is oatmeal based and contains raisins and brown sugar. They're warm and comforting — a reminder of simpler times and grandma's house.",
                        Category = Categories["Cookie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_8.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_8.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Drop Cookies",
                        Price = 20.95M,
                        ShortDescription = "The best Drop cookies",
                        Longdescription = "A drop cookie is any cookie that's made by dropping spoonfuls of dough directly onto a baking sheet.",
                        Category = Categories["Cookie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_1.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_1.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Butter Cookies",
                        Price = 4.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Cookie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_7.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_7.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Molasses Cookies",
                        Price = 2.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "An offshoot of the popular holiday gingerbread cookies, molasses cookies are made with just as much ginger.",
                        Category = Categories["Cookie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_5.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_5.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Chip Cookies",
                        Price = 2.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "Among the most popular of all cookie types, the chocolate chip cookie's invention was a happy accident. In 1930, Ruth Graves Wakefield, who ran the Toll House Inn in Whitman, Massachusetts, ran out of baker's chocolate and substituted for it with pieces of Nestle's® semi-sweet chocolate.",
                        Category = Categories["Cookie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_6.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/cookie_6.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Baguette Bread",
                        Price = 20.95M,
                        ShortDescription = "The best Baguette cake",
                        Longdescription = "A baguette is a long, thin loaf of bread commonly served with a simple spread or butter",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_7.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_7.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Rye Bread",
                        Price = 25.95M,
                        ShortDescription = "The best Rye Bread",
                        Longdescription = "rucial to beloved deli sandwiches like pastrami and corned beef-based Reubens, rye bread can come light, medium or dark, depending on which part of the rye berry is used to make the flour.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_11.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_11.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Challah Bread",
                        Price = 11.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "Challah, which is made with eggs and most often braided, is integral to the Jewish faith. Served on the Sabbath and holidays, it was originally called berches before the word challah was adopted in the Middle Ages.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_6.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_6.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Bum Bread",
                        Price = 12.95M,
                        ShortDescription = "The best Bum Bread",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_2.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_2.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Brioche Bread",
                        Price = 12.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "A highly enriched bread, noted for its high butter and egg content, commonly served as a component of French desserts.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_3.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_3.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "White bread",
                        Price = 9.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "Made from wheat flour from which the bran and the germ have been removed through a process known as milling.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_4.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_4.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Zopf Bread",
                        Price = 5.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "Made of white flour, milk, egg, butter, yeast, dough is braided, brushed with egg yolk before baking, forming a gold crust.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_13.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_13.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Borodinsky Bread",
                        Price = 10.95M,
                        ShortDescription = "The best Borodinsky Bread",
                        Longdescription = "A dark brown sourdough rye bread, traditionally sweetened with molasses and flavored with coriander and caraway seeds.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_5.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_5.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Anadama Bread",
                        Price = 13.95M,
                        ShortDescription = "The best Anadama bread",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_12.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_12.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Arboud Bread",
                        Price = 12.95M,
                        ShortDescription = "The best Arboud Bread",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Bread"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_10.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/bread_10.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Pastafrola Pie",
                        Price = 26.95M,
                        ShortDescription = "The best Pastafrola Pie",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Pie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_4.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_4.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Cashew  Pie",
                        Price = 28.95M,
                        ShortDescription = "The best Cashew Pie",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Pie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_3.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_3.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Apple Pie",
                        Price = 25.95M,
                        ShortDescription = "The best Apple Pie",
                        Longdescription = "A fruit pie (or tart) in which the principal filling ingredient is crisp and acidic cooking apples such as the Bramley or Granny Smith.",
                        Category = Categories["Pie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_1.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_1.png?raw=true"

                    },
                    new BakeryItem
                    {
                        Name = "Butter Pie",
                        Price = 22.95M,
                        ShortDescription = "The best flourless cake",
                        Longdescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust.",
                        Category = Categories["Pie"],
                        ImageUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_2.png?raw=true",
                        InStock = true,
                        IsPreferredBakeryitem = false,
                        ImageThumbnailUrl = "https://github.com/diwashrestha/BakeShop/blob/master/BakeShop/wwwroot/Images/BakeShop/pie_2.png?raw=true"

                    }

                    );
            }
            context.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Cake", Description="All Cake items" },
                        new Category { CategoryName = "Doughnut", Description="All Doughnut items" },
                        new Category { CategoryName = "Cupcake", Description="All Cup cake items" },
                        new Category { CategoryName = "Cookie", Description="All Cookie items" },
                        new Category { CategoryName = "Pie", Description="All Pie items" },
                        new Category { CategoryName = "Bread", Description="All Bread items" },

                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
