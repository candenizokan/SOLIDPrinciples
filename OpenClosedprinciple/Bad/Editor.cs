using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedprinciple.Bad
{
    public class Editor
    {
        public void DrawCircle()
        {

        }

        public void DrawSquare()
        {

        }

        public void DrawShape(Shape shape)
        {
            if (shape.Name=="Circle")
            {
                DrawCircle();
            }
            else if (shape.Name == "Square")
            {
                //şimdi birde kare çiz metodu yazmam lazım. kare çiz olmalıki gelen şekil kare ise kare çizmeli. bir sürü şekil var her seferinde else if diye yeni revizeler geldikçe eklemem gerekiyor. üçgen geldi diyelim yine artacak
            }

            //bizden her sınıf için çizim istendiğinde biz edtör sınıfına gelip kod yazıyoruz ki değişime kapalı yani mevcut kod bloklarınada bunu yapmadan yinede çizim yapabiliyor olmamız lazımdı.
        }

        
    }
}
