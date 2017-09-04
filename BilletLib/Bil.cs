using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class Bil:Køretøj
    {
       

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
