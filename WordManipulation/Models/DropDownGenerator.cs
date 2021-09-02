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
                Name = "Ευσταθίας Ηλία Μπόλτση "
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

        public List<BankModel> GetBanks()
        {
            var id = 1;
            var list = new List<BankModel>();
            list.Add(new BankModel
            {
                Id = id++,
                Name = "efka",
                Text = "προς το Ν.Π.Δ.Δ. με την επωνυμία e-ΕΦΚΑ που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                LegalEntity = LegalEntity.EFka,
                ZipDocumentTitle = "Ε.Φ.Κ.Α."
            });
            list.Add(new BankModel
            {
                Id = id++,
                Name = "aade",
                Text = "προς τον κ. Διοικητή Της Ανεξάρτητης Αρχής Δημοσίων Εσόδων (Α.Α.Δ.Ε.), ως εκπρόσωπο του Ελληνικού Δημοσίου, κατοικοεδρεύοντα στην Αθήνα",
                LegalEntity = LegalEntity.EllinikoDimosio,
                ZipDocumentTitle = "Α.Α.Δ.Ε."
            });
            list.Add(new BankModel
            {
                Id = id++,
                Name = "ethinkiTrapeza",
                Text = "προς την επισπεύδουσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «Εθνική Τράπεζα της Ελλάδος Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα με ΑΦΜ 094014201",
                LegalEntity = LegalEntity.Trapezes,
                ZipDocumentTitle= "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ Α.Ε."
            });
            list.Add(new BankModel
            {
                Id = id++,
                Name = "doy",
                Text = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ ",
                LegalEntity = LegalEntity.LoipesUpirisies,
                ZipDocumentTitle = "Δ.Ο.Υ."
            });
            list.Add(new BankModel
            {
                Id = id++,
                Name = "keao",
                Text = "", 
                LegalEntity = LegalEntity.LoipesUpirisies,
                ZipDocumentTitle = "Κ.Ε.Α.Ο."
            });
            list.Add(new BankModel
            {
                Id = id++,
                Name = "ofeileths",
                Text = "",
                LegalEntity = LegalEntity.FusikoProswpo,
                ZipDocumentTitle = "ΟΦΕΙΛΕΤΗΣ"
            });
            list.Add(new BankModel
            {
                Id = id++,
                Name = "intrum",
                Text = "αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, ως διαχειρίστρια των απαιτήσεων της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, η οποία είχε καταστεί οιονεί καθολική διάδοχος των περουσιακών στοιχείων της «ΓΕΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε», ",
                LegalEntity = LegalEntity.Trapezes,
                ZipDocumentTitle = "INTRUM"
            });
            list.Add(new BankModel
            {
                Id = id++,
                Name = "Empty",
                Text = "",
                LegalEntity = LegalEntity.Empty,
                ZipDocumentTitle = "Μπαλαντερ"
            });
            return list;
        }

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
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο του άνω Ν.Π.Δ.Δ. στην έδρα του επί της οδού Αγίου Κωνσταντίνου αρ. 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτού …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. " /// <------
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Α' ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ",
                Perigrafh = "προς το Α' Περιφερειακό ΚΕΑΟ Αθηνών,",
                Praxh = null,
                FusikoProswpo = false                
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Β' ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ",
                Perigrafh = "προς το Β' Περιφερειακό ΚΕΑΟ Αθηνών,",
                Praxh = null,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "ΚΕΑΟ ΠΕΙΡΑΙΑ",
                Perigrafh = "προς το ΚΕΑΟ Πειραιά,",
                Praxh = null,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ελευσίνα",
                Name = "ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ ΕΛΕΥΣΙΝΑΣ",
                Perigrafh = "προς το ΚΕΑΟ Ελευσίνας,",
                Praxh = null,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "                 ",
                Name = "Δ.Ο.Υ. (Εφοριες)",
                Perigrafh = "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ, ",
                Praxh = false,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "ΤΕΛ",
                Perigrafh = "προς την Τελωνειακή Περιφέρεια Αττικής,",
                Praxh = true,
                FusikoProswpo = false
                //Kleisimo = "Αφού δεν βρήκα στην έδρα της άνω υπηρεσίας στην οδό ………………., τον Διευθυντή αυτής, ούτε Προϊστάμενο ή συνεργάτη του, αλλά τ… εξουσιοδοτημέν.. για την παραλαβή υπάλληλο …………………………………………, όπως μου δήλωσε, επέδωσα σ΄αυτ.. το άνω δικόγραφο."

            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Περαιά",
                Name = "ΟΛΠ",
                Perigrafh = "προς τον Οργανισμό Λιμένος Πειραιώς Α.Ε.,",
                Praxh = true,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο του άνω Ν.Π.Δ.Δ. στην οδό Ακτή Μιαούλη αρ. 10 ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. "
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ΑΑΔΕ (Υπουργος Οικονομικων)",
                Perigrafh = "προς τον κ. Διοικητή Της Ανεξάρτητης Αρχής Δημοσίων Εσόδων (Α.Α.Δ.Ε.), ως εκπρόσωπο του Ελληνικού Δημοσίου, κατοικοεδρεύοντα στην Αθήνα,",
                Praxh = true,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον ίδιο στην έδρα του Νομικού Συμβουλίου του Κράτους επί της οδού Ακαδημίας & Χαρ. Τρικούπη, όπου σύμφωνα με τον Νόμο γίνονται οι επιδόσεις προς αυτόν, ούτε Διευθυντή ή συνεργάτη του, αλλά τον εξουσιοδοτημένο γιά την παραλαβή Πάρεδρο Ν.Σ.Κ. ............................................, επέδωσα σ΄ αυτόν το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "",
                Name = "Οφειλέτης",
                Perigrafh = "προς τον ",
                Praxh = true,
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
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Αιόλου αρ.86, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, ως διαχειρίστρια των απαιτήσεων της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, η οποία είχε καταστεί οιονεί καθολική διάδοχος των περουσιακών στοιχείων της «ΓΕΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε», ",
                Praxh = true,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων σύμφωνα με τις διατάξεις του Ν. 4354/2015, όπως αυτός τροποποιημένος ισχύει, της εταιρείας ειδικού σκοπού με την επωνυμία «Asopus LP», συσταθείσας σύμφωνα με το δίκαιο της πολιτείας του Delaware (Ντελαγουερ) των Ηνωμένων Πολιτειών της Αμερικής, η οποία εδρεύει στο Corporation Trust Centre, 1209 Orange Street, City Of Wilmington 1980 και εκπροσωπείται  νόμιμα, οι οποίες απαιτήσεις έχουν μεταβιβαστεί στο πλάισιο τιτλοποίησης αξιώσεων σύμφωνα με τις διατάξεις του Ν. 3156/2003, από την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αιόλου αρ. 86",
                Praxh = true,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum me phoenix",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ALfa me citibank",
                Perigrafh = "προς την αναγγελθείσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως καθολικής διαδόχου της ανώνυμης εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» (και ήδη μετονομασθείσας σε «ALPHA ΥΠΗΡΕΣΙΩΝ ΚΑΙ ΣΥΜΜΕΤΕΧΩΝ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»), κατόπιν διάσπασης της τελευταίας με απόσχιση του κλάδου της τραπεζικής δραστηριότητας και εισφοράς του στη νεοσυσταθείσα εταιρεία – πιστωτικό ίδρυμα, ενεργούσας για τις απαιτήσεις της ιδίας καθώς και ως ειδικής διαδόχου της «CITIBANK INTERNATIONAL PLC»,",
                Praxh = true,
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
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            
            return list;
        }
    }
}