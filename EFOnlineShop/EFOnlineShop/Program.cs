using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShopContext())
            {
                Category meat = new Category
                {
                    CategoryName = "Мяско"
                };

                Product rabbitMeat = new Product
                {
                    Name = "Мясо однодневного кролика",
                    Price = 240,
                    Category = meat
                };

                Shop interfood = new Shop
                {
                    LocationAddress = "Highvill block G",
                    Name = "Interfood"
                };

                context.Shops.Add(interfood);
                context.Categories.Add(meat);
                context.Products.Add(rabbitMeat);
                interfood.Categories.Add(meat);
                interfood.Products.Add(rabbitMeat);
                context.SaveChanges();
            }
        }
    }
}
