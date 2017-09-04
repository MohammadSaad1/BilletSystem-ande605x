using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class Bil:Køretøj
    {
        public Bil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato,brobizz)
        {
        }

        public Bil():base() // kun brugt i de første unittests
        { }


        public override int Pris()
        {
            if (Brobizz) return BrobizzPris(240);
            else return 240;
        }

        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
