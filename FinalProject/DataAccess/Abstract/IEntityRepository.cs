using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IEntityRepository<T> where T :class,IEntity,new()//class referans tip olabilir demek 
       //entity ise class ya da referans tip olabilir demek
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void UpDate(T entity);
        void Delete(T entity);

    }
}
