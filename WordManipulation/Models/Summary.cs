using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Formatting = Xceed.Document.NET.Formatting;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using WordManipulation.BML;
using WordManipulation.Interfaces;
using Font = System.Drawing.Font;
using WordManipulation.ViewModels;

namespace WordManipulation.Models
{
    public class Summary
    {
        
        public void CreateWordDocument(Form form)
        {
            ITranslator translator = new Translator();
            DayCalculator calc = new DayCalculator();
            TextGenerator textGenerator = new TextGenerator();
            Agent agent = new Agent();            
            string fileName = @"C:\Users\kwsmi\Desktop\εξώδικο";
            var doc = DocX.Create(fileName);


            #region TableCreate

            Table t = doc.AddTable(7, 2);

            t.SetColumnWidth(0,320d);
            t.SetColumnWidth(1,110d);
            t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none,BorderSize.one,0,Color.AntiqueWhite));
            t.Alignment = Alignment.center;
            

            t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Bold().Alignment = Alignment.center;
            t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: " + form.Zone.Name);
            t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Alignment = Alignment.center;
            t.Rows[1].Cells[1].Paragraphs.First().Append("");
            t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Alignment = Alignment.center;
            t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: "+ form.Zone.Value.ToString("F"));
            t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ-ΦΑΧ: 210 3300 294").Alignment = Alignment.center;
            t.Rows[3].Cells[1].Paragraphs.First().Append("");
            t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
            t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: "+form.Zone.Tax.ToString("F"));
            t.Rows[5].Cells[0].Paragraphs.First().Append("Ζούζουλα Ματούλα: 6955119261").Alignment = Alignment.center;
            t.Rows[5].Cells[1].Paragraphs.First().Append("");
            t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Alignment = Alignment.center;
            t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: "+form.Zone.TaxedValue.ToString("F"));

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
            #endregion

            #region Header
            string header = "ΕΚΘΕΣΗ ΕΠΙΔΟΣΗΣ";
            string fontFamily = "Times new roman";
            var headerFormat = new Formatting();
            headerFormat.FontFamily = new Xceed.Document.NET.Font("Times new roman");
            headerFormat.Size = 12D;
            headerFormat.Bold = true;
            headerFormat.UnderlineStyle = UnderlineStyle.singleLine;
            headerFormat.Spacing = 1.2;
            Paragraph headParagraph = doc.InsertParagraph("", false, headerFormat);
            headParagraph.AppendLine();
            headParagraph.AppendLine();
            Paragraph headerTextParagraph = doc.InsertParagraph(header, false, headerFormat);
            headerTextParagraph.Append("                                                                                 ");
            headerTextParagraph.Append("Αριθμός.............").Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(12D).Spacing(1.2).Font(fontFamily).Alignment = Alignment.right;

            #endregion

            #region MainBody
            var firstParagraphFormat = new Formatting();
            double fontsize = 12;
            firstParagraphFormat.Spacing = 1.2;
            Paragraph firstParagraph = doc.InsertParagraph("",false, firstParagraphFormat);
            firstParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            firstParagraph.Alignment = Alignment.both;
            firstParagraph.AppendLine();
            firstParagraph.Append("Στ " + form.Place +", σήμερα " + translator.TranslateDayOfMonth(calc.CalculateDesiredDay(form.SelectTime)) + " (" + calc.CalculateDesiredDayString(form.SelectTime)).FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(") του μηνός " + translator.ConvertMonth(calc.CalculateDesiredMonth(form.SelectTime))).FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(" του έτους " + calc.CalculateDesiredYear(form.SelectTime) + " ,ημέρα "+ translator.ConvertNameOfDay(calc.CalculateDaysName(form.SelectTime))+" και ώρα (     )").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(" ,εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(form.Bailif.Name+ " με Α.Φ.Μ.: " + form.Bailif.AFM + ", μέλος της εταιρείας με την επωνυμία ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε., ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append("κατόπιν της έγγραφης παραγγελίας "+form.Attorneys.Pronoun+" δικηγόρου "+form.Attorneys.City +" ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(form.Attorneys.Name).UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(", πληρεξούσιου  ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(form.Attacker.Intro).FontSize(fontsize).Font(fontFamily); 
            firstParagraph.Append(form.Attacker.OfficialName).Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontsize).Font(fontFamily); 
            firstParagraph.Append(form.Attacker.RandomText).FontSize(fontsize).Font(fontFamily); 
            firstParagraph.Append(form.Attacker.Closer).FontSize(fontsize).Font(fontFamily);

            Paragraph secondParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
            secondParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            secondParagraph.Alignment = Alignment.both;
            secondParagraph.Append("ήλθα για να επιδώσω προς την ").FontSize(fontsize).Font(fontFamily);
            secondParagraph.Append(form.Defender.Text).Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontsize).Font(fontFamily);
            agent.BoldText(secondParagraph,fontFamily,fontsize, textGenerator.GenerateValidText(form, form.DocumentT));
            
