using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShopContext())
            {
                Product product = new Product
                {
                    Name="Хлеб",
                    Description="Чиабатта",
                    Price=228
                };
               

                Shop shop = new Shop
                {
                    Address = "Кабанбай батырханаболетапекулы"
                };
                context.Products.Add(product);
                shop.Products.Add(product);
                context.Shops.Add(shop);
                context.SaveChanges();
            }

        }
    }
}
