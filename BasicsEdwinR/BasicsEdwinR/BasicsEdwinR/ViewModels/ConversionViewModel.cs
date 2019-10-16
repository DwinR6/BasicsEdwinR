using BasicsEdwinR.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BasicsEdwinR.ViewModels
{
    public class ConversionViewModel
    {
        public ConversionModel conversion { get; set; }
        public Command ToDollarsCommand { get; set; }
        public Command ToEurosComand { get; set; }
        public double Dollars { get; set; }
        public double Euros { get; set; }
        public ConversionViewModel()
        {
            conversion = new ConversionModel();
            
            conversion.Dollars = Dollars;
            conversion.Euros = Euros;
            ToDollarsCommand = new Command(conversion.ToDollars);
            ToEurosComand = new Command(conversion.ToEuros);
        }
    }
}
