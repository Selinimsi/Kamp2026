using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    class SepetManager
    {
        public void Add(Urun urun)
        {
            Console.WriteLine("Sepete eklendi :" + urun.ProductName);
        }
    }
}
