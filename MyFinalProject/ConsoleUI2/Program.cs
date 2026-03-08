using Busniess.Concrete;
using DataAccess.Concrete.EntitiyFrameWork;
using Entities.Concreate;

namespace ConsoleUI1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}