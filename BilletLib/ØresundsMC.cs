using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class ØresundsMC:Køretøj
    {

        public ØresundsMC(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato,brobizz)
        {
            NormalPris = 210;
        }

        public ØresundsMC():base()
        {
            NormalPris = 210;

        }




        public override int Pris()
        {
            int prisMedRabat = NormalPris;

            if (Brobizz)
                prisMedRabat = 73;

            return prisMedRabat;
        }

        public override string KøretøjType()
        {
            return "Øresund MC";
        }
    }
}
