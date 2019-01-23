using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOnlineShop
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LocationAddress { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public Shop()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
        }
    }
}
