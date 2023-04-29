using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Good.Models
{
    public class Forvet : IPasAt, IDefansYap, IGolAt
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
    }
}
