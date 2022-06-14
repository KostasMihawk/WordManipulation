﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class EkthesiEpidoshsModel
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public string Perigrafh { get; set; }
        public bool? Praxh { get; set; }
        public bool FusikoProswpo { get; set; }
        public string Kleisimo { get; set; }
        public Kleisimo HasKleisimo { get; set; }
        public Signature Signature { get; set; }
        public bool ZoneB { get; set; }
    }

    public enum Signature
    {
        paredros,
        ypallilos,
        paralavon,
        genericMartyras
    }
     public enum Kleisimo
    {
        exei,
        denExei,
        MegaloKeno
    }
}