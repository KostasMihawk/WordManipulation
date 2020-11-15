using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class AutoCreate
    {
        public AutoCreate()
        {
            Upiresies = new List<string> 
            {
                "ΟΡΓΑΝΙΣΜΟΣ ΛΙΜΕΝΟΣ ΠΕΙΡΑΙΩΣ",
                "e-ΕΦΚΑ",
                "ΤΕΛΩΝΕΙΑΚΗ ΠΕΡΙΦΕΡΕΙΑ ΑΤΤΙΚΗΣ (ΤΕΛ)",
                "Ε.Φ.Κ.Α. ΠΕΡΙΦΕΡΕΙΑΚΟ ΤΑΜΕΙΟ ΑΘΗΝΩΝ",
                "ΓΡΑΜΜΑΤΕΙΑ ΕΙΡΗΝΟΔΙΚΕΙΟΥ ",
                "Δ.Ο.Υ.",
                "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε."
            };
        }
        [Display(Name = "Αριθμος υπόθεσης")]
        public string CaseNumber { get; set; }
        [Display(Name = "Συμβολαιογράφος")]
        public string Symbolaiografos { get; set; }

        public List<string> Upiresies { get; set; }
        [Display(Name = "ΚΕΑΟ")]
        public string Keao { get; set; }
        [Display(Name = "Ειρηνοδικείο")]
        public string Eirinodikeio { get; set; }
        [Display(Name = "Εφορία")]
        public string Doy { get; set; }
        public string Bailif { get; set; }
        public SelectTime SelectTime { get; set; }

    }
}