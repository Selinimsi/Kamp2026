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
            if (CheckIfProductCountOfCategoryCorrect(product.CategoryId).Success){
                if (CheckIfProductNameExists(product.ProductName).Success)
                {
                    _iproductDal.Add(product);
                    return new SuccessResult(Messages.ProductAdded);
                }
                   
            }
           return new ErrorResult();
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
        [ValidationAspect(typeof(ProductValidatior))]
        public IResult Update(Product product)
        {
            if (CheckIfProductCountOfCategoryCorrect(product.CategoryId).Success)
            {
                _iproductDal.UpDate(product);
                return new SuccessResult(Messages.ProductUpdated);
            }
            return new ErrorResult();
        }

        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId )
        {
            var result=_iproductDal.GetAll(p=>p.CategoryId==categoryId).Count;
            if (result >= 10) {
                return new ErrorResult(Messages.ErrorOfCategoryCount);
            }
            return new SuccessResult();
        }

        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _iproductDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
