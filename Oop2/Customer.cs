using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    public class Customer
    {   //miras almada ebebeyin sınıf alt sınıfların adresini tutabilir.
        //base sınıflar refeerans tutucu sınıflardır.
        //bir nesnenin bir özelliği ona ait gibi durmuyorsa soyutlama hatası vardır.
        public int Id { get; set; }
        public int CustomerId { get; set; }
    }
}
