﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WordManipulation.Models
{
    public class DropDownGenerator
    {
        public List<Baillif> GetBaillifs()
        {
            var id = 1;
            var list = new List<Baillif>();
            list.Add(new Baillif
            {
                Id = id++,
                Name = "Παρασκευή A. Μιχοπούλου",
                City = "Αθήνα",
                AFM = "152255360"
            });
            list.Add(new Baillif
            {
                Id= id++,
                Name = "Ματούλα Ζούζουλα",
                City = "Αθήνα",
                AFM = ""
            });
            list.Add(new Baillif
            {
                Id = id++,
                Name = "..................................................................",
                City = "Αθήνα"
            });
            return list;
        }

        public List<Attorney> GetNotaries()
        {
            var id = 1;
            var list = new List<Attorney>();
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Ανδριανοπούλου Δήμητρας",
                City = "Αθήνας",
                Pronoun = "της",
                Description = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας, που εδρεύει στην οδό Ακαδημίας, αριθμός 41 με Α.Φ.Μ. 055298233, Δ.Ο.Υ. Δ' Αθηνών",
                GiaSunexisi = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας "
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "της συμβολαιογράφου ΑΘηνών Αικατερίνη Κωνσταντίνου Οικονόμου που εδρεύει στην οδό Καποδιστρίου αριθμός 18 με Α.Φ.Μ. 996910660,",
                City = "Αθήνας",
                Pronoun = "της",
                Name = "Αικατερίνη Κωνσταντίνου Οικονόμου ",
                GiaSunexisi = "της συμβολαιογράφου ΑΘηνών Αικατερίνη Κωνσταντίνου Οικονόμου "
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "Βαρβάρας Α. Σγούρα, μέλους της Αστικής Επαγγελματικής Εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΒΑΡΒΑΡΑ ΑΝΔΡΕΑ ΣΓΟΥΡΑ-ΑΙΚΑΤΕΡΙΝΗ ΚΩΝ. ΟΙΚΟΝΟΜΟΥ» που εδρεύει στην Αθήνα, οδός Καποδιστρίου αριθμός 18, με ΑΦΜ 996910660, Δ.Ο.Υ. Α' Αθηνών",
                City = "Αθήνας",
                Pronoun = "της",                
                Name = "Βαρβάρα Σγούρα",
                GiaSunexisi = "της συμβολαιογράφου Αθηνών Βαρβάρας Σγούρα, μέλους της αστικής επαγγελματικής εταιρείας με την επωνυμία “ΒΑΡΒΑΡΑ ΑΝΔΡΕΑ ΣΓΟΥΡΑ-ΑΙΚΑΤΕΡΙΝΗ ΚΩΝ. ΟΙΚΟΝΟΜΟΥ”, που εδρεύει στην Αθήνα, οδός Καποδιστρίου αρ.18, με Α.Φ.Μ. 996910660, Δ.Ο.Υ. Α΄Αθηνών"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "Βασιλικής Αθανασίου Λάγιου, που εδρεύει στην Δημοτική κοινότητα Αμαλιάδας του Δήμου Ήλιδας ( οδός Καλαβρύτων αριθμός 35 ), με Α.Φ.Μ. 047614330, Δ.Ο.Υ. Αμαλιάδας",
                City = "Αμαλιάδας",
                Pronoun = "της",
                Name = "Βασιλική Λάγιου"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "Ευσταθίας Ηλία Μπόλτση με έδρα την Αθήνα οδός Αιόλου αρ. 100, μέλους της αστικής επαγγελματικής εταιρείας με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΕΥΣΤΑΘΙΑ ΜΠΟΛΤΣΗ - ΕΛΕΝΗ ΛΑΓΙΑΝΔΡΕΟΥ», με Α.Φ.Μ. 996797996 της Δ.Ο.Υ. Α' Αθηνών ",
                City = "Αθήνας",
                Pronoun = "της",
                Name = "Ευσταθίας Ηλία Μπόλτση ",
                GiaSunexisi = "της συμβολαιογράφου Αθηνών Ευσταθίας Η. Μπόλτση, που εδρεύει στην οδό Αιόλου, αριθμός 100, μέλους της αστικής επαγγελματικής εταιρείας με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΕΥΣΤΑΘΙΑ ΜΠΟΛΤΣΗ - ΕΛΕΝΗ ΛΑΓΙΑΝΔΡΕΟΥ», με Α.Φ.Μ. 996797996 της Δ.Ο.Υ. Α' Αθηνών "
            });
            return list;
        }

        public List<Attorney> GetAttorneysList()
        {
            var id = 1;
            var list = new List<Attorney>();
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Ευαγγελίας Ξυπνητού",
                City = "Ναυπλίου",
                Pronoun = "της"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name ="Σπήλιου Σπηλιόπουλου",
                City = "Αθήνας",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Επαμεινώνδας Παπαδέας",
                City = "Αθήνα",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Μίλτος Δημητρόπουλος",
                City = "Πύργου",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Αλεξάνδρα Κβάσνιουκ",
                City = "Πύργου",
                Pronoun = "της"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Μάνος Παπαντωνάκης",
                City = "Ηρακλείου Κρήτης",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Αθανάσιος Αμπατζής",
                City = "Πάτρας",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Κρινιώ Τσάφα",
                City = "Αμαλιάδας",
                Pronoun = "της"
            });
            return list;
        }

        public List<Zone> GetZones()
        {
            var list = new List<Zone>();
            list.Add(new Zone
            {
                Id = 1,
                Name = "Α",
                Value = 35d,
                Tax = 8.40d,
                TaxedValue = 43.40d
            });
            list.Add(new Zone
            {
                Id = 2,
                Name = "Β",
                Value = 55d,
                Tax = 13.2d,
                TaxedValue = 68.2d
            });
            list.Add(new Zone
            {
                Id = 3,
                Name = "Γ",
                Value = 73d,
                Tax = 17.52d,
                TaxedValue = 90.52d
            });
            list.Add(new Zone
            {
                Id = 4,
                Name = "Δ",
                Value = 95,
                Tax = 22.8d,
                TaxedValue = 117.8d
            });
            list.Add(new Zone
            {
                Id = 5,
                Name = "Α20",
                Value = 28,
                Tax = 6.72d,
                TaxedValue = 34.72d
            });
            list.Add(new Zone
            {
                Id = 6,
                Name = "Β20",
                Value = 44d,
                Tax = 10.56d,
                TaxedValue = 54.56d
            });
            list.Add(new Zone
            {
                Id = 7,
                Name = "Γ20",
                Value = 58.4d,
                Tax = 14.02d,
                TaxedValue = 72.42d
            });
            list.Add(new Zone
            {
                Id = 8,
                Name = "Δ20",
                Value = 76d,
                Tax = 18.24d,
                TaxedValue = 94.24d
            });
            return list;
        }

        public List<Attacker> GetAttackers()
        {
            var id = 1;
            var list = new List<Attacker>();
            list.Add(new Attacker
            {
                Id = id++,
                Name = "Ιδιώτης",
                Intro = "",
                OfficialName = "",
                RandomText = "",
                Closer = ""
            });
            list.Add(new Attacker
            {
                Id = id++,
                Name = "ΑΛΦΑ ΜΠΑΝΚ",
                Intro = "της Ανώνυμης τραπεζικής εταιρείας με την επωνυμία ",
                OfficialName = " «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό " +
                               "τίτλο «ALPHA BANK A.E.»",
                RandomText = "",
                Closer = ", με Α.Φ.Μ. 094014249, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,"
            });
            list.Add(new Attacker
            {
                Id = id++,
                Name = "ΕΘΝΙΚΗ",
                Intro = "της Ανώνυμης τραπεζικής εταιρείας με την επωνυμία ",
                OfficialName = "«ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.» και τον διακριτικό " +
                "τίτλο «ΕΤΕ Α.Ε.» ",
                RandomText = null,
                Closer = "με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,"
            });
            list.Add(new Attacker
            {
                Id = id++,
                Name = "Eurobank",
                Intro = "της Ανώνυμης τραπεζικής εταιρείας με την επωνυμία ",
                OfficialName = "«EUROBANK ΤΡΑΠΕΖΑ Α.Ε.» και τον διακριτικό " +
                               "τίτλο «EUROBANK Α.Ε.» ",
                RandomText = null,
                Closer = "με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,"
            });
            list.Add(new Attacker
            {
                Id = id++,
                Name = "ΑΤΤΙΚΗ ΤΡΑΠΕΖΑ",
                Intro = "της Ανώνυμης τραπεζικής εταιρείας με την επωνυμία ",
                OfficialName = "«ΤΡΑΠΕΖΑ ΑΤΤΙΚΗΣ Α.Ε.» και τον διακριτικό " +
                               "τίτλο «ATTICA BANK Α.Ε.» ",
                RandomText = null,
                Closer = "με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,"
            });
            list.Add(new Attacker
            {
                Id = id++,
                Name = "ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ",
                Intro = "της Ανώνυμης τραπεζικής εταιρείας με την επωνυμία ",
                OfficialName = "«ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» και τον διακριτικό " +
                               "τίτλο «PIREUS BANK Α.Ε.» ",
                RandomText = null,
                Closer = "με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,"
            });
            return list;
        }

        public List<Defender> GetDefenders()
        {
            var id = 1;
            var list = new List<Defender>();
            list.Add(new Defender
            {
                Id = id++,
                Name = "Ιδιώτης",
                Text = "",
                Address = "....."
            });
            list.Add(new Defender
            {
                Id = id++,
                Name = "ΑΛΦΑ ΜΠΑΝΚ",
                Text = "Ανώνυμη Τραπεζική Εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό " +
                       "τίτλο «ALPHA BANK A.E.», με Α.Φ.Μ. 094014249, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Address = "Πανεπιστημίου 43"
            });
            list.Add(new Defender
            {
                Id = id++,
                Name = "ΕΘΝΙΚΗ",
                Text = "Ανώνυμη Τραπεζική Εταιρεία με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.» και τον διακριτικό " +
                       "τίτλο «ΕΤΕ Α.Ε.», με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Address = "Αιόλου 86"
            });
            list.Add(new Defender
            {
                Id = id++,
                Name = "EUROBANK",
                Text = "Ανώνυμη Τραπεζική Εταιρεία με την επωνυμία «EUROBANK ΤΡΑΠΕΖΑ Α.Ε.» και τον διακριτικό " +
                       "τίτλο «EUROBANK Α.Ε.», με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Address = "Πανεπιστημίου 34"
            });
            list.Add(new Defender
            {
                Id = id++,
                Name = "ΑΤΤΙΚΗ ΤΡΑΠΕΖΑ",
                Text = "Ανώνυμη Τραπεζική Εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ ΑΤΤΙΚΗΣ Α.Ε.» και τον διακριτικό " +
                       "τίτλο «ATTICA BANK Α.Ε.», με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Address = "Μαυρομιχάλη 8"
            });
            list.Add(new Defender
            {
                Id = id++,
                Name = "ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ",
                Text = "Ανώνυμη Τραπεζική Εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» και τον διακριτικό " +
                       "τίτλο «PIREUS BANK Α.Ε.», με Α.Φ.Μ. 094014201, που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Address = "Λ. Αλεξάνδρας 170"
            });
            return list;
        }



        //Praxi equals 
        public List<EkthesiEpidoshsModel> GetZipFiles()
        {
            var list = new List<EkthesiEpidoshsModel>();
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Ε.Φ.Κ.Α.",
                Perigrafh = "προς το Ν.Π.Δ.Δ. με την επωνυμία e-ΕΦΚΑ που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                Signature = Signature.paralavon,
                HasKleisimo = Kleisimo.exei,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο του άνω Ν.Π.Δ.Δ. στην έδρα του επί της οδού Αγίου Κωνσταντίνου αρ. 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτού …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. " /// <------
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Α' ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ",
                Perigrafh = "προς τη Α' Περιφερειακή Διεύθυνση ΚΕΑΟ Αττικής,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature= Signature.ypallilos,
                FusikoProswpo = false                
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Β' ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ",
                Perigrafh = "προς τη Β' Περιφερειακή Διεύθυνση ΚΕΑΟ Αττικής,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "ΚΕΑΟ ΠΕΙΡΑΙΑ",
                Perigrafh = "προς την Περιφερειακή Διεύθυνση ΚΕΑΟ Πειραιά,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ελευσίνα",
                Name = "ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ ΕΛΕΥΣΙΝΑΣ",
                Perigrafh = "προς τη Περιφερειακή Διεύθυνση ΚΕΑΟ Ελευσίνας,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "                 ",
                Name = "Δ.Ο.Υ. (Εφοριες)",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo= Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) Α Αθηνων",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Α Αθηνών,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "Δ.Ο.Υ. (Εφοριες) Ε Πειραιά",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Ε Πειραιά,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στους Αγίους Αναργύρους Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Αγίοι Ανάργυροι",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Αγίων Αναργύρων,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) ΙΓ Αθηνών",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ ΙΓ Αθηνών, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Γλυφάδα Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Γλυφάδας",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Γλυφάδας, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ηλιούπολη Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Ηλιούπολης",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Ηλιούπολης, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false                
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) Δ Αθηνών",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Δ Αθηνών, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Ιωνία Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Νεας Ιωνίας",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Νέας Ιωνίας, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Κηφισιά Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Κηφισιάς",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Κηφισιάς, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Περιστέρι Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Α Περιστερίου",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Περιστερίου, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ελευσίνα Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Ελευσίνας",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Ελευσίνας, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "Δ.Ο.Υ. (Εφοριες) Α Πειραιά",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Α Πειραιά, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "Δ.Ο.Υ. (Εφοριες) Πλοίων",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Πλοίων, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Παλλήνη Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Παλλήνης",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Παλλήνης, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) ΦΑΕ ΑΘΗΝΩΝ",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΦΑΕ Αθηνών, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Χολαργό Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Χολαργού",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ Χολαργού, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "ΤΕΛ",
                Perigrafh = "προς την Τελωνειακή Περιφέρεια Αττικής,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false   
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Άλιμο Αττικής",
                Name = "ΟΑΕΔ",
                Perigrafh = "προς τον Οργανισμό Απασχόλησης Εργατικού Δυναμικού,",
                Praxh = null,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                ZoneB = true,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω εταιρείας στην έδρα της στην οδό Εθνικής Αντιστάσεως αρ. 8 ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. "
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "ΟΛΠ",
                Perigrafh = "προς τον Οργανισμό Λιμένος Πειραιώς Α.Ε.,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω εταιρείας στην έδρα της στην οδό Ακτή Μιαούλη αρ. 10 ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. "
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ΑΑΔΕ (Υπουργος Οικονομικων)",
                Perigrafh = "προς τον κ. Διοικητή Της Ανεξάρτητης Αρχής Δημοσίων Εσόδων (Α.Α.Δ.Ε.), ως εκπρόσωπο του Ελληνικού Δημοσίου, κατοικοεδρεύοντα στην Αθήνα,",
                Praxh = null,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paredros,
                Kleisimo = "Αφού δεν βρήκα τον ίδιο στην έδρα του Νομικού Συμβουλίου του Κράτους επί της οδού Ακαδημίας & Χαρ. Τρικούπη, όπου σύμφωνα με τον Νόμο γίνονται οι επιδόσεις προς αυτόν, ούτε Διευθυντή ή συνεργάτη του, αλλά τ... εξουσιοδοτημέν... γιά την παραλαβή Πάρεδρο Ν.Σ.Κ. ............................................, επέδωσα σ΄ αυτ... το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "",
                Name = "Οφειλέτης",
                Perigrafh = "προς τον ",
                Praxh = true,
                HasKleisimo = Kleisimo.MegaloKeno,
                Signature = Signature.genericMartyras,
                FusikoProswpo = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "",
                Name = "Μπαλαντερ",
                Perigrafh = "",
                Praxh = false,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Εθνική Τράπεζα",
                Perigrafh = "προς την επισπεύδουσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «Εθνική Τράπεζα της Ελλάδος Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα με ΑΦΜ 094014201",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature= Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Αιόλου αρ.86, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });            
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Asopus",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων σύμφωνα με τις διατάξεις του Ν. 4354/2015, όπως αυτός τροποποιημένος ισχύει, της εταιρείας ειδικού σκοπού με την επωνυμία «Asopus LP», συσταθείσας σύμφωνα με το δίκαιο της πολιτείας του Delaware (Ντελαγουερ) των Ηνωμένων Πολιτειών της Αμερικής, η οποία εδρεύει στο Corporation Trust Centre, 1209 Orange Street, City Of Wilmington 1980 και εκπροσωπείται  νόμιμα, οι οποίες απαιτήσεις έχουν μεταβιβαστεί στο πλάισιο τιτλοποίησης αξιώσεων σύμφωνα με τις διατάξεις του Ν. 3156/2003, από την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αιόλου αρ. 86",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Intrum Hellas 2",
                Perigrafh = "προς την ανώνυμη  εταιρεία με την επωνυμία «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «INTRUM HELLAS 2 DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας, κτίριο 1-2, οδός Χάντιγκτον, 1ος όροφος, Τ.Κ. D04XN32(Dublin, Ireland, 1-2 Victoria Buildings, Haddington Road, 1st Floor, Eircode D04XN32), και εκπροσωπείται νόμιμα, οι οποίες απαιτήσεις έχουν μεταβιβαστεί στο πλαίσιο τιτλοποίησης αξιώσεων σύμφωνα με τις διατάξεις του Ν. 3156/2003, από την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αιόλου αρ. 86",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Attica",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων, της εταιρείας ειδικού σκοπού με την επωνυμία «ABS METEXELIXIS S.A.», η οποία εδρεύει στο Μεγάλο Δουκάτο του Λουξεμβούργου, οδός r. deBitbourg αρ. 19, L-1273 και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Ομήρου αρ. 23 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });            
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, ως διαχειρίστρια των απαιτήσεων της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, η οποία είχε καταστεί οιονεί καθολική διάδοχος των περουσιακών στοιχείων της «ΓΕΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε», ",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum sunrise",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π.»που εδρεύει στο Δήμο Αθηναίων Λεωφόρος Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα, η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «SUNRISE I NPL FINANCE DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (οδός George’s Dock ar. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum vega II",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστρια των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «VEGA II NPL FINANCE DAC»,η οποία εδρεύει στο Δουβλίνο Ιρλανδίας ( οδός George’s Dock αρ. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum vega",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστρια των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «VEGA II NPL FINANCE DAC»,η οποία εδρεύει στο Δουβλίνο Ιρλανδίας ( οδός George’s Dock αρ. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum snf",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στην Αθήνα Λεωφόρος Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα, η οποία ενεργεί επ’ ονόματι και για λογαριασμό της αλλοδαπής εταιρείας με την επωνυμία «PIREUS SNF DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας Palmerston House, 2ος όροφος, Fenian Street, Δουβλίνο 2 και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, η οποία είχε καταστεί οιονεί καθολική διάδοχος των περουσιακών στοιχείων της «ΓΕΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε», ",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });            
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum me phoenix",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal",
                Perigrafh = "προς την «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», η οποία εδρεύει στην Αθήνα, Λεωφόρος Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal GEMINI",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «GEMINI CORE SECURITISATION DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας, 1-2 Victoria Buildings, Haddington Road, Dublin 4, D04 XN32 και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal GALAXY II",
                Perigrafh = "προς την επισπεύδουσα ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «GALAXY II FUNDING DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (1-2 Victoria Buildings, Haddington Road, Dublin 4, D04 XN32) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal SYMBOL",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων και νόμιμης εκπροσώπου της εταιρείας ειδικού σκοπού με την επωνυμία «Symbol Investment NPLCo Designated Activity Company»  η οποία εδρεύει στην Ιρλανδία στη διεύθυνση 5ος όροφος. The Exchange, George’s Dock, IFSC, Dublin 1, D01 και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.» που εδρεύει στην Αθήνα, οδός Αιόλου αρ. 86 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal COSMOS",
                Perigrafh = "προς την «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», η οποία εδρεύει στην Αθήνα, Λεωφόρος Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιοότητα της ως Εταιρείας Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις, εντολοδόχου, ειδικού πληρεξουσίου, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «COSMOS SECURITISATION DESIGNATED ACTIVITY COMPANY» με έδρα το Δουβλίνο Ιρλανδίας, επί της οδού Haddington αρ. 1-2, Victoria Buildings, η οποία έχει καταστεί ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal ORION",
                Perigrafh = "προς την επισπεύδουσα ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209 - 211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων και νόμιμης εκπροσώπου της εταιρείας ειδικού σκοπού με την επωνυμία «ORION X SECURITISATION DESIGNATED ACTIVITY COMPANY», που εδρεύει στο Δουβλίνο Ιρλανδίας(1 - 2 VICTORIA BUINDINGS, HADDIGNTON ROAN, DUBLIN 4, D04, XN32) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal Poseidon",
                Perigrafh = "προς την επισπεύδουσα ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «POSEIDON FINANCIAL INVESTOR DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (Cape House, Westend Office Park, Snugborough Road, Blanchardtown, Δουβλίνο 15) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ALfa me citibank",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως καθολικής διαδόχου της ανώνυμης εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» (και ήδη μετονομασθείσας σε «ALPHA ΥΠΗΡΕΣΙΩΝ ΚΑΙ ΣΥΜΜΕΤΕΧΩΝ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»), κατόπιν διάσπασης της τελευταίας με απόσχιση του κλάδου της τραπεζικής δραστηριότητας και εισφοράς του στη νεοσυσταθείσα εταιρεία – πιστωτικό ίδρυμα, ενεργούσας για τις απαιτήσεις της ιδίας καθώς και ως ειδικής διαδόχου της «CITIBANK INTERNATIONAL PLC»,",
                Praxh = true,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Σταδίου 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ALfa",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα, με αριθμο ΓΕΜΗ 159029160000 και ΑΦΜ 996807331 υπό την ιδιότητα της ως καθολικής διαδόχου της ανώνυμης εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» (και ήδη μετονομασθείσας σε «ALPHA ΥΠΗΡΕΣΙΩΝ ΚΑΙ ΣΥΜΜΕΤΕΧΩΝ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ με αριθμο ΓΕΜΗ 223791000 και ΑΦΜ 094014249,",
                Praxh = true,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Σταδίου 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ALfa διασπαση",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK»(επωφελούμενη), η οποία εδρεύει στην Αθήνα και επί της οδού Σταδίου αρ. 40, με ΑΦΜ 996807331 όπως εκπροσωπείται νόμιμα ως καθολικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»(Διασπώμενη), κατόπιν διάσπασης τελευταίας με απόσχιση του κλάδου της τραπεζικής δραστηριότητας και εισφοράς του στη νεοσυσταθείσα εταιρεία-πιστωτικό ίδρυμα,",
                Praxh = true,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Σταδίου 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Cairo 2",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «CAIRO No 2 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Cairo 1",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «CAIRO No 1 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Cairo 3",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «CAIRO No 3 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Mexico ",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «MEXICO FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Mexico 2",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «MEXICO No 2 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue POSEIDON",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, στην οποία έχει ανατεθεί η διαχείριση των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «POSEIDON FINANCIAL INVESTOR DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (Cape House, Westend Office Park, Snugborough Road, Blanchardstown, Δουβλίνο 15) και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue EAGLE",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «EAGLE ISSUER DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός Molesworth Street 32, Δουβλίνο 2 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue ERB",
                Perigrafh = "επιδώσω προς την αναγγελθείσα ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «ERB RECOVERY DAC», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });

            return list;
        }

        public List<EkthesiEpidoshsModelKatasxetiria> GetZipFilesForKatasxetiria()
        {
            var list = new List<EkthesiEpidoshsModelKatasxetiria>();
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ»",
                KeimenoEisagoghs = "που εδρεύει στην Χαλκίδα του Δήμου Χαλκιδέων Ευβοίας, οδός Βελισσαρίου αρ. 2, με Α.Φ.Μ. 096123566, που τέθηκε σε ειδική εκκαθάριση",
                Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Όθωνος αρ. 4, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ»",
                DiakritikosTitlos = "«ΕΥΒΟΙΚΗ ΠΙΣΤΗ»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                KeimenoEisagoghs = "που εδρεύει στην Αθήνα Αττικής, οδός Σταδίου αρ. 40, με Α.Φ.Μ. 094014249",
                Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Πανεπιστημίου αρ. 43, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ»",
                DiakritikosTitlos = "«ALPHA BANK»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                KeimenoEisagoghs = "που εδρεύει στην Αθήνα Αττικής, οδός Αμερικής αρ. 4, με Α.Φ.Μ. 094014298", //TODO ΑΠΟ ΚΑΤΩ Η ΔΙΕΥΘΥΝΣΗ ΜΑΛΛΟΝ ΕΙΝΑΙ ΛΑΘΟΣ ΚΑΘΩΣ ΠΑΜΕ ΣΤΗΝ ΑΛΕΞΑΝΔΡΑΣ
                Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην Λεωφόρο Αλεξάνδρας αρ. 170, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ»",
                DiakritikosTitlos = "«ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ΤΡΑΠΕΖΑ EUROBANK ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ", //TODO ΑΥΤΗ ΜΑΛΛΟΝ ΔΕΝ ΛΕΓΕΤΑΙ ΕΤΣΙ 
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                KeimenoEisagoghs = "",
                Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Πανεπιστημίου αρ. 36, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΤΡΑΠΕΖΑ EUROBANK ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»",
                DiakritikosTitlos = "«EUROBANK ",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                KeimenoEisagoghs = "",
                Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Μαυρομιχάλη αρ. 8, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ»",
                DiakritikosTitlos = "«ATTICA BANK»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "HSBC Continental Europe Greece",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «HSBC Confidental Greece Europe ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Γαλλία και διατηρεί υποκατάστημα στην Αθήνα, όπως εκπροσωπείται νόμιμα,",
                KeimenoEisagoghs = "",
                Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Μεσογείων αρ. 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«HSBC Conntinental Greece Europe ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»",
                DiakritikosTitlos = "«HSBC Confidental Greece Europe»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ ΣΥΝΕΤΑΙΡΙΣΜΟΣ ΠΕΡΙΟΡΙΣΜΕΝΗΣ ΕΥΘΥΝΗΣ",
                Perigrafh = "προς τον τραπεζικό συνεταιρισμό με την επωνυμία «ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ ΣΥΝΕΤΑΙΡΙΣΜΟΣ ΠΕΡΙΟΡΙΣΜΕΝΗΣ ΕΥΘΥΝΗΣ», που εδρεύει στα Χανία Κρήτης και διατηρεί υποκατάστημα στην Αθήνα, όπως εκπροσωπείται νόμιμα",
                KeimenoEisagoghs = "", //TODO ΠΟΙΑ ΕΙΝΑΙ Η ΔΙΕΥΘΥΝΣΗ??
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Σταδίου αρ. 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ ΣΥΝΕΤΑΙΡΙΣΜΟΣ ΠΕΡΙΟΡΙΣΜΕΝΗΣ ΕΥΘΥΝΗΣ»",
                DiakritikosTitlos = "«ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΣΥΝ.ΠΕ.",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΣΥΝ.ΠΕ.», που εδρεύει στο Ηράκλειο Κρήτης και διατηρεί υποκατάστημα στην Αθήνα, όπως εκπροσωπείται νόμιμα",
                KeimenoEisagoghs = "",//TODO ΠΟΙΑ ΕΙΝΑΙ Η ΔΙΕΥΘΥΝΣΗ??
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της επί της οδού Όθωνος αρ. 4, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΣΥΝ.ΠΕ.»",
                DiakritikosTitlos = "«ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε., που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                KeimenoEisagoghs = "",
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της στην οδό Αιόλου αρ. 86, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.»",
                DiakritikosTitlos = "«ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "ΤΡΑΠΕΖΑ OPTIMA BANK",//TODO VIVA KAI OPTIMA EINAI B ZONH
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ OPTIMA BANK»",
                KeimenoEisagoghs = "",
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Αιγιαλείας αρ. 32, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«ΤΡΑΠΕΖΑ OPTIMA BANK»",
                DiakritikosTitlos = "«ΤΡΑΠΕΖΑ OPTIMA BANK»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.",//TODO DEN EIMASTE SIGOUROI GIA THN EPONUMIA THS
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.»",
                KeimenoEisagoghs = "",
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφόρο Καποδιστρίου αρ. 2, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.»",
                DiakritikosTitlos = "«VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            list.Add(new EkthesiEpidoshsModelKatasxetiria
            {
                Location = "Στην Αθήνα",
                Name = "UNICREDIT BANK A.G.",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «UNICREDIT BANK A.G.»",
                KeimenoEisagoghs = "",
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Ηρακλείτου αρ. 7, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                FullName = "«UNICREDIT BANK A.G.»",
                DiakritikosTitlos = "«UNICREDIT BANK A.G.»",
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon
            });
            return list;
        }

        public List<PistotikaIdrymataUpoEkkatharisi> GetBanks()
        {
            var list = new List<PistotikaIdrymataUpoEkkatharisi>();
            list.Add(new PistotikaIdrymataUpoEkkatharisi{
                Id = 1,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ",
                DiakritikosTitlos = "ΕΥΒΟΙΚΗ ΠΙΣΤΗ",
                Edra ="που εδρεύει στην Χαλκίδα του Δήμου Χαλκιδέων Ευβοίας, οδός Βελισσαρίου αρ. 2,",
                AFM = "με Α.Φ.Μ. 096123566"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 2,
                Name = "PROTON ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "PROTON BANK",
                Edra = "που εδρεύει στην Αθήνα, οδός Κατεχάκη αρ.61Α και Βρανά ,",
                AFM = "με Α.Φ.Μ. 099877056"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 3,
                Name = "T BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "T BANK",
                Edra = "που εδρεύει στην Αθήνα, οδός Βρανά αρ. 61,",
                AFM = "με Α.Φ.Μ. 094351776"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 4,
                Name = "ΑΧΑΙΚΗ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΑΝΩΝΥΜΗ ΕΠΕΝΔΥΤΙΚΗΣ ΔΙΑΜΕΣΟΛΑΒΗΣΗΣ",
                DiakritikosTitlos = "ΑΧΑΙΚΗ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ Α.Ε.Ε.Δ.",
                Edra = "που εδρεύει στην Πάτρα, οδός Μιχαλακοπούλου αρ. 66,",
                AFM = "με Α.Φ.Μ. 099235674"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 5,
                Name = "ΑΓΡΟΤΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ ΑΕ",
                DiakritikosTitlos = "ΑΓΡΟΤΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ",
                Edra = "που εδρεύει στην Αθήνα, οδός Πανεπιστημίου αρ. 23,",
                AFM = "με Α.Φ.Μ. 094326270"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 6,
                Name = "ΤΑΧΥΔΡΟΜΙΚΟ ΤΑΜΙΕΥΤΗΡΙΟ ΕΛΛΑΔΟΣ ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "ΤΑΧΥΔΡΟΜΙΚΟ ΤΑΜΙΕΥΤΗΡΙΟ",
                Edra = "που εδρεύει στην Αθήνα, οδός Κατεχάκη αρ. 61Α και Βρανά",
                AFM = "με Α.Φ.Μ. 090038000"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 7,
                Name = "FBB ΠΡΩΤΗ ΕΠΙΧΕΙΡΗΜΑΤΙΚΗ ΤΡΑΠΕΖΑΖ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "FBBank",
                Edra = "που εδρεύει Αθήνα, οδός Κατεχάκη  αρ. 61Α και Βρανα,",
                AFM = "με Α.Φ.Μ. 999931359"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 8,
                Name = "ΤΡΑΠΕΖΑ PROBANK Ανώνυμη Εταιρεία",
                DiakritikosTitlos = "PROBANK",
                Edra = "που εδρεύει στην Μοσχάτο Αττικής, οδός Πειραιώς αρ. 74,",
                AFM = "με Α.Φ.Μ. 099877019"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 9,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΩΔΕΚΑΝΗΣΟΥ ΣΥΝ.Π.Ε",
                DiakritikosTitlos = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΩΔΕΚΑΝΗΣΟΥ ΣΥΝ.Π.Ε",
                Edra = "που εδρεύει στην Ρόδο, οδός Καμείρου αρ. 76,",
                AFM = "με Α.Φ.Μ. 096237510"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 10,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.Π.Ε",
                DiakritikosTitlos = "T BANK",
                Edra = "που εδρεύει στην Χαλκίδα του Δήμου Χαλκιδέων Ευβοίας, οδός Βελισσαρίου αρ. 2,",
                AFM = "με Α.Φ.Μ. 096123566"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 11,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΥΤΙΚΗΣ ΜΑΚΕΔΟΝΙΑΣ ΣΥΝ. Π.Ε.",
                DiakritikosTitlos = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΥΤΙΚΗΣ ΜΑΚΕΔΟΝΙΑΣ ΣΥΝ. Π.Ε.",
                Edra = "που εδρεύει στην Κοζάνη, οδός Ελ. Βενιζέλου αρ. 2,",
                AFM = "με Α.Φ.Μ. 096189647"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 12,
                Name = "ΠΑΝΕΛΛΗΝΙΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "ΠΑΝΕΛΛΗΝΙΑ ΤΡΑΠΕΖΑ",
                Edra = "που εδρεύει στον Χολαργό Αττικής, Λεωφόρος Μεσογείων αρ. 290,",
                AFM = "με Α.Φ.Μ. 999984630"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 13,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΠΕΛΟΠΟΝΝΗΣΟΥ ΣΥΝ Π.Ε",
                DiakritikosTitlos = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΠΕΛΟΠΟΝΝΗΣΟΥ",
                Edra = "που εδρεύει στην Κόρινθο, οδός Αδειμάντου αρ. 41,",
                AFM = "με Α.Φ.Μ. 096158148"
            });          
            return list;
        }
    }
}