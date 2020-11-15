using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class Attacker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Intro { get; set; }
        public string OfficialName { get; set; }
        public string RandomText { get; set; }
        public string Closer { get; set; }
    }
}