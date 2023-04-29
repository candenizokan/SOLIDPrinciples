using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Bad
{
    public interface IFutbolcu
    {
        void GolAt();
        void PenaltiKurtar();
        void PasAt();
        void DefansYap();

    }
}
