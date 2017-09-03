using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class MC
    {
        public string Nummerplade { get; set; }
        public DateTime Date { get; set; }

        public int Pris()
        {
            return 120;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}
