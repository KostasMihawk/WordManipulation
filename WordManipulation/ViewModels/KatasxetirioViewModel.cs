using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WordManipulation.ViewModels
{
    public class KatasxetirioViewModel
    {
        [Display(Name = "Τοποθεσία")]
        public string Location { get; set; }   
        [Display(Name = "Ζώνη")]
        public int Zone { get; set; }
        [Display(Name = "Πράξη")]
        public bool Praxi { get; set;}
        [Display(Name = "Ημερομηνία")]
        public string Date { get; set; }
        [Display(Name = "Eurobank")]
        public bool Eurobank { get; set; }
        [Display(Name = "Alpha Bank")]
        public bool AlphaBank { get; set; }
        [Display(Name = "Εθνική Τράπεζα")]
        public bool Ethniki { get; set; }
        [Display(Name = "Τράπεζα Πειραιώς")]
        public bool Peiraios { get; set; }
        [Display(Name = "Attica")]
        public bool Attica { get; set; }
        [Display(Name = "ΧΑ ΣΕ ΜΠΕ")]
        public bool HSBC { get; set; }
        [Display(Name = "Τράπεζα Χανίων")]
        public bool Chanion { get; set; }
        [Display(Name = "Παγκρήτια")]
        public bool Pagkritia { get; set; }
        [Display(Name = "Αναγκαστική Εκτέλεση")]
        public bool AnagastikiEktelesh { get; set; }



    }
}