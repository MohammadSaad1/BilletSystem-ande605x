using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class MC:Køretøj
    {
        public MC(string nummerplade, DateTime dato,bool brobizz) : base(nummerplade, dato,brobizz)
        {
        }

        public MC():base() // kun brugt i de første unittests
        { }

        public override int Pris()
        {
            if (Brobizz) return BrobizzPris(120);
            else return 120;
        }

        public override string KøretøjType()
        {
            return "MC";
        }
    }
}
