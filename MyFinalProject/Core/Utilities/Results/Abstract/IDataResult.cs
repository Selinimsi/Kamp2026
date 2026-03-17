using Core.Utilities.Abstract.Results;
using Core.Utilities.Conreate.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
   public interface IDataResult<T>: IResult
    {
      
        T Data { get; }

    }
}
