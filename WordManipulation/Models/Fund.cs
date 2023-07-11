using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class Fund
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MAEDAP { get; set; }
        public string MAEDAPAdress { get; set; }
    }
}