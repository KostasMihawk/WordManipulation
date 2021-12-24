using System;
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
        DateManager dateMagager;
        private Formatting Formatting = new Formatting
        {
            Spacing = 1.2,
            Size = 12            
        };
        private readonly DocXConstructor DocXConstructor;
        public DocXManager()
        {
            DocXConstructor = new DocXConstructor();
            dateMagager = new DateManager();
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
                t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: " + zone.Name).Font(fontFamily);
                t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[1].Cells[1].Paragraphs.First().Append("").Font(fontFamily);
                t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: " + zone.Value.ToString("F")).Font(fontFamily);
                t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[3].Cells[1].Paragraphs.First().Append("").Font(fontFamily);
                t.Rows[4].Cells[0].Paragraphs.First().Append("Π .Μιχοπούλου: 6986413493").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: " + zone.Tax.ToString("F")).Font(fontFamily);
                t.Rows[5].Cells[0].Paragraphs.First().Append("Μ .Ζούζουλα: 6955119261").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[5].Cells[1].Paragraphs.First().Append("").Font(fontFamily);
                t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: " + zone.TaxedValue.ToString("F")).Font(fontFamily);
            }
            else
            {
                t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Font(fontFamily).Bold().Alignment = Alignment.center;
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: A").Font(fontFamily);
                t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[1].Cells[1].Paragraphs.First().Append("").Font(fontFamily);
                t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: 35.00").Font(fontFamily);
                t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[3].Cells[1].Paragraphs.First().Append("").Font(fontFamily);
                t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: 8.40").Font(fontFamily);
                t.Rows[5].Cells[0].Paragraphs.First().Append("Μ.Ζούζουλα: 6955119261").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[5].Cells[1].Paragraphs.First().Append("").Font(fontFamily);
                t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Font(fontFamily).Alignment = Alignment.center;
                t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: 43.40").Font(fontFamily);
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
                DocXConstructor.AddToParagraph(introParagraph, $"{location} , σήμερα στις ...................................... ");
            }
            else
            {
                DocXConstructor.AddToParagraph(introParagraph, $"{locationUpiresias} , σήμερα στις ...................................... ");
            }
            DocXConstructor.AddToParagraph(introParagraph, "(     ) του μηνός " + dateMagager.GetCorrectMonthInFuckingGreek() + " του έτους δύο χιλιάδες είκοσι ένα (2021), ημέρα .......................................... και ώρα ........");
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
                DocXConstructor.AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                DocXConstructor.AddToParagraphBoldAndUnderlinedText(paragraph, $"προς {genderManager.EpilogiArthrouBasiGenousGenikiPtwsh(gender)} {ofeileths},");
            }
            else
            {
                DocXConstructor.AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                DocXConstructor.AddToParagraphBoldAndUnderlinedText(paragraph, $"{upiresia}");
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
                DocXConstructor.AddToParagraph(paragraph, $"{location}, ");
            }
            else
            {
                DocXConstructor.AddToParagraph(paragraph, $"{locationUpiresias}, ");
            }            
            DocXConstructor.AddToParagraph(paragraph, $"σήμερα στις .................................... (      ) του μηνός " + dateMagager.GetCorrectMonthInFuckingGreek() + " του έτους δύο χιλιάδες είκοσι ένα (2021), ημέρα ................................ και ώρα ........," +
                $" εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, {bailif}, μέλος της εταιρείας με την επωνυμία ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε., κατόπιν της έγγραφης παραγγελίας {notary}" +
                $", ως επί του πλειστηριασμού υπαλλήλου," );
            return doc;
        }

        public DocX ParagrafosPraxis(DocX doc, bool? isPraxi, string keimenoPraxis)
        {
           
            if(isPraxi == true)
            {
                Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
                paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                paragraph.Alignment = Alignment.both;
                DocXConstructor.AddToParagraph(paragraph, keimenoPraxis);
                if(string.IsNullOrEmpty(keimenoPraxis))
                {
                    DocXConstructor.AddNewLine(paragraph);
                    DocXConstructor.AddNewLine(paragraph);
                    DocXConstructor.AddNewLine(paragraph);
                }
                return doc;
            }
            else if(isPraxi == false)
            {
                Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
                paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                paragraph.Alignment = Alignment.both;
                DocXConstructor.AddNewLine(paragraph);
                DocXConstructor.AddNewLine(paragraph);
                DocXConstructor.AddNewLine(paragraph);
                DocXConstructor.AddNewLine(paragraph);
                return doc;
            }
            else
            {
                return doc;
            }
            
        }

        public DocX ParagrafosSuntaxisEkthesis(DocX doc)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            DocXConstructor.AddToParagraph(paragraph, $"Σε πίστωση των παραπάνω συνέταξα την παρούσα έκθεση επιδόσεως σε δύο όμοια πρωτότυπα η οποία αφού διαβάστηκε και βεβαιώθηκε υπογράφεται όπως ακολουθεί.");            
            return doc;
        }

        public DocX ParagrafosUpografis(DocX doc, bool? isPraxi)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            DocXConstructor.AddNewLine(paragraph);            
            if(isPraxi == true)
            {
                DocXConstructor.AddToParagraph(paragraph, $".. παραλαβ......                                                                     Η Δικαστική Επιμελήτρια ");
            }
            else if(isPraxi == false)
            {
                DocXConstructor.AddToParagraph(paragraph, $".. παραλαβ..... εξουσιοδοτημεν.... Υπάλληλος                        Η Δικαστική Επιμελήτρια ");
            }
            else
            {
                DocXConstructor.AddToParagraph(paragraph, $".. παραλαβ..... πάρεδρος                                            Η Δικαστική Επιμελήτρια ");
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
                DocXConstructor.AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                DocXConstructor.AddToParagraphBoldAndUnderlinedText(paragraph, $"προς {genderManager.EpilogiArthrouBasiGenousGenikiPtwsh(gender)} {ofeiletis}, ");
            }
            else
            {
                DocXConstructor.AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                DocXConstructor.AddToParagraphBoldAndUnderlinedText(paragraph, upiresia);
            }
            return doc;
        }
        public DocX ParagrafosAkrivesAdigrafouPraxisDaneistwn(DocX doc, Gender gender, string defender,  string documentNumber, string ofeiletis,  bool isPinakas)
        {
            Paragraph paragraph = doc.InsertParagraph("", false, Formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            GenderManager genderManager = new GenderManager();
            TextManager textManager = new TextManager();            
            DocXConstructor.AddToParagraph(paragraph, $"ακριβές αντίγραφο της υπ΄ αριθμόν ");
            DocXConstructor.AddToParagraphBoldText(paragraph, $"{documentNumber} ΠΡΑΞΗΣ {textManager.PraxiHPinakas(isPinakas)} ");
            DocXConstructor.AddToParagraph(paragraph, $"της ως άνω συμβολαιογράφου κατά { genderManager.EpiloghArthrouBasiGenous(gender)}{ofeiletis}, για να λάβει γνώση και για τις νόμιμες συνέπειες.");
            return doc;
        }

      
        public MemoryStream EntoliSunexisisPlistiriasmou(SunexisiPlistiriasmouModel model)
        {
            using (DocX doc = DocX.Create(String.Format("Zip_{0}.docx", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))))
            {
                CreatePricingAndNameTable(doc, model.Zone, model.IsFusikoProsopo);
                AddHeaderToDocument(doc, null);
                CreateIntroParagraph(doc, model.Location, model.Address, model.IsFusikoProsopo, model.Epispeudon);
                EpispeudonParagraph(doc, model.IsFusikoProsopo, model.Gender, model.Debtor, model.Upiresia);
                ParagraphAkrivesAdigrafo(doc, model.Gender, model.CaseNumber, model.Notary.GiaSunexisi, model.Debtor);
                ParagrafosPraxis(doc, model.PraxiUpiresias, model.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, model.PraxiUpiresias);
                return CreateAndReturnDocAsMemoryStream(doc);
            }
        }

        public MemoryStream PraxiPlistiriasmou(LoanerInvitationModel model)
        {
            using(DocX doc = DocX.Create(String.Format("Zip_{0}.docx", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))))
            {
                CreatePricingAndNameTable(doc, model.Zone, model.IsFusikoProsopo);
                AddHeaderToDocument(doc, null);
                CreateIntroParagraphGiaPraxiDaneistwn(doc,model.Location, model.Address, model.IsFusikoProsopo, model.Baillif.Name, model.Notary.Description);
                ParagrapfosProsOfeilethPraxisDaneistwn(doc, model.Gender, model.IsFusikoProsopo, model.Debtor, model.Upiresia);
                ParagrafosAkrivesAdigrafouPraxisDaneistwn(doc, model.Gender, model.Upiresia, model.CaseNumber, model.Debtor, model.IsTable);
                ParagrafosPraxis(doc, model.PraxiUpiresias, model.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, model.PraxiUpiresias);
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