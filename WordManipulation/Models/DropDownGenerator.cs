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
                Pronoun = "της"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Βαρβάρας Α. Σγούρα, μέλους της Αστικής Επαγγελματικής Εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΒΑΡΒΑΡΑ ΑΝΔΡΕΑ ΣΓΟΥΡΑ-ΑΙΚΑΤΕΡΙΝΗ ΚΩΝ. ΟΙΚΟΝΟΜΟΥ» που εδρεύει στην Αθήνα, οδός Καποδιστρίου αριθμός 18, με ΑΦΜ 996910660, Δ.Ο.Υ. Α' Αθηνών",
                City = "Αθήνας",
                Pronoun = "της"
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
    }
}