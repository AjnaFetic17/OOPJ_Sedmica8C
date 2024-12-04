using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1Operatori
{
    internal class BrojMinus
    {
        public int MinusBroj { get; set; }
        public BrojMinus(int broj)
        {
            MinusBroj = broj;
        }

        public static BrojMinus operator -(BrojMinus brojMinus)
        {
            return new BrojMinus(-brojMinus.MinusBroj);
        }

        public override string ToString()
        {
            return $"{MinusBroj}";
        }
    }
}
