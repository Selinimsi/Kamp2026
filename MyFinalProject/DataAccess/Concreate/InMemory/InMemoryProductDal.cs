using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitsInstock=20,UnitsPrice=300},
             new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitsInstock=20,UnitsPrice=30000},
              new Product{ProductId=3,CategoryId=2,ProductName="Bere",UnitsInstock=10,UnitsPrice=300},
               new Product{ProductId=4,CategoryId=2,ProductName="Swetshort",UnitsInstock=200,UnitsPrice=800},
                new Product{ProductId=5,CategoryId=2,ProductName="Pantolon",UnitsInstock=20,UnitsPrice=1500},

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategori(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();//Where içindeki şarta uyan bütün elemanları yeni bir listeye atar ve onu döndürür
        }

        public void UpDate(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInstock = product.UnitsInstock;
            productToUpdate.UnitsPrice = product.UnitsPrice;

        }
    }
}
