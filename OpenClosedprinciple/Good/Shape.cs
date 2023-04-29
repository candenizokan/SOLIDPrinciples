using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedprinciple.Good
{
    public abstract class Shape
    {
        public abstract void Draw();//abstract olduğu için ezilecek neden gövdesini oluşturayım böylee kalsın.
        // abstract işaretli sınıfın içindeki abstract metod gittiği yerde zaten zileceğinde açıklaması gövdesi yoktur.
    }
}
