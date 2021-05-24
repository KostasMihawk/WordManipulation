﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using WordManipulation.Interfaces;
using WordManipulation.Models;
using WordManipulation.ViewModels;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace WordManipulation.BML
{
    public class DocXManager:IDocXManager
    {
        private string fontFamily = "Times new roman";        
        private Formatting Formatting = new Formatting
        {
            Spacing = 1.2,
            Size = 12            
        };
        private readonly DocXConstructor DocXConstructor;
        public DocXManager()
        {
            DocXConstructor = new DocXConstructor();
        }
        public DocX CreatePricingAndNameTable(DocX doc, Zone zone, bool isFusikoProswpo)
        {
            Table t = doc.AddTable(7, 2);

            t.SetColumnWidth(0, 350d);
            t.SetColumnWidth(1, 110d);
            t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.AntiqueWhite));
            t.Alignment = Alignment.center;


            if (isFusikoProswpo)
            {
                t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Bold().Alignment = Alignment.center;
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: " + zone.Name);
                t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Alignment = Alignment.center;
                t.Rows[1].Cells[1].Paragraphs.First().Append("");
                t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Alignment = Alignment.center;
                t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: " + zone.Value.ToString("F"));
                t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Alignment = Alignment.center;
                t.Rows[3].Cells[1].Paragraphs.First().Append("");
                t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
                t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: " + zone.Tax.ToString("F"));
                t.Rows[5].Cells[0].Paragraphs.First().Append("Μ.Ζούζουλα: 6955119261").Alignment = Alignment.center;
                t.Rows[5].Cells[1].Paragraphs.First().Append("");
                t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Alignment = Alignment.center;
                t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: " + zone.TaxedValue.ToString("F"));
            }
            else
            {
                t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Bold().Alignment = Alignment.center;
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: A");
                t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Alignment = Alignment.center;
                t.Rows[1].Cells[1].Paragraphs.First().Append("");
                t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Alignment = Alignment.center;
                t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: 35.00");
                t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Alignment = Alignment.center;
                t.Rows[3].Cells[1].Paragraphs.First().Append("");
                t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
                t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: 8.40");
                t.Rows[5].Cells[0].Paragraphs.First().Append("Μ.Ζούζουλα: 6955119261").Alignment = Alignment.center;
                t.Rows[5].Cells[1].Paragraphs.First().Append("");
                t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Alignment = Alignment.center;
                t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: 43.40");
            }



            var color = Color.AntiqueWhite;
            t.Rows[0].Cells[0].FillColor = color;
            t.Rows[0].Cells[1].FillColor = color;
            t.Rows[1].Cells[0].FillColor = color;
            t.Rows[1].Cells[1].FillColor = color;
            t.Rows[2].Cells[0].FillColor = color;
            t.Rows[2].Cells[1].FillColor = color;
            t.Rows[3].Cells[0].FillColor = color;
            t.Rows[3].Cells[1].FillColor = color;
            t.Rows[4].Cells[0].FillColor = color;
            t.Rows[4].Cells[1].FillColor = color;
            t.Rows[5].Cells[0].FillColor = color;
            t.Rows[5].Cells[1].FillColor = color;
            t.Rows[6].Cells[0].FillColor = color;
            t.Rows[6].Cells[1].FillColor = color;

            doc.InsertTable(t);
            return doc;
        }

        public DocX AddHeaderToDocument(DocX doc,string fontFamilyCustom)
        {
            string header = "ΕΚΘΕΣΗ ΕΠΙΔΟΣΗΣ";
            
            var headerFormat = new Formatting();
            headerFormat.FontFamily = new Xceed.Document.NET.Font(fontFamilyCustom??fontFamily);
            headerFormat.Size = 13D;
            headerFormat.Bold = true;
            headerFormat.UnderlineStyle = UnderlineStyle.singleLine;
            headerFormat.Spacing = 1.2;
            Paragraph headParagraph = doc.InsertParagraph("", false, headerFormat);
            headParagraph.AppendLine();
            headParagraph.AppendLine();
            Paragraph headerTextParagraph = doc.InsertParagraph(header, false, headerFormat);
            headerTextParagraph.Alignment = Alignment.both;
            headerTextParagraph.Append("                                                                            ");
            headerTextParagraph.Append("Αριθμός.............").Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(12D).Spacing(1.2).Font(fontFamily).Alignment = Alignment.right;
            headerTextParagraph.AppendLine();

            return doc;
        }

        public DocX CreateIntroParagraph(DocX doc,string location, string locationUpiresias, bool isFusikoProsopo, string epispeudon)
        {
            Paragraph introParagraph = doc.InsertParagraph("", false, Formatting);
            introParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            introParagraph.Alignment = Alignment.both;
            DocXConstructor.AddNewLine(introParagraph);
            if(isFusikoProsopo)
            {
                DocXConstructor.AddToParagraph(introParagraph, $"Στην {location} , σήμερα στις ...................................... ");
            }
            else
            {
                DocXConstructor.AddToParagraph(introParagraph, $"Στην {locationUpiresias} , σήμερα στις ...................................... ");
            }
            DocXConstructor.AddToParagraph(introParagraph, "(     ) του μηνός Μαΐου  του έτους δύο χιλιάδες είκοσι ένα (2021), ημέρα .......................................... και ώρα ........");
            DocXConstructor.AddToParagraph(introParagraph, ", εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, .........................................................................., μέλος της εταιρείας με την επωνυμία ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε., κατόπιν της έγγραφης παραγγελίας");
            DocXConstructor.AddToParagraph(introParagraph, $" {epispeudon} ,");            
            return doc;
        }

        public DocX EpispeudonParagraph(DocX doc, bool isFusikoProsopo, Gender gender, string ofeileths, string upiresia)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            GenderManager genderManager = new GenderManager();
            if (isFusikoProsopo)
            {
                DocXConstructor.AddToParagraph(paragraph, $"ήλθα για να επιδώσω προς {genderManager.EpiloghArthrouBasiGenous(gender)} {ofeileths},");                
            }
            else
            {
                DocXConstructor.AddToParagraphBoldAndUnderlinedText(paragraph, $"ήλθα για να επιδώσω {upiresia}");
            }
            return doc;
        }

        public DocX ParagraphAkrivesAdigrafo(DocX doc ,Gender gender,  string documentNumber, string sumbolaiografos, string ofeileths)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            GenderManager genderManager = new GenderManager();
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            DocXConstructor.AddToParagraph(paragraph, $"ακριβές αντίγραφο της υπ΄ αριθμόν ");
            DocXConstructor.AddToParagraphBoldText(paragraph, $" {documentNumber} ΠΡΑΞΗΣ ΔΗΛΩΣΗΣ-ΕΝΤΟΛΗΣ ΣΥΝΕΧΙΣΗΣ ΠΛΕΙΣΤΗΡΙΑΣΜΟΥ ΑΚΙΝΗΤΟΥ ΚΑΤΑ ΤΟ ΑΡΘΡΟ  973 ΤΟΥ Κ.ΠΟΛ.Δ.,");
            DocXConstructor.AddToParagraph(paragraph, $" {sumbolaiografos} κατά {genderManager.EpiloghArthrouBasiGenous(gender)} {ofeileths}, για να λάβει γνώση και για τις νόμιμες συνέπειες.");
            return doc;
        }

        public DocX CreateIntroParagraphGiaPraxiDaneistwn(DocX doc, string location, string locationUpiresias, bool isFusikoProsopo, string bailif, string notary)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            if(isFusikoProsopo)
            {
                DocXConstructor.AddToParagraph(paragraph, $"Στην {location},");
            }
            else
            {
                DocXConstructor.AddToParagraph(paragraph, $"Στην {locationUpiresias},");
            }            
            DocXConstructor.AddToParagraph(paragraph, $"σήμερα στις .................................... (      ) του μηνός Μαΐου του έτους δύο χιλιάδες είκοσι ένα (2021) , ημέρα ................................ και ώρα ........," +
                $" εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, {bailif} , μέλος της εταιρείας με την επωνυμία ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε., κατόπιν της έγγραφης παραγγελίας της συμβολαιογράφου Αθηνών {notary} " +
                $",ως επί του πλειστηριασμού υπαλλήλου," );
            return doc;
        }

        public DocX ParagrafosPraxis(DocX doc, bool isPraxi, string keimenoPraxis)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            if(isPraxi)
            {
                DocXConstructor.AddToParagraph(paragraph, keimenoPraxis);
            }
            else
            {
                DocXConstructor.AddNewLine(paragraph);
                DocXConstructor.AddNewLine(paragraph);
                DocXConstructor.AddNewLine(paragraph);
                DocXConstructor.AddNewLine(paragraph);
            }
            return doc;
        }

        public DocX ParagrafosSuntaxisEkthesis(DocX doc)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            DocXConstructor.AddToParagraph(paragraph, $"Σε πίστωση των παραπάνω συνέταξα την παρούσα έκθεση επιδόσεως σε δύο όμοια πρωτότυπα η οποία αφού διαβάστηκε και βεβαιώθηκε υπογράφεται όπως ακολουθεί.");            
            return doc;
        }

        public DocX ParagrafosUpografis(DocX doc, bool isPraxi)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            DocXConstructor.AddNewLine(paragraph);
            DocXConstructor.AddNewLine(paragraph);
            if(isPraxi)
            {
                DocXConstructor.AddToParagraph(paragraph, $".. παραλαβ......                                                                     Η  Δικαστική   Επιμελήτρια ");
            }
            else
            {
                DocXConstructor.AddToParagraph(paragraph, $".. παραλαβ..... εξουσιοδοτημεν.... Υπαλληλος                        Η  Δικαστική   Επιμελήτρια ");
            }
            return doc;
        }
        public DocX ParagrapfosProsOfeilethPraxisDaneistwn(DocX doc, Gender gender,bool isFusikoProsopo, string ofeiletis, string upiresia)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            GenderManager genderManager = new GenderManager();
            if(isFusikoProsopo)
            {
                DocXConstructor.AddToParagraph(paragraph, $"ήλθα για να επιδώσω προς {genderManager.EpilogiArthrouBasiGenousGenikiPtwsh(gender)} {ofeiletis} ");
            }
            else
            {
                DocXConstructor.AddToParagraphBoldAndUnderlinedText(paragraph, $"ήλθα για να επιδώσω {upiresia}");
            }
            return doc;
        }
        public DocX ParagrafosAkrivesAdigrafouPraxisDaneistwn(DocX doc, Gender gender, string defender,  string documentNumber, string ofeiletis,  bool isPinakas)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            GenderManager genderManager = new GenderManager();
            //DocXConstructor.AddToParagraphBoldAndUnderlinedText(paragraph, $"{defender},");
            DocXConstructor.AddToParagraph(paragraph, $"ακριβές αντίγραφο της υπ΄ αριθμόν {documentNumber} ΠΡΑΞΗΣ της ως άνω συμβολαιογράφου κατά {genderManager.EpiloghArthrouBasiGenous(gender)} " +//ΕΔΩ ΧΡΕΙΑΖΕΤΑΙ ΝΑ ΤΣΕΚΑΡΩ ΑΝ ΕΙΝΑΙ ΜΕ ΠΙΝΑΚΑ ΚΑΙ ΝΑ ΒΑΛΩ ΤΟ ΑΝΤΙΣΤΟΙΧΟ ΤΕΧΤ
                $"{ofeiletis} , για να λάβει γνώση και για τις νόμιμες συνέπειες.");
            return doc;
        }

      
        public MemoryStream EntoliSunexisisPlistiriasmou(Form form)
        {
            using (DocX doc = DocX.Create(String.Format("Zip_{0}.docx", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))))
            {
                CreatePricingAndNameTable(doc, form.Zone, form.Defender.IsFusikoProsopo);
                AddHeaderToDocument(doc, null);
                CreateIntroParagraph(doc, form.Place, form.Defender.Address, form.Defender.IsFusikoProsopo, form.Defender.Epispeudon);
                EpispeudonParagraph(doc, form.Defender.IsFusikoProsopo, form.Gender, form.DocumentType.Ofeileths, form.Defender.Text);
                ParagraphAkrivesAdigrafo(doc, form.Gender, form.DocumentType.DocumentNumber, form.Sumbolaiografos.GiaSunexisi, form.DocumentType.Ofeileths);
                ParagrafosPraxis(doc, form.Defender.Praxi, form.Defender.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, form.Defender.Praxi);
                return CreateAndReturnDocAsMemoryStream(doc);
            }
        }

        public MemoryStream PraxiPlistiriasmou(Form form)
        {
            using(DocX doc = DocX.Create(String.Format("Zip_{0}.docx", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))))
            {
                CreatePricingAndNameTable(doc, form.Zone, form.Defender.IsFusikoProsopo);
                AddHeaderToDocument(doc, null);
                CreateIntroParagraphGiaPraxiDaneistwn(doc, form.Place, form.Defender.Address, form.Defender.IsFusikoProsopo, form.Bailif.Name, form.Sumbolaiografos.Name);
                ParagrapfosProsOfeilethPraxisDaneistwn(doc, form.Gender, form.Defender.IsFusikoProsopo, form.DocumentType.Ofeileths, form.Defender.Text);
                ParagrafosAkrivesAdigrafouPraxisDaneistwn(doc, form.Gender, form.Defender.Text, form.DocumentType.DocumentNumber, form.DocumentType.Ofeileths, form.IsPinakas);
                ParagrafosPraxis(doc, form.Defender.Praxi, form.Defender.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, form.Defender.Praxi);
                return CreateAndReturnDocAsMemoryStream(doc);
            }
        }

        public MemoryStream CreateAndReturnDocAsMemoryStream(DocX doc)
        {
            var ms = new MemoryStream();
            doc.SaveAs(ms);
            ms.Position = 0;
            return ms;
        }

        
    }
}