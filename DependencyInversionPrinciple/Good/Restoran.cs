using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Good
{
    public class Restoran
    {
        //ihtiyacı olan balık ve tavuğu restoren kontructorda alayım


        private readonly IUrun _urun;
        private readonly List<IUrun> _urunler;
        public Restoran(IUrun urun)//dışarıdan geleni içerideki fieldima atıyorum. dışarıdan ihtiyacın olanı al içeri at
        {
            _urun = urun;
        }

        public Restoran(List<IUrun> urunler)//bir tanede gelse pişiririm. çokda gelse pişirim.
        {
            _urunler = urunler;
        }
    }
}
