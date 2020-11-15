using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordManipulation.Interfaces
{
    interface ITranslator
    {
        string ConvertMonth(int month);
        string TranslateDayOfMonth(int day);
        string ConvertNameOfDay(int day);
    }
}
