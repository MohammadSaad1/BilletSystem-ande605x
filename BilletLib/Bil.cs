using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class Bil:Køretøj
    {
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        public Bil():base()
        { }


        public override int Pris()
        {
            
            return 240;
        }

        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
