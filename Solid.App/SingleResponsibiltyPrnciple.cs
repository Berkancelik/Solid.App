using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SingleResponsibiltyPrnciple
{
    
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private static List<Product> products = new List<Product>();

        public Product()
        {
          
        }
    }
}
