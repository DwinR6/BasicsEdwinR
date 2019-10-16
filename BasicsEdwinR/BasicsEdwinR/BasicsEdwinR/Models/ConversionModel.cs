using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsEdwinR.Models
{
    public class ConversionModel
    {
        private double _Dollars;

        public double Dollars
        {
            get { return _Dollars; }
            set { _Dollars = value; }
        }

        private double _Euros;

        public double Euros
        {
            get { return _Euros; }
            set { _Euros = value; }
        }


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
