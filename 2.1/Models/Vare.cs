using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.Models
{
    public class Vare
    {
        public int VareNr { get; set; }
        public double Pris { get; set; }
        public double Storrelse { get; set; }
        public string VareNavn { get; set; }
        public Vare(int vareNr, double pris, double storrelse, string vareNavn)
        {
            this.VareNr = vareNr;
            this.Pris = pris;
            this.Storrelse = storrelse;
            this.VareNavn = vareNavn;
        }
    }
}
