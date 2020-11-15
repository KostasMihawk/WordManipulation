using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WordManipulation.Models
{
    public class Form
    {
        [Display(Name = "Τοποθεσία")]
        public string Place { get; set; }
        public Baillif Bailif { get; set; } 
        public Attorney Attorneys { get; set; }
        public SelectTime SelectTime { get; set; }
        public Zone Zone { get; set; }
        public Attacker Attacker { get; set; }
        public Defender Defender { get; set; }
        public DocumentT DocumentT { get; set; }
        public DocumentType DocumentType { get; set; }
        public bool Praxh { get; set; }
    }

    public enum SelectTime
    {
        [Display(Name = "Σήμερα")]
        Today=1,
        [Display(Name = "Αύριο")]
        Tomorrow,
        [Display(Name = "Αόριστο")]
        Undefined
    }

    public enum DocumentT
    {
        [Display(Name = "Απόφαση")]
        Apofasi = 1,
        [Display(Name = "Απόφαση/Διαταγή Πληρωμής με επιταγή")]
        ApofasiMeEpitagi =2,
        [Display(Name = "Εξώδικο")]
        Exodiko = 3,
        [Display(Name = "Αγωγή Δικαστηρίου Επαρχείας")]
        AgoghEparxias=4,
        [Display(Name = "Αγωγή Αθήνας")]
        AgogiAthinas=5,
        [Display(Name = "Ανακοπή Αθήνας")]
        AnakopiAthinas=6,
        [Display(Name = "Ανακοπή Επαρχείας")]
        AnakopiEparxeias=7,
        [Display(Name = "Αίτηση Αναστολής Αθήνα")]
        AitisiAnastoliSAthina=8,
        [Display(Name = "Αίτηση Αναστολής Επαρχεία")]
        AitisiAnastolisEparxeia=9,
        [Display(Name = "Αίτηση Αναίρεσης")]
        AitisiAneresis = 10,
        [Display(Name = "Δήλωση Συνέχισης Πληστειριασμού")]
        DilwshSunexisisPlirstiasmou
        
    }
}