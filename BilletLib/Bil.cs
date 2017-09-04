using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class Bil:Køretøj
    {

        public Bil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato,brobizz)
        {
            NormalPris = 240;
        }

        public Bil():base() // kun brugt i de første unittests
        {
            NormalPris = 240;

        }








        public override int Pris()
        {
            int prisMedRabat = NormalPris;

            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
                prisMedRabat = prisMedRabat * 80 / 100;

            if (Brobizz)
                prisMedRabat = BrobizzPris(prisMedRabat);

            return prisMedRabat;
        }

        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
