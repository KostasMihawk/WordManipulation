﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WordManipulation.ViewModels
{
    public class AnaggeliaViewmodel
    {
        [Display(Name = "Τοποθεσία")]
        public string Location { get; set; }
        [Display(Name = "Συμβολαιογράφος")]
        public int Attorney { get; set; }
        [Display(Name = "Ζώνη")]
        public int Zone { get; set; }        
        [Display(Name = "Οφειλέτης")]
        public string Debtor { get; set; }
        [Display(Name = "Γένος")]
        public Gender Gender { get; set; }
        [Display(Name = "Επισπεύδων (Φυσικό Πρόσωπο)")]
        public string Epispeudon { get; set; }
    }
}