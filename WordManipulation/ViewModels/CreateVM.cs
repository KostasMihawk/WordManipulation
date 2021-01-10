using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordManipulation.Models;

namespace WordManipulation.ViewModels
{
    public class CreateVM
    {
        [Display(Name = "Τοποθεσία")]
        public string Place { get; set; }
        [Display(Name = "Επιμελητής")]
        public int Baillif { get; set; }
        [Display(Name = "Δικηγόρος")]
        public int Attorney { get; set; }
        [Display(Name = "Ημέρα Επίδοσης")]
        public SelectTime SelectTime { get; set; }
        [Display(Name = "Ζώνη")]
        public int Zone { get; set; }
        [Display(Name = "Ενάγων")]
        public int Attacker { get; set; }
        [Display(Name = "Είδος Εγγράφου")]
        public DocumentT DocumentEnum { get; set; }
        [Display(Name = "Εναγόμενος")]
        public int Defender { get; set; }
        [Display(Name = "Αριθμός")]
        public string DocumentNumber { get; set; }
        [Display(Name = "Δικαστήριο")]
        public string Court { get; set; }
        [Display(Name = "Πινάκιο")]
        public string Pinakio { get; set; }
        [Display(Name = "Δικάσιμος")]
        public string Dikasimos { get; set; }
        [Display(Name = "Ημερομηνία Εξώδικου")]
        public string HmeromhniaExodikou { get; set; }
        [Display(Name = "Πράξη")]
        public bool Praxh { get; set; }
        [Display(Name = "Ημερομηνία")]
        public string Hmeromhnia { get; set; }
        [Display(Name = "Αίθουσα")]
        public string Room { get; set; }
        [Display(Name = "Κτίριο")]
        public string Tmhma { get; set; }
        [Display(Name = "Γενικός Αριθμός")]
        public string GenikosArithmos { get; set; }
        [Display(Name = "Ειδικός Αριθμός")]
        public string EidikosArithmos { get; set; }
        [Display(Name = "Συμβολαιογράφος")]
        public int Sumbolaiografos { get; set; }
        [Display(Name = "Οφειλέτης")]
        public string Ofeileths { get; set; }
        [Display(Name = "Γένος")]
        public Gender Gender { get; set; }
        [Display(Name = "ΚΕΑΟ")]
        public KEAO KEAO { get; set; }
        [Display(Name ="Με Πίνακα")]
        public bool IsPinakas { get; set; }
        [Display(Name = "Χωρίς Τράπεζα")]
        public bool IsBankEmpty { get; set; }
    }

    public enum Gender
    {
        [Display(Name = "Ανδρας")]
        Man,
        [Display(Name = "Γυναίκα")]
        Woman
    }

    public enum KEAO
    {
        [Display(Name = "Α Αθήνας")]
        AAthina,
        [Display(Name = "Β Αθήνας")]
        BAthina,
        [Display(Name = "Πειραιά")]
        Peireas,
        [Display(Name = "Ελευσίνας")]
        Eleusina
    }

}