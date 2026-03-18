using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Abstract.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//params c# da run çalışırken istediğin kadar parametre verebilmeni sağlar.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) 
                        { 
                return logic;
                        }
            }
        }
    }
}
