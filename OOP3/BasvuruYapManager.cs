using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruYapManager
    { 
        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Hesapla();
            }
        }
    }
}