            Paragraph thirdParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
            thirdParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            thirdParagraph.Alignment = Alignment.both;
            if (form.Praxh)
            {
                
                thirdParagraph.Append("Και αφού δεν βρήκα τον νόμιμο εκπρόσωπο της  άνω  τραπεζικής εταιρίας στα γραφεία της στην οδό " + form.Defender.Address + ", ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλό της ……………………..…………….………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω έγγραφο.").FontSize(fontsize).Font(fontFamily);
                
            }
            else
            {
                thirdParagraph.AppendLine();
                thirdParagraph.AppendLine();
                thirdParagraph.AppendLine();
                thirdParagraph.AppendLine();
            }

            Paragraph forthParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
            forthParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            forthParagraph.Alignment = Alignment.both;
            forthParagraph.AppendLine("Σε πίστωση των παραπάνω συνέταξα την παρούσα έκθεση επιδόσεως σε δύο όμοια πρωτότυπα η οποία αφού διαβάστηκε και βεβαιώθηκε υπογράφεται όπως ακολουθεί.").FontSize(fontsize).Font(fontFamily);
            forthParagraph.AppendLine();
            forthParagraph.AppendLine();
            forthParagraph.AppendLine(".. παραλαβ...... ");
            if(!form.Praxh)
                forthParagraph.Append(" εξουσιοδοτημεν.... Υπαλληλος");
            forthParagraph.Append("                                ");
            forthParagraph.Append("Η  Δικαστική   Επιμελήτρια").FontSize(fontsize).Font(fontFamily);
           

            #endregion

