﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class Defender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Address { get; set; }
        public LegalEntity legalEntity { get; set; }
        public bool IsFusikoProsopo { get; set; }
        public bool? Praxi { get; set; }
        public string Epispeudon { get; set; }
        public string KeimenoPraxis { get; set; }
    }

    public enum LegalEntity
    {
         EllinikoDimosio,
         EFka,
         LoipesUpirisies,
         Olp,
         Tel,
         Trapezes, 
         Dimos,
         FusikoProswpo,
         Empty
    }
}