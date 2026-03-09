using Busniess.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concreate;
using Entities.DTOs;
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

        public List<Product> GetAllByCategoryId(int id)
        {
            return _iproductDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _iproductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _iproductDal.GetProductDetailDtos();
        }
    }
}
