using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciples.Bad
{
    public class Tavuk : Kus
    {
        public override string Beslen()
        {
            return "beslendi";
        }

        public override string Uc()
        {
            throw new NotImplementedException();
        }

        public override string Yuru()
        {
            return "yurudu";
        }
    }
}
