using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class EkthesiEpidoshsModelKatasxetiria
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public string Perigrafh { get; set; }
        public string KeimenoEisagoghs { get; set; }
        public string Kleisimo { get; set; }
        public string FullName { get; set; }
        public string DiakritikosTitlos { get; set; }
        public Kleisimo HasKleisimo { get; set; }
        public Signature Signature { get; set; }
    }
}