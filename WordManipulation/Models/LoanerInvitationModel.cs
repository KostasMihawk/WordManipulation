using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordManipulation.ViewModels;

namespace WordManipulation.Models
{
    public class LoanerInvitationModel
    {
        public Baillif Baillif { get; set; }
        public Attorney Notary { get; set; }
        public Zone Zone { get; set; }
        public int CaseNumber { get; set; }
        public string Debtor { get; set; }
        public Gender Gender { get; set; }
        public string Location { get; set; }
        public string Praxh { get; set; }
        public KEAO KEAO { get; set; }
        public bool IsTable { get; set; }
        public bool IsBank { get; set; }
        public bool? IsFusikoProsopo { get; set; }
        public string Address { get; set; }
        public string Upiresia { get; set; }
        public string KeimenoPraxis { get; set; }

    }
}