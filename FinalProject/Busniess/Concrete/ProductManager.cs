using Busniess.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniess.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iproductDal;

        public ProductManager(IProductDal iproductDal)
        {
            _iproductDal = iproductDal;
        }

        public List<Product> GetAll()
        {//iş kodları
            
            
            return _iproductDal.GetAll();
        }
    }
}
