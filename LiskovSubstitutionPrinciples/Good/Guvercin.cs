using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciples.Good
{
    public class Guvercin : Kus, IUc
    {
        public override string Beslen()
        {
            return "beslendi";
        }

        public string Uc()
        {
            return "uctu";
        }

        public override string Yuru()
        {
            return "yurudu";
        }
    }
}
