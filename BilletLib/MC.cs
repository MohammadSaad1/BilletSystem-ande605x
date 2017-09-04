using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class MC:Køretøj
    {
        public MC(string nummerplade, DateTime dato,bool brobizz) : base(nummerplade, dato,brobizz)
        {
            NormalPris = 120;
        }

        public MC():base() // kun brugt i de første unittests
        {
            NormalPris = 120;
        }

        public override int Pris()
        {
            if (Brobizz) return BrobizzPris(NormalPris);
            else return NormalPris;
        }

        public override string KøretøjType()
        {
            return "MC";
        }
    }
}
