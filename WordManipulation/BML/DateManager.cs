using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.BML
{
    public class DateManager
    {
        public string GetCorrectMonthInFuckingGreek()
        {
            switch(DateTime.Now.Month)
            {
                case 1:
                    return "Ιανουαρίου";
                case 2:
                    return "Φεβρουαρίου";
                case 3:
                    return "Μαρτίου";
                case 4:
                    return "Απριλίου";
                case 5:
                    return "Μαϊου";
                case 6:
                    return "Ιουνίου";
                case 7:
                    return "Ιουλίου";
                case 8:
                    return "Αυγούστου";
                case 9:
                    return "Σεπτεμβρίου";
                case 10:
                    return "Οκτωβρίου";
                case 11:
                    return "Νοεμβρίου";
                case 12:
                    return "Δεκεμβρίου";
                default:
                        return "";
            }


        }
    }
}