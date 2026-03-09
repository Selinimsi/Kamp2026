using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfProductDal : IProductDal
    {   //IDisposable pattern implementation of c#
        public void Add(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context= new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter)!;
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter == null ?//filtre verilmiş mi
                    context.Set<Product>().ToList() : //verilmediyse bu kod
                    context.Set<Product>().Where(filter).ToList();//verildiyse bu kod çalışır
            }
        }

        public void UpDate(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var updateEntity=context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
