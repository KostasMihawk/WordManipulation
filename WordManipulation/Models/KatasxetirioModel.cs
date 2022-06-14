using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordManipulation.ViewModels;

namespace WordManipulation.Models
{
    public class KatasxetirioModel
    {
        public string Location { get; set; }
        public Zone Zone { get; set; }
        public PistotikaIdrymataUpoEkkatharisi PistotikaIdrymataUpoEkkatharisi { get; set; }
        public bool Praxi { get; set; }
        public string Date { get; set; }
        public bool Eurobank { get; set; }
        public bool AlhpaBank { get; set; }
        public bool Ethniki { get; set; }
        public bool Peiraios { get; set; }
        public bool Attica { get; set; }
        public bool HSBC { get; set; }
        public bool Chanion { get; set; }
        public bool Pagkritia { get; set; }
        public bool AnagastikiEktelesh { get; set; }
        public string KeimenoEisagoghs { get; set; }
        public string FullName { get; set; }
        public string DiakritikosTitlos { get; set; }
        
        //We need the following attributes to fill up the zip procedure

        public bool IsFusikoProsopo { get; set; }
        public string Address { get; set; }
        public string Upiresia { get; set; }
        public string KeimenoPraxis { get; set; }
        public bool? PraxiUpiresias { get; set; }
        public Kleisimo HasKleisimo { get; set; }
        public Signature Signature { get; set; }
        public bool ZoneB { get; set; }

        public KatasxetirioModel()
        {
           
        }
        public KatasxetirioModel(KatasxetirioViewModel vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            this.Zone = generator.GetZones().SingleOrDefault(z => z.Id == vm.Zone);
            this.PistotikaIdrymataUpoEkkatharisi = generator.GetBanks().SingleOrDefault(b => b.Id == vm.PistotikaIdrymataUpoEkkatharisi);
            this.Date = vm.Date;
            this.Location = vm.Location;
            this.AnagastikiEktelesh = vm.AnagastikiEktelesh;
            this.Eurobank = vm.Eurobank;
            this.Praxi = vm.Praxi;
            this.Attica = vm.Attica;
            this.Chanion = vm.Chanion;
            this.AlhpaBank = vm.AlphaBank;
            this.Ethniki = vm.Ethniki;
            this.Peiraios = vm.Peiraios;
            this.HSBC = vm.HSBC;
            this.Pagkritia = vm.Pagkritia;
          
        }

        public void fillZipEntries(EkthesiEpidoshsModelKatasxetiria zipEntry)
        {
            this.Upiresia = zipEntry.Perigrafh;            
            this.Address = zipEntry.Location;
            this.KeimenoPraxis = zipEntry.Kleisimo;
            this.Signature = zipEntry.Signature;
            this.HasKleisimo = zipEntry.HasKleisimo;
            this.FullName = zipEntry.FullName;
            this.DiakritikosTitlos = zipEntry.DiakritikosTitlos;
            this.KeimenoEisagoghs = zipEntry.KeimenoEisagoghs;
            this.Location = zipEntry.Location;
            
            
        }
    }
}