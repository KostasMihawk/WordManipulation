﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordManipulation.ViewModels;

namespace WordManipulation.Models
{
    public class SunexisiPlistiriasmouModel
    {
        public Attorney Notary { get; set; }
        public Zone Zone { get; set; }
        public string CaseNumber { get; set; }
        public string Debtor { get; set; }
        public Gender Gender { get; set; }
        public string Location { get; set; }
        public string Epispeudon { get; set; }

        //We need the following attributes to fill up the zip procedure
        public bool IsFusikoProsopo { get; set; }
        public string Address { get; set; }
        public string Upiresia { get; set; }
        public string KeimenoPraxis { get; set; }
        public bool? PraxiUpiresias { get; set; }
        public Kleisimo HasKleisimo { get; set; }
        public Signature Signature { get; set; }
    

    public SunexisiPlistiriasmouModel()
        {

        }

        public SunexisiPlistiriasmouModel(SunexisiPlistirasmouViewmodel vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            this.Notary = generator.GetNotaries().SingleOrDefault(n => n.Id == vm.Notary);
            this.Zone = generator.GetZones().SingleOrDefault(a => a.Id == vm.Zone);
            this.CaseNumber = vm.CaseNumber;
            this.Debtor = vm.Debtor;
            this.Gender = vm.Gender;
            this.Location = vm.Location;
            this.Epispeudon = vm.Epispeudon??"";
        }

        public void fillZipEntries(EkthesiEpidoshsModel zipEntry)
        {
            this.Upiresia = zipEntry.Perigrafh;
            this.IsFusikoProsopo = zipEntry.FusikoProswpo;
            this.PraxiUpiresias = zipEntry.Praxh;
            this.Address = zipEntry.Location;
            this.KeimenoPraxis = zipEntry.Kleisimo;
            this.Signature = zipEntry.Signature;
            this.HasKleisimo = zipEntry.HasKleisimo;
        }
    }
}