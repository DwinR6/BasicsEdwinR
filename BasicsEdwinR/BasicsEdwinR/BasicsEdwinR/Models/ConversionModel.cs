using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsEdwinR.Models
{
    public class ConversionModel
    {
        public double Dollars { get; set; }
        public double Euros { get; set; }

        public void ToDollars()
        {
            Dollars = Math.Round(Euros * 1.16, 2);
        }
        public void ToEuros()
        {
            Euros = Math.Round(Dollars / 1.16, 2);
        }
    }
}
