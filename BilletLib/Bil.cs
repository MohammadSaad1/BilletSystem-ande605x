using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Date { get; set; }

        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
