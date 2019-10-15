using BasicsEdwinR.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BasicsEdwinR.ViewModels
{
    public class ConversionViewModel
    {
        ConversionModel conversion;
        Command ToDollarsCommand;
        Command ToEurosComand;
        public ConversionViewModel()
        {
            conversion = new ConversionModel();
            ToDollarsCommand = new Command(conversion.ToDollars);
            ToEurosComand = new Command(conversion.ToEuros);
        }
    }
}
