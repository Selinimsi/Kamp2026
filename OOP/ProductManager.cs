using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class ProductManager
    {
      public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ "başarı ile eklendi");
            Console.ReadLine();

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "başarı ile güncellendi");
            Console.ReadLine();

        }






    }
}
