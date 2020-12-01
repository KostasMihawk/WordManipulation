using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class DocumentType
    {
        public int Id { get; set; }
        public string Noun { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public string Court { get; set; }
        public string Pinakio { get; set; }
        public string Room { get; set; }
        public string Tmhma { get; set; } //oti ston poutso einai auto
        public string EidikosArithmosKatathesis { get; set; }
        public string GenikosArithmosKatathesis { get; set; }
        public string Hmeromhnia { get; set; }
        public string KataApofasis { get; set; }
        public string Katasxetirio { get; set; }
        public string EpilogosApofasis { get; set; }
        public string EpikiromenoAdigrafo { get; set; }
        public string HmeromhniaExodikou { get; set; }
        public string Dikasimos { get; set; }        
        public string Ofeileths { get; set; }
        
       
    }
}