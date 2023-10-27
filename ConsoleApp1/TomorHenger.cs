using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double magassag, double sugar) : base(magassag, sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            this.fajsuly = 7.87;
        }

        public TomorHenger(double magassag, double sugar, double fajsuly) : base(magassag, sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            this.fajsuly = fajsuly;
        }

        public double GetFajsuly { get => fajsuly; }
        public double Suly { get => fajsuly * Terfogat(); }

        public override string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}; fajsúly:{fajsuly}";
        }
    }
}