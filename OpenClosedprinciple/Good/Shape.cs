using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedprinciple.Good
{
    //burada yeni çizilmesi gereken her sınıf kendinin nasıl çizileceğini biliyor ve editör ihtiyaç duyduğu nesneyi soyut katmandan istiyor.
    //bu yüzden shape abstract sınıfın kalıtım alan, yeni oluşturulan her sınıf editör tarafından editöre hiç bir kod eklemeden çizilebilir oluyor.
    // gelişime (yeni şekillere açık ama) değişime(editör sınıf kodlarının değişime kapalı) olunmuş oluyor
    public abstract class Shape
    {
        public abstract void Draw();//abstract olduğu için ezilecek neden gövdesini oluşturayım böylee kalsın.
        // abstract işaretli sınıfın içindeki abstract metod gittiği yerde zaten zileceğinde açıklaması gövdesi yoktur.
    }
}
