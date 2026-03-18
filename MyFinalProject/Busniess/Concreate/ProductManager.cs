using Busniess.Abstract;
using Busniess.Concreate;
using Busniess.ValidationRules.FluentValidation;
using Core.Utilities.Abstract.Results;
using Core.Utilities.Conreate.Result;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concreate;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concreate;
using Entities.DTOs;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcers.Validation;
using Core.Aspects.Autofac.Validation;

namespace Busniess.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iproductDal;

        public ProductManager(IProductDal iproductDal)
        {
            _iproductDal = iproductDal;
        }
        [ValidationAspect(typeof(ProductValidatior))]
        public IResult Add(Product product)
        {
            
            _iproductDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _iproductDal.Delete(product);
            return new Result(true, "ürün silindi");
        }

        public IDataResult<List<Product>> GetAll()
        {//iş kodları
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintananceTime);
                   
            }

            return new SuccessDataResult<List<Product>>(_iproductDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_iproductDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>( _iproductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_iproductDal.Get(p=>p.ProductId == productId));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_iproductDal.GetProductDetailDtos());
        }

        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
