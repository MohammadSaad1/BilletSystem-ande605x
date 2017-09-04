using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Date { get; set; }

        public abstract int Pris();

        public abstract string KøretøjType();
        
            
    }
}
