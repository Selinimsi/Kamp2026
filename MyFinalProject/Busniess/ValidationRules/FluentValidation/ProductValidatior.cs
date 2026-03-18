using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniess.ValidationRules.FluentValidation
{
    public class ProductValidatior:AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(p=>p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).NotNull();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p=> p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
