using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.BML
{
    public class TextManager
    {
        public string PraxiHPinakas(bool isPinakas)
        {
            return isPinakas?"(ΠΙΝΑΚΑΣ ΚΑΤΑΤΑΞΗΣ - ΠΡΟΣΚΛΗΣΗ ΔΑΝΕΙΣΤΩΝ)": "(ΠΡΟΣΚΛΗΣΗΣ ΔΑΝΕΙΣΤΩΝ)";
        }
    }
}