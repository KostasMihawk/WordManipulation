using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class BankModel
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public LegalEntity LegalEntity { get; set; }
        public string ZipDocumentTitle { get; set; }
    }
}