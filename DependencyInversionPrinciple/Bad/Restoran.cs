using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Bad
{
    public class Restoran//yüksek seviyeli sınıf ihtiyaç duyan
    {
        Balik balik = new Balik();
        Tavuk tavuk = new Tavuk();//ihtiyaç duyulan düşük seviyeli

        public void YemekHazirla()
        {
            balik.Pisir();
            tavuk.Pisir();
        }
    }
}
