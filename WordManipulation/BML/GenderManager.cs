using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordManipulation.ViewModels;

namespace WordManipulation.BML
{
    public class GenderManager
    {
        public string EpiloghArthrouBasiGenous(Gender gender)
        {
            if (gender == Gender.Man)
                return "του ";
            else if (gender == Gender.Woman)
                return "της ";
            else
                return "της";
        }

        public string EpilogiArthrouBasiGenousGenikiPtwsh(Gender gender)
        {

            if (gender == Gender.Man)
                return "τον ";
            else if (gender == Gender.Woman)
                return "την ";
            else
                return "την";
        }

        public string EpilogiArthouOfileti(Gender gender)
        {
            if (gender == Gender.Man)
            {
                return "του οφειλέτη";
            }
            else
            {
                return "της οφειλέτιδας";
            }   
        }
    }
}