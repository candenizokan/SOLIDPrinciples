using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciples.Good
{
    public class Tavuk : Kus
    {
        public override string Beslen()
        {
            return "beslendi";
        }

        public override string Yuru()
        {
            return "yurudu";
        }
    }
}
