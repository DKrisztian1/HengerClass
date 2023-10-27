using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Henger
    {
        protected double magassag;
        protected double sugar;
        static int szuletesSzamlalo;

        
        public Henger(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo += 1;
        }

        public double Magassag { get => magassag; }
        public double Sugar { get => sugar; }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public virtual double Terfogat()
        {
            return Math.Round(sugar * sugar * Math.PI * magassag, 2);
        }

        public virtual string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}";
        }
    }

}