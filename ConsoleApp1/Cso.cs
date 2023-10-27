using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Cso : Henger
    {
        double falVastagsag;

        public Cso(double magassag, double sugar) : base(magassag, sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            falVastagsag = 1;
        }

        public Cso(double magassag, double sugar, double falVastagsag) : base(magassag, sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            this.falVastagsag = falVastagsag;
        }



        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat()
        {
            double belsoSugar = sugar - falVastagsag;
            return Math.Round(Math.PI * magassag * belsoSugar, 2);
        }


        public override string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}; falvastagság:{falVastagsag}";
        }
    }
}