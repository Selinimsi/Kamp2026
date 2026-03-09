using Core.DataAccess.EntityFrameWork;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {   //IDisposable pattern implementation of c#
        public List<ProductDetailDto> GetProductDetailDtos()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on
  
                             p.CategoryId equals c.CategoryId
                             select new ProductDetailDto {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                               
                             };
                return result.ToList();
            }
        }
    }
}
