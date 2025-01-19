namespace IT_PROJECT.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IT_PROJECT.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IT_PROJECT.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(
                p => p.Name,
                new Models.Product { Category = "Fruits", Name = "Red Apple", Price = 79.00m, Weight = "1kg", ImageURL = "/Images/Fruits/red_apple.jpg" },
                new Models.Product { Category = "Fruits", Name = "Green Apple", Price = 79.00m, Weight = "1kg", ImageURL = "/Images/Fruits/green_apple.jpg" },
                new Models.Product { Category = "Fruits", Name = "Pear", Price = 249.00m, Weight = "1kg", ImageURL = "/Images/Fruits/pear.jpg" },
                new Models.Product { Category = "Fruits", Name = "Banana", Price = 79.00m, Weight = "1kg", ImageURL = "/Images/Fruits/banana.jpg" },
                new Models.Product { Category = "Fruits", Name = "Peach", Price = 46.00m, Weight = "1kg",  ImageURL = "/Images/Fruits/peach.jpg" },
                new Models.Product { Category = "Fruits", Name = "Nectarine", Price = 64.00m, Weight = "1kg", ImageURL = "/Images/Fruits/nectarine.jpg" },
                new Models.Product { Category = "Fruits", Name = "Kiwi", Price = 249.00m, Weight = "1kg", ImageURL = "/Images/Fruits/kiwi.jpg" },
                new Models.Product { Category = "Fruits", Name = "Apricot", Price = 86.00m, Weight = "1kg", ImageURL = "/Images/Fruits/apricot.jpg" },
                new Models.Product { Category = "Fruits", Name = "Plum", Price = 74.00m, Weight = "1kg", ImageURL = "/Images/Fruits/plum.jpg" },
                new Models.Product { Category = "Fruits", Name = "Raspberry", Price = 249.00m, Weight = "125g", ImageURL = "/Images/Fruits/raspberry.jpg" },
                new Models.Product { Category = "Fruits", Name = "Blueberry", Price = 235.00m, Weight = "125g", ImageURL = "/Images/Fruits/blueberry.jpg" },
                new Models.Product { Category = "Fruits", Name = "Orange", Price = 43.00m, Weight = "1kg", ImageURL = "/Images/Fruits/orange.jpg" },
                new Models.Product { Category = "Fruits", Name = "Lemon", Price = 119.00m, Weight = "1kg", ImageURL = "/Images/Fruits/lemon.jpg" },
                new Models.Product { Category = "Fruits", Name = "Watermelon", Price = 155.00m, Weight = "5.5kg", ImageURL = "/Images/Fruits/watermelon.jpg" },
                new Models.Product { Category = "Fruits", Name = "Melon", Price = 129.00m, Weight = "1.5kg", ImageURL = "/Images/Fruits/melon.jpg" },
                new Models.Product { Category = "Fruits", Name = "Cherry", Price = 69.00m, Weight = "500g", ImageURL = "/Images/Fruits/cherry.jpg" },
                new Models.Product { Category = "Fruits", Name = "Red Citrus", Price = 139.00m, Weight = "1kg", ImageURL = "/Images/Fruits/red_citrus.jpg" },
                new Models.Product { Category = "Fruits", Name = "Lime", Price = 195.00m, Weight = "500g", ImageURL = "/Images/Fruits/lime.jpg" },
                new Models.Product { Category = "Fruits", Name = "Pineapple", Price = 129.00m, Weight = "1.1kg", ImageURL = "/Images/Fruits/pineapple.jpg" },
                new Models.Product { Category = "Fruits", Name = "Mango", Price = 199.00m, Weight = "450g", ImageURL = "/Images/Fruits/mango.jpg" },
                new Models.Product { Category = "Fruits", Name = "Avocado", Price = 49.00m, Weight = "160g", ImageURL = "/Images/Fruits/avocado.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Potato", Price = 23.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/potato.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Sweet Potato", Price = 209.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/sweet_potato.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Red Tomato", Price = 35.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/red_tomato.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Pink Tomato", Price = 45.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/pink_tomato.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Cherry Tomatoes", Price = 129.00m, Weight = "500g", ImageURL = "/Images/Vegetables/cherry_tomatoes.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Yellow Onion", Price = 19.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/yellow_onion.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Red Onion", Price = 90.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/red_onion.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Carrot", Price = 29.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/carrot.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Sweet Green Pepper", Price = 55.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/sweet_green_pepper.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Hot Green Pepper", Price = 55.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/hot_green_pepper.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Green Bell Pepper", Price = 90.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/green_bell_pepper.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Eggplant", Price = 23.00m, Weight = "350g", ImageURL = "/Images/Vegetables/eggplant.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Zucchini", Price = 9.00m, Weight = "380g", ImageURL = "/Images/Vegetables/zucchini.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Cabbage", Price = 27.00m, Weight = "1.5kg", ImageURL = "/Images/Vegetables/cabbage.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Red Cabbage", Price = 49.00m, Weight = "1.2kg", ImageURL = "/Images/Vegetables/red_cabbage.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Broccoli", Price = 23.00m, Weight = "500g", ImageURL = "/Images/Vegetables/broccoli.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Cucumber", Price = 49.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/cucumber.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Parsley", Price = 17.00m, Weight = "55g", ImageURL = "/Images/Vegetables/parsley.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Garlic", Price = 25.00m, Weight = "50g", ImageURL = "/Images/Vegetables/garlic.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Lettuce", Price = 29.00m, Weight = "300g", ImageURL = "/Images/Vegetables/lettuce.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Spinach", Price = 65.00m, Weight = "650g", ImageURL = "/Images/Vegetables/spinach.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Baby Spinach", Price = 90.00m, Weight = "100g", ImageURL = "/Images/Vegetables/baby_spinach.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Champignons", Price = 105.00m, Weight = "400g", ImageURL = "/Images/Vegetables/fresh_champignon_mushrooms.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Beetroot", Price = 35.00m, Weight = "1kg", ImageURL = "/Images/Vegetables/beetroot.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Basil", Price = 69.00m, Weight = "20g", ImageURL = "/Images/Vegetables/basil.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Ginger", Price = 69.00m, Weight = "200g", ImageURL = "/Images/Vegetables/ginger.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Arugula", Price = 83.00m, Weight = "125g", ImageURL = "/Images/Vegetables/arugula.jpg" },
                new Models.Product { Category = "Vegetables", Name = "Wax Beans", Price = 127.00m, Weight = "450g", ImageURL = "/Images/Vegetables/wax_beans.jpg" },
                new Models.Product { Category = "Dairy", Name = "Cow Milk 0.5%", Price = 89.00m, Weight = "1l", ImageURL = "/Images/DairyEggs/cow_milk.jpg" },
                new Models.Product { Category = "Dairy", Name = "Cow Milk 3.2%", Price = 65.00m, Weight = "1l", ImageURL = "/Images/DairyEggs/cow_milk.jpg" },
                new Models.Product { Category = "Dairy", Name = "Goat Milk 3.5%", Price = 199.00m, Weight = "1l", ImageURL = "/Images/DairyEggs/goat_milk.jpg" },
                new Models.Product { Category = "Dairy", Name = "Greek Yoghurt", Price = 75.00m, Weight = "400g", ImageURL = "/Images/DairyEggs/greek_yoghurt.jpg" },
                new Models.Product { Category = "Dairy", Name = "Cow Cheese", Price = 205.00m, Weight = "400g", ImageURL = "/Images/DairyEggs/cow_cheese.jpg" },
                new Models.Product { Category = "Dairy", Name = "Gouda Cheese", Price = 269.00m, Weight = "300g", ImageURL = "/Images/DairyEggs/gouda_cheese.jpg" },
                new Models.Product { Category = "Dairy", Name = "Eggs", Price = 269.00m, Weight = "30", ImageURL = "/Images/DairyEggs/eggs.jpg" }
             );
        }
    }
}
