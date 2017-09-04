using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class MC:Køretøj
    {
       
        public override int Pris()
        {
            return 120;
        }

        public override string KøretøjType()
        {
            return "MC";
        }
    }
}
