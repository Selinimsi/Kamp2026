using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
