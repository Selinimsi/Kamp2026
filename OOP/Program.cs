using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();// heapde bellek adresi alabilmek için newleme işlemi yapılır.

            product1.Id = 1;
            product1.CategoryId = 5;
            product1.ProductName = "Çizgili defter";
            product1.UnitsInPrice = 90;
            product1.UnitsInPrice = 40;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
