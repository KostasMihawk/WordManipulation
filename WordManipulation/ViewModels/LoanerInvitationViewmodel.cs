﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WordManipulation.ViewModels
{
    public class LoanerInvitationViewmodel
    {
        [Display(Name = "Τοποθεσία")]
        public string Location  { get; set; }
        [Display(Name = "Συμβολαιογράφος")]
        public int Notary { get; set; }
        [Display(Name = "Επιμελητής")]
        public int Baillif { get; set; }
        [Display(Name = "Ζώνη")]
        public int Zone { get; set; }
        [Display(Name = "Πράξη")]
        public bool FinishText { get; set; }
        [Display(Name = "Αριθμός")]
        public string CaseNumber { get; set; }
        [Display(Name = "Οφειλέτης")]
        public string Debtor { get; set; }
        [Display(Name = "Γένος")]
        public Gender Gender { get; set; }
        [Display(Name = "ΚΕΑΟ")]
        public KEAO KEAO { get; set; }
        [Display(Name = "Χωρίς Τράπεζα")]
        public bool IsBank { get; set; }
        [Display(Name = "Με Πίνακα")]
        public bool IsTable { get; set; }
    }
}