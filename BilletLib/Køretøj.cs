using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public bool Brobizz { get; set; }



        // Metoder
        public abstract int Pris();

        public abstract string KøretøjType();





        public int BrobizzPris(int prisUdenRabat)
        {
            return prisUdenRabat*95/100;
        }





        //Ctor's
        public Køretøj()  // kun brugt i de første unittests
        { }


        public Køretøj(string nummerplade, DateTime dato, bool brobizz)
        {
            if (nummerplade.Length > 7)
                throw new ArgumentException("Nummerplade har for mange karakterer");

            this.Nummerplade = nummerplade;
            this.Dato = dato;
            this.Brobizz = brobizz;
            

        }
        
            
    }
}
