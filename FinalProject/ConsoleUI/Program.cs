using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext context = new NorthwindContext();

            var products = context.Products.ToList();

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}
