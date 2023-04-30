using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Bad
{
    public class Restoran
    {
        Balik balik = new Balik();

        public void YemekHazirla()
        {
            balik.Pisir();
        }
    }
}