            doc.SaveAs(fileName);
            //Process.Start("WINWORD.EXE", fileName);
        }

        public void CreateSunexisiPlistiriasmou(Form form)
        {
            ITranslator translator = new Translator();
            DayCalculator calc = new DayCalculator();
            TextGenerator textGenerator = new TextGenerator();
            Agent agent = new Agent();
            string fileName = @"C:\Users\kwsmi\Desktop\εξώδικο";
            var doc = DocX.Create(fileName);


            #region TableCreate

            Table t = doc.AddTable(7, 2);

            t.SetColumnWidth(0, 320d);
            t.SetColumnWidth(1, 110d);
            t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.AntiqueWhite));
            t.Alignment = Alignment.center;


            t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Bold().Alignment = Alignment.center;
            t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: " + form.Zone.Name);
            t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Alignment = Alignment.center;
            t.Rows[1].Cells[1].Paragraphs.First().Append("");
            t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Alignment = Alignment.center;
            t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: " + form.Zone.Value.ToString("F"));
            t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ-ΦΑΧ: 210 3300 294").Alignment = Alignment.center;
            t.Rows[3].Cells[1].Paragraphs.First().Append("");
            t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
            t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: " + form.Zone.Tax.ToString("F"));
            t.Rows[5].Cells[0].Paragraphs.First().Append("Ζούζουλα Ματούλα: 6955119261").Alignment = Alignment.center;
            t.Rows[5].Cells[1].Paragraphs.First().Append("");
            t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Alignment = Alignment.center;
            t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: " + form.Zone.TaxedValue.ToString("F"));

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
            #endregion

            #region Header
            string header = "ΕΚΘΕΣΗ ΕΠΙΔΟΣΗΣ";
            string fontFamily = "Times new roman";
            var headerFormat = new Formatting();
            headerFormat.FontFamily = new Xceed.Document.NET.Font("Times new roman");
            headerFormat.Size = 12D;
            headerFormat.Bold = true;
            headerFormat.UnderlineStyle = UnderlineStyle.singleLine;
            headerFormat.Spacing = 1.2;
            Paragraph headParagraph = doc.InsertParagraph("", false, headerFormat);
            headParagraph.AppendLine();
            headParagraph.AppendLine();
            Paragraph headerTextParagraph = doc.InsertParagraph(header, false, headerFormat);
            headerTextParagraph.Append("                                                                                 ");
            headerTextParagraph.Append("Αριθμός.............").Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(12D).Spacing(1.2).Font(fontFamily).Alignment = Alignment.right;

            #endregion

            #region MainBody
            var firstParagraphFormat = new Formatting();
            double fontsize = 12;
            firstParagraphFormat.Spacing = 1.2;
            Paragraph firstParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
            firstParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            firstParagraph.Alignment = Alignment.both;
            firstParagraph.AppendLine();
            firstParagraph.Append("Στ " + form.Place + ", σήμερα " + translator.TranslateDayOfMonth(calc.CalculateDesiredDay(form.SelectTime)) + " (" + calc.CalculateDesiredDayString(form.SelectTime)).FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(") του μηνός " + translator.ConvertMonth(calc.CalculateDesiredMonth(form.SelectTime))).FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(" του έτους " + calc.CalculateDesiredYear(form.SelectTime) + " ,ημέρα " + translator.ConvertNameOfDay(calc.CalculateDaysName(form.SelectTime)) + " και ώρα (     )").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(" ,εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(form.Bailif.Name + " με Α.Φ.Μ.: " + form.Bailif.AFM + ", μέλος της εταιρείας με την επωνυμία ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε., ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append("κατόπιν της έγγραφης παραγγελίας της συμβολαιογράφου Αθηνών ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(form.DocumentType.Sumbolaiografos).UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontsize).Font(fontFamily);



            Paragraph secondParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
            secondParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            secondParagraph.Alignment = Alignment.both;
            secondParagraph.Append("ήλθα για να επιδώσω προς την ").FontSize(fontsize).Font(fontFamily);
            secondParagraph.Append(form.Defender.Text).Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontsize).Font(fontFamily);


            Paragraph thirdParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
            thirdParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            thirdParagraph.Alignment = Alignment.both;
            if (form.Praxh)
            {

                thirdParagraph.Append("Και αφού δεν βρήκα τον νόμιμο εκπρόσωπο της  άνω  τραπεζικής εταιρίας στα γραφεία της στην οδό " + form.Defender.Address + ", ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλό της ……………………..…………….………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω έγγραφο.").FontSize(fontsize).Font(fontFamily);

            }
            else
            {
                thirdParagraph.AppendLine();
                thirdParagraph.AppendLine();
                thirdParagraph.AppendLine();
                thirdParagraph.AppendLine();
            }

            Paragraph forthParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
            forthParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            forthParagraph.Alignment = Alignment.both;
            forthParagraph.AppendLine("Σε πίστωση των παραπάνω συνέταξα την παρούσα έκθεση επιδόσεως σε δύο όμοια πρωτότυπα η οποία αφού διαβάστηκε και βεβαιώθηκε υπογράφεται όπως ακολουθεί.").FontSize(fontsize).Font(fontFamily);
            forthParagraph.AppendLine();
            forthParagraph.AppendLine();
            forthParagraph.AppendLine(".. παραλαβ...... ");
            if (!form.Praxh)
                forthParagraph.Append(" εξουσιοδοτημεν.... Υπαλληλος");
            forthParagraph.Append("                                ");
            forthParagraph.Append("Η  Δικαστική   Επιμελήτρια").FontSize(fontsize).Font(fontFamily);

            #endregion

            doc.SaveAs(fileName);
        }
    }
}