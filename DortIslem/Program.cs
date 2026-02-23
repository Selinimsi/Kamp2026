using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            Console.WriteLine(dortIslem.Sum(5, 6));
            Console.ReadLine();
        }
    }
}
