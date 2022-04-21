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

        public string ArthroSunexisisPlistiriasmou(bool Article)
        {
            return Article ? "966" : "973";
        }
    }
}