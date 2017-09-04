using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class ØresundsBil:Køretøj
    {

        public ØresundsBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato,brobizz)
        {
            NormalPris = 410;
        }

        public ØresundsBil():base()
        {
            NormalPris = 410;

        }




        public override int Pris()
        {
            int prisMedRabat = NormalPris;

            if (Brobizz)
                prisMedRabat = 161;

            return prisMedRabat;
        }

        public override string KøretøjType()
        {
            return "Øresund Bil";
        }
    }
}
