﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Bad
{
    internal class Forvet : IFutbolcu
    {
        public void DefansYap()
        {
            //kod blok
        }

        public void GolAt()
        {
            //kod blok
        }

        public void PasAt()
        {
            //kod blok
        }

        public void PenaltiKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
