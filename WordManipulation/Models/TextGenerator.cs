using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WordManipulation.BML;
using WordManipulation.Interfaces;

namespace WordManipulation.Models
{
    public class TextGenerator
    {
        public string GenerateValidText(Form form, DocumentT type)
        {
            Agent agent = new Agent();
            switch (type)
            {
                case DocumentT.Apofasi:
                    return
                        $" {form.DocumentType.EpikiromenoAdigrafo} {form.DocumentType.Noun} {form.DocumentType.DocumentNumber}" +
                        $" {form.DocumentType.Name} του {form.DocumentType.Court}, {form.DocumentType.EpilogosApofasis}" +
                        $" για να λάβει γνώση και για τις νόμιμες συνέπειες.";
                case DocumentT.ApofasiMeEpitagi:
                    return 
                        $" {form.DocumentType.EpikiromenoAdigrafo} {form.DocumentType.Noun} {form.DocumentType.DocumentNumber}" +
                        $" {form.DocumentType.Name} του {form.DocumentType.Court}, {form.DocumentType.EpilogosApofasis}" +
                        $" για να λάβει γνώση και για τις νόμιμες συνέπειες.";
                case DocumentT.Exodiko:
                    return $" την από {form.DocumentType.HmeromhniaExodikou} ΕΞΩΔΙΚΗ-ΔΗΛΩΣΗ-ΔΙΑΜΑΡΤΥΡΙΑ του πρώτου κατά αυτής {form.DocumentType.EpilogosApofasis}";
                case DocumentT.AgoghEparxias:
                    return $" {form.DocumentType.EpikiromenoAdigrafo} της από @{form.DocumentType.Hmeromhnia}@ " +
                           $"@ΑΓΩΓΗΣ@ της πρώτης κατά αυτής, που απευθύνεται ενώπιον του {form.DocumentType.Court} και ζητά " +
                           $"να γίνει δεκτή σε όλα της τα αιτήματα για τους λόγους που αναφέρονται σε αυτή. Στο αντίγραφο αυτό " +
                           $"περιέχονται επίσης η με αριθμό κατάθεσης δικογράφου @{form.DocumentType.DocumentNumber}@ πράξη της " +
                           $"γραμματέως του άνω Δικαστηρίου, που αποδεικνύει την κατάθεση του δικογράφου στη γραμματεία και ταυτόχρονη " +
                           $"πράξη της ίδιας γραμματέως με την οποία ορίζει χρόνο για τη συζήτησή της  {agent.CalculateDateForAgogiEparxeias(form.DocumentType.Dikasimos)} " +
                           $"και ώρα      με αύξοντα αριθμό πινακίου {form.DocumentType.Pinakio} στο ακροατήριο του {form.DocumentType.Court} " +
                           $"καλούμενη να παραστεί στη συζήτηση όταν και όπου παραπάνω ορίζεται.";
                case DocumentT.AgogiAthinas:
                    return $" {form.DocumentType.EpikiromenoAdigrafo} της από @{form.DocumentType.Hmeromhnia}@ " +
                           $"@ΑΓΩΓΗΣ@ της πρώτης κατά αυτής, που απευθύνεται ενώπιον του {form.DocumentType.Court} και ζητά " +
                           $"να γίνει δεκτή σε όλα της τα αιτήματα για τους λόγους που αναφέρονται σε αυτή. Στο αντίγραφο αυτό " +
                           $"περιέχονται επίσης η με γενικό  αριθμό κατάθεσης δικογράφου {form.DocumentType.GenikosArithmosKatathesis}" +
                           $" και ειδικό αριθμό κατάθεσης δικογράφου @{form.DocumentType.EidikosArithmosKatathesis}@ πράξη της " +
                           $"γραμματέως του άνω Δικαστηρίου, που αποδεικνύει την κατάθεση του δικογράφου στη γραμματεία και ταυτόχρονη " +
                           $"πράξη της ίδιας γραμματέως με την οποία ορίζει χρόνο για τη συζήτησή της  @{agent.CalculateDateForAgogiEparxeias(form.DocumentType.Dikasimos)} " +
                           $"και ώρα     στην αίθουσα {form.DocumentType.Room} του κτιρίου {form.DocumentType.Tmhma} με αύξοντα αριθμό πινακίου {form.DocumentType.Pinakio} στο ακροατήριο του {form.DocumentType.Court} @" +
                           $"καλούμενη να παραστεί στη συζήτηση όταν και όπου παραπάνω ορίζεται.";
                case DocumentT.AnakopiAthinas:
                    return $" {form.DocumentType.EpikiromenoAdigrafo} της από @{form.DocumentType.Hmeromhnia}@ " +
                           $"@ΑΝΑΚΟΠΗΣ@ της πρώτης κατά αυτής και κατά {form.DocumentType.DocumentNumber} που απευθύνεται ενώπιον του {form.DocumentType.Court} και ζητά " +
                           $"να γίνει δεκτή σε όλα της τα αιτήματα για τους λόγους που αναφέρονται σε αυτή. Στο αντίγραφο αυτό " +
                           $"περιέχονται επίσης η με γενικό  αριθμό κατάθεσης δικογράφου {form.DocumentType.GenikosArithmosKatathesis}" +
                           $" και ειδικό αριθμό κατάθεσης δικογράφου @{form.DocumentType.EidikosArithmosKatathesis}@ πράξη της " +
                           $"γραμματέως του άνω Δικαστηρίου, που αποδεικνύει την κατάθεση του δικογράφου στη γραμματεία και ταυτόχρονη " +
                           $"πράξη της ίδιας γραμματέως με την οποία ορίζει χρόνο για τη συζήτησή της  @{agent.CalculateDateForAgogiEparxeias(form.DocumentType.Dikasimos)} " +
                           $"και ώρα     στην αίθουσα {form.DocumentType.Room} του κτιρίου {form.DocumentType.Tmhma} με αύξοντα αριθμό πινακίου {form.DocumentType.Pinakio} στο ακροατήριο του {form.DocumentType.Court} @" +
                           $"καλούμενη να παραστεί στη συζήτηση όταν και όπου παραπάνω ορίζεται.";
                case DocumentT.AnakopiEparxeias:
                    return $" {form.DocumentType.EpikiromenoAdigrafo} της από @{form.DocumentType.Hmeromhnia}@ " +
                           $"@ΑΝΑΚΟΠΗΣ@ της πρώτης κατά αυτής και κατά {form.DocumentType.DocumentNumber} που απευθύνεται ενώπιον του {form.DocumentType.Court} και ζητά " +
                           $"να γίνει δεκτή σε όλα της τα αιτήματα για τους λόγους που αναφέρονται σε αυτή. Στο αντίγραφο αυτό " +
                           $"περιέχονται επίσης η  αριθμό κατάθεσης δικογράφου {form.DocumentType.GenikosArithmosKatathesis}" +
                           $"  πράξη της " +
                           $"γραμματέως του άνω Δικαστηρίου, που αποδεικνύει την κατάθεση του δικογράφου στη γραμματεία και ταυτόχρονη " +
                           $"πράξη της ίδιας γραμματέως με την οποία ορίζει χρόνο για τη συζήτησή της  @{agent.CalculateDateForAgogiEparxeias(form.DocumentType.Dikasimos)} " +
                           $"και ώρα     στην αίθουσα {form.DocumentType.Room} του κτιρίου {form.DocumentType.Tmhma} με αύξοντα αριθμό πινακίου {form.DocumentType.Pinakio} στο ακροατήριο του {form.DocumentType.Court} @" +
                           $"καλούμενη να παραστεί στη συζήτηση όταν και όπου παραπάνω ορίζεται.";
                case DocumentT.AitisiAnastoliSAthina:
                    return $" {form.DocumentType.EpikiromenoAdigrafo} της από @{form.DocumentType.Hmeromhnia}@ " +
                           $"@ΑΙΤΗΣΗ ΑΝΑΣΤΟΛΗΣ@ της πρώτης κατά αυτής για την αναστολή {form.DocumentType.DocumentNumber} που απευθύνεται ενώπιον του {form.DocumentType.Court} και ζητά " +
                           $"να γίνει δεκτή σε όλα της τα αιτήματα για τους λόγους που αναφέρονται σε αυτή. Στο αντίγραφο αυτό " +
                           $"περιέχονται επίσης η με γενικό αριθμό κατάθεσης δικογράφου {form.DocumentType.GenikosArithmosKatathesis}" +
                           $" και ειδικό αριθμό κατάθεσης δικογράφου @{form.DocumentType.EidikosArithmosKatathesis}@ πράξη της " +
                           $"γραμματέως του άνω Δικαστηρίου, που αποδεικνύει την κατάθεση του δικογράφου στη γραμματεία και ταυτόχρονη " +
                           $"πράξη της ίδιας γραμματέως με την οποία ορίζει χρόνο για τη συζήτησή της  @{agent.CalculateDateForAgogiEparxeias(form.DocumentType.Dikasimos)} " +
                           $"και ώρα     στην αίθουσα {form.DocumentType.Room} του κτιρίου {form.DocumentType.Tmhma} με αύξοντα αριθμό πινακίου {form.DocumentType.Pinakio} στο ακροατήριο του {form.DocumentType.Court} @" +
                           $"καλούμενη να παραστεί στη συζήτηση όταν και όπου παραπάνω ορίζεται.";
                case DocumentT.AitisiAnastolisEparxeia:
                    return $" {form.DocumentType.EpikiromenoAdigrafo} της από @{form.DocumentType.Hmeromhnia}@ " +
                           $"@ΑΙΤΗΣΗ ΑΝΑΣΤΟΛΗΣ@ της πρώτης κατά αυτής για την αναστολή {form.DocumentType.DocumentNumber} που απευθύνεται ενώπιον του {form.DocumentType.Court} και ζητά " +
                           $"να γίνει δεκτή σε όλα της τα αιτήματα για τους λόγους που αναφέρονται σε αυτή. Στο αντίγραφο αυτό " +
                           $"περιέχονται επίσης η αριθμό κατάθεσης δικογράφου {form.DocumentType.GenikosArithmosKatathesis}" +
                           $"  πράξη της " +
                           $"γραμματέως του άνω Δικαστηρίου, που αποδεικνύει την κατάθεση του δικογράφου στη γραμματεία και ταυτόχρονη " +
                           $"πράξη της ίδιας γραμματέως με την οποία ορίζει χρόνο για τη συζήτησή της  @{agent.CalculateDateForAgogiEparxeias(form.DocumentType.Dikasimos)} " +
                           $"και ώρα     στην αίθουσα {form.DocumentType.Room} του κτιρίου {form.DocumentType.Tmhma} με αύξοντα αριθμό πινακίου {form.DocumentType.Pinakio} στο ακροατήριο του {form.DocumentType.Court} @" +
                           $"καλούμενη να παραστεί στη συζήτηση όταν και όπου παραπάνω ορίζεται.";
                case DocumentT.AitisiAneresis:
                    return $"";
                case DocumentT.DilwshSunexisisPlirstiasmou:
                    return $" {form.DocumentType.EpikiromenoAdigrafo} {form.DocumentType.Noun} {form.DocumentType.DocumentNumber}" +
                        $" {form.DocumentType.Name} του {form.DocumentType.Sumbolaiografos} κατά του οφειλέτη {form.DocumentType.Ofeileths}" +
                        $" για να λάβει γνώση και για τις νόμιμες συνέπειες."; ;
                case DocumentT.Anaggelia:
                         return $" την από {form.DocumentType.HmeromhniaExodikou} ΑΝΑΓΓΕΛΙΑ του πρώτου κατά αυτής {form.DocumentType.EpilogosApofasis}";
                default:
                    return "";
            }
        }
    }
}