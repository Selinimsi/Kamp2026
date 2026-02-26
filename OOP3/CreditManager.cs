using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager// okunurluğu artırmak için I harfi ile başlatırsın.
    {//şablon görevi görür. İçine yazdığımız methot şablonları alt sınıflarda olmak zorunda olur fakat içeriği her birinde farklı olabilir.
      //intrfacelerde altında olan classların örnekleinin referansını tutabilir.
        void Hesapla();
    }
}
