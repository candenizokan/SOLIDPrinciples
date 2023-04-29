using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Good.Models
{
    public class Kaleci : IGolAt, IPenaltiKurtar, IPasAt, IDefansYap
    {
        public void DefansYap()
        {
            throw new NotImplementedException();
        }

        public void GolAt()
        {
            throw new NotImplementedException();
        }

        public void PasAt()
        {
            throw new NotImplementedException();
        }

        public void PenaltiKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
