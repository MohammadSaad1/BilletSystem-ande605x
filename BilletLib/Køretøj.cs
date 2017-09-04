using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public abstract int Pris();

        public abstract string KøretøjType();



        public Køretøj()
        { }


        public Køretøj(string nummerplade, DateTime dato)
        {
            if (nummerplade.Length > 7)
                throw new ArgumentException("Nummerplade har for mange karakterer");

            this.Nummerplade = nummerplade;
            this.Dato = dato;


        }
        
            
    }
}
