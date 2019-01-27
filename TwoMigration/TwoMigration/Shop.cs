using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoMigration
{
   public class Shop
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }

        public Shop()
        {
            Products = new List<Product>();
        }
    }
}
