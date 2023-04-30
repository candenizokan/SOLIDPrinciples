using DependencyInversionPrinciple.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             DependencyInversion => bağımlılıkların tersine çevrilmesi prensibi.
            Bağlılık ile bağımlılık aynı şey değildir. Oluşturacağınız sınıflar tabiki birbiri ile çalışacaktır fakat aralarında bu ilişki loosely coupled(gevşek bağlılık olarakta geçer) seviyesinde kalmalı yani bir sınıf net bir şekilde ben o sınıfın bir elemanı olmadan bu işi yapamam dememelidr.(tight coupled - sıkı bağlılık olmamalı)

            Bu prensip yüksek seviyeli sınıfların (high level class), alt seviyeli sınıflara(low level class) bağımlı olmaması gerektiğini ve böyle bir durum varsa araya soyut bir katman ekleyerek (abstract bir sınıf yada bir interface olabilir) ihtiyaç duyan(yani yüksek seviye sınıf ile) ihtiyaç duyulan(yani düşük seviye sınıf) arasına eklenen soyut katman iki yapıylada konuşturulmalı. ihtiyaç duyulan soyut katmandan getirilmeli ve ihtiyaç duyanda apaçık o sınıfı istemek yerine soyut katmandan gelen x biri ile çalışılabilir hale getirilmelidir.

            SOLID in Dependency Inversion ilkesinin içlerinde en dikkatli davranması gereken olduğu söylenebilir. Bu yüzden bu prensibin uygulama şekli DI(Dependency Injecktion) uygulamaları vardır.

            3 tip DI uygulama şekli vardır => Constructor Injecktion(ihtiyaç duyulan Constructor enjeksiyonla verilir)
                                              Setter Injecktion (ihtiyaç duyulan tip propertye set edilir)
                                              Method Injecktion (ihtiyaç duyulan metod aracılığı ile içerideki fielda/prop doldurulur)

            DIP sağlaması için DI uygulamalarından herhangi biri tercih edilebilir.
             
             */

            Balik balik = new Balik();
            Balik balik1 = new Balik();

            Tavuk tavuk = new Tavuk();


            List<IUrun> talepler = new List<IUrun> { balik,balik1,tavuk};
            Restoran restoran = new Restoran(talepler);
            
        }
    }
}
