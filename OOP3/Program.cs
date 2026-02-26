using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager konutKredis = new KonutKredisi();
            ICreditManager ihtiyacKredisi = new İhtiyacKredisi();
            ICreditManager tasitKredisi = new TasitKredisi();
            ICreditManager esnafKredisi = new EsnafCredisiManager();
            ILoggerService loggerSms = new LoggerSms();
            BasvuruYapManager basvuruYapManager = new BasvuruYapManager();
            LoggerDataBase loggerDataBase = new LoggerDataBase();
            LoggerFile loggerFile = new LoggerFile();
             basvuruYapManager.BasvuruYap(esnafKredisi, loggerSms);
            List<ICreditManager> creditManagers = new List<ICreditManager>() {ihtiyacKredisi,tasitKredisi };

           // basvuruYapManager.KrediOnBilgilendirmesiYap(creditManagers);

            Console.ReadLine();
        }
    }
}
