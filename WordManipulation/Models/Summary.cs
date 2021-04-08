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
using System.Web.Mvc;

namespace WordManipulation.Models
{
    public class Summary
    {

        public string CreateWordDocument(Form form)
        {
            ITranslator translator = new Translator();
            DayCalculator calc = new DayCalculator();
            TextGenerator textGenerator = new TextGenerator();
            Agent agent = new Agent();
            string fileName = @"C:\ektheseis\kanonikes\" + Directory.GetFiles(@"C:\ektheseis\kanonikes\", " * ", SearchOption.TopDirectoryOnly).Length + "-" + DateTime.Today.ToString("dd.MM.yyyy") + ".docx";
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
            t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Alignment = Alignment.center;
            t.Rows[3].Cells[1].Paragraphs.First().Append("");
            t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
            t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: " + form.Zone.Tax.ToString("F"));
            t.Rows[5].Cells[0].Paragraphs.First().Append("Μ.Ζούζουλα: 6955119261").Alignment = Alignment.center;
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
            firstParagraph.Append("Στ             , σήμερα                  (   )");
            firstParagraph.Append(" του μηνός " + translator.ConvertMonth(calc.CalculateDesiredMonth(form.SelectTime))).FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(" του έτους δύο χιλιάδες είκοσι " + calc.CalculateDesiredYear(form.SelectTime) + " ,ημέρα " + translator.ConvertNameOfDay(calc.CalculateDaysName(form.SelectTime)) + " και ώρα ........").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(" ,εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append(form.Bailif.Name + " με Α.Φ.Μ.: " + form.Bailif.AFM + ", μέλος της εταιρείας με την επωνυμία ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε., ").FontSize(fontsize).Font(fontFamily);
            firstParagraph.Append("κατόπιν της έγγραφης παραγγελίας " + form.Attorneys.Pronoun + " δικηγόρου " + form.Attorneys.City + " ").FontSize(fontsize).Font(fontFamily);
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
            secondParagraph.Append(form.Defender.Text).FontSize(fontsize).Font(fontFamily);/*.Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontsize).Font(fontFamily);*/
            agent.BoldText(secondParagraph, fontFamily, fontsize, textGenerator.GenerateValidText(form, form.DocumentT));

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
            return fileName;
        }

        public MemoryStream CreateSunexisiPlistiriasmou(Form form)
        {
            var r = new Random();
            ITranslator translator = new Translator();
            DayCalculator calc = new DayCalculator();
            TextGenerator textGenerator = new TextGenerator();
            Agent agent = new Agent();
            //string fileName = @"C:\ektheseis\kanonikes\" + r.Next(1, 100000) + "-" + DateTime.Today.ToString("dd.MM.yyyy") + ".docx";

            //string fileName = r.Next(1, 100000).ToString() + ".docx";  



            using (DocX doc = DocX.Create(String.Format("Zip_{0}.docx", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))))
            {

                #region TableCreate

                Table t = doc.AddTable(7, 2);

                t.SetColumnWidth(0, 350d);
                t.SetColumnWidth(1, 110d);
                t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.AntiqueWhite));
                t.Alignment = Alignment.center;


                if(form.Defender.legalEntity == LegalEntity.FusikoProswpo)
                {
                    t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Bold().Alignment = Alignment.center;
                    t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: " + form.Zone.Name);
                    t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Alignment = Alignment.center;
                    t.Rows[1].Cells[1].Paragraphs.First().Append("");
                    t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Alignment = Alignment.center;
                    t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: " + form.Zone.Value.ToString("F"));
                    t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Alignment = Alignment.center;
                    t.Rows[3].Cells[1].Paragraphs.First().Append("");
                    t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
                    t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: " + form.Zone.Tax.ToString("F"));
                    t.Rows[5].Cells[0].Paragraphs.First().Append("Μ.Ζούζουλα: 6955119261").Alignment = Alignment.center;
                    t.Rows[5].Cells[1].Paragraphs.First().Append("");
                    t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Alignment = Alignment.center;
                    t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: " + form.Zone.TaxedValue.ToString("F"));
                }
                else
                {
                    t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Bold().Alignment = Alignment.center;
                    t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: A");
                    t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Alignment = Alignment.center;
                    t.Rows[1].Cells[1].Paragraphs.First().Append("");
                    t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Alignment = Alignment.center;
                    t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: 35.00") ;
                    t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Alignment = Alignment.center;
                    t.Rows[3].Cells[1].Paragraphs.First().Append("");
                    t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
                    t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: 8.40" );
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
                #endregion

                #region Header
                string header = "ΕΚΘΕΣΗ ΕΠΙΔΟΣΗΣ";
                string fontFamily = "Times new roman";
                var headerFormat = new Formatting();
                headerFormat.FontFamily = new Xceed.Document.NET.Font("Times new roman");
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

                #endregion

                #region MainBody
                var firstParagraphFormat = new Formatting();
                double fontsize = 12;
                firstParagraphFormat.Spacing = 1.2;
                Paragraph firstParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
                firstParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                firstParagraph.Alignment = Alignment.both;
                firstParagraph.AppendLine();
                firstParagraph.Append("Στ ...................... " + form.Place + " σήμερα στις .......................... ").FontSize(fontsize).Font(fontFamily);
                firstParagraph.Append("(   ) του μηνός Απριλίου").FontSize(fontsize).Font(fontFamily);
                firstParagraph.Append(" του έτους δύο χιλιάδες είκοσι ένα (" + calc.CalculateDesiredYear(form.SelectTime) + "), ημέρα ........................." + translator.ConvertNameOfDay(calc.CalculateDaysName(form.SelectTime)) + " και ώρα ........").FontSize(fontsize).Font(fontFamily);
                firstParagraph.Append(",εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, ").FontSize(fontsize).Font(fontFamily);
                firstParagraph.Append(form.Bailif.Name +  ", μέλος της εταιρείας με την επωνυμία ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε., ").FontSize(fontsize).Font(fontFamily);
                //" με Α.Φ.Μ.: " + form.Bailif.AFM +
                firstParagraph.Append("κατόπιν της έγγραφης παραγγελίας της συμβολαιογράφου Αθηνών ").FontSize(fontsize).Font(fontFamily);
                firstParagraph.Append(form.Sumbolaiografos.Name + " , ως επί του πλειστηριασμού υπαλλήλου, ").FontSize(fontsize).Font(fontFamily);
                //που εδρεύει στην Αθήνα, οδός Σκουφά 77, με Α.Φ.Μ. 055298233


                Paragraph secondParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
                secondParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                secondParagraph.Alignment = Alignment.both;

                if (form.Defender.Text == " ")
                {
                    secondParagraph.Append("ήλθα για να επιδώσω προς " + EpiloghGenousPanw(form.Gender) + form.DocumentType.Ofeileths).FontSize(fontsize).Font(fontFamily).Alignment = Alignment.left;
                    secondParagraph.AppendLine();
                    secondParagraph.AppendLine();
                    secondParagraph.AppendLine();
                }
                else
                {
                    secondParagraph.Append("ήλθα για να επιδώσω ").FontSize(fontsize).Font(fontFamily);
                }



                secondParagraph.Append(form.Defender.Text).Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontsize).Font(fontFamily);
                secondParagraph.Append(" ακριβές αντίγραφο της υπ΄ αριθμόν ").FontSize(fontsize).Font(fontFamily);
                secondParagraph.Append(form.DocumentType.DocumentNumber + " ΠΡΑΞΗΣ " + isPinakas(form.IsPinakas) + " ").Bold().FontSize(fontsize).Font(fontFamily);
                secondParagraph.Append("της ως άνω συμβολαιογράφου κατά " + EpiloghGenousKatw(form.Gender) + EpiloghGenousOfeileti(form.Gender) + DisplayEpwnumiaEtaireias(form.Gender) + form.DocumentType.Ofeileths + IsBankEmpty(form.IsBankEmpty) + ", για να λάβει γνώση και για τις νόμιμες συνέπειες.").FontSize(fontsize).Font(fontFamily);

                Paragraph thirdParagraph = doc.InsertParagraph("", false, firstParagraphFormat);
                thirdParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                thirdParagraph.Alignment = Alignment.both;
                if (form.Praxh)
                {

                    //thirdParagraph.Append("Και αφού δεν βρήκα τον νόμιμο εκπρόσωπο τ..  στα γραφεία τ.. στην οδό .........................................., ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλό της ……………………..…………….………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω έγγραφο.").FontSize(fontsize).Font(fontFamily);
                    thirdParagraph.Append(KeimenoPraxis(form.Defender.legalEntity)).FontSize(fontsize).Font(fontFamily);

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
                forthParagraph.Append("Σε πίστωση των παραπάνω συνέταξα την παρούσα έκθεση επιδόσεως σε δύο όμοια πρωτότυπα η οποία αφού διαβάστηκε και βεβαιώθηκε υπογράφεται όπως ακολουθεί.").FontSize(fontsize).Font(fontFamily);
                forthParagraph.AppendLine();
                forthParagraph.AppendLine();
                forthParagraph.AppendLine(".. παραλαβ...... ").Font(fontFamily);
                if (!form.Praxh)
                    forthParagraph.Append(" εξουσιοδοτημεν.... Υπαλληλος").Font(fontFamily);
                forthParagraph.Append("                                                                        ");
                forthParagraph.Append("Η  Δικαστική   Επιμελήτρια").FontSize(fontsize).Font(fontFamily);

                #endregion


                var ms = new MemoryStream();
                doc.SaveAs(ms);
                ms.Position = 0;
               
                return ms;
            }
            
        }



        //public string CreateLoanerContinuation(Form form, BankModel bm, string debtor)
        //{
        //    var r = new Random();
        //    ITranslator translator = new Translator();
        //    DayCalculator calc = new DayCalculator();
        //    TextGenerator textGenerator = new TextGenerator();
        //    Agent agent = new Agent();
        //    string fileName = string.Empty;
        //    if (!string.IsNullOrEmpty(debtor))
        //    {
        //        fileName = @"C:\ektheseis\kanonikes\" +bm.Name + ".docx";
        //    }
        //    else
        //    {
        //        fileName = @"C:\ektheseis\kanonikes\" + r.Next(1, 100000) + "-" + DateTime.Today.ToString("dd.MM.yyyy") + ".docx";            }

        //    var doc = DocX.Create(fileName);

        //     #region TableCreate

        //    Table t = doc.AddTable(7, 2);

        //    t.SetColumnWidth(0, 350d);
        //    t.SetColumnWidth(1, 110d);
        //    t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.AntiqueWhite));
        //    t.Alignment = Alignment.center;


        //    t.Rows[0].Cells[0].Paragraphs.First().Append("ΜΙΧΟΠΟΥΛΟΥ ΠΑΡΑΣΚΕΥΗ - ΖΟΥΖΟΥΛΑ ΜΑΤΟΥΛΑ Α.Ε.Ε.Δ.Ε.").Bold().Alignment = Alignment.center;
        //    t.Rows[0].Cells[1].Paragraphs.First().Append("Ζώνη: " + form.Zone.Name);
        //    t.Rows[1].Cells[0].Paragraphs.First().Append("Έδρα: Νικηταρά αρ. 8-10 - Αθήνα 10678").Alignment = Alignment.center;
        //    t.Rows[1].Cells[1].Paragraphs.First().Append("");
        //    t.Rows[2].Cells[0].Paragraphs.First().Append("Α.Φ.Μ.: 996910057 - Δ.Ο.Υ. Α' Αθηνών").Alignment = Alignment.center;
        //    t.Rows[2].Cells[1].Paragraphs.First().Append("ΑΜΟΙΒΗ: " + form.Zone.Value.ToString("F"));
        //    t.Rows[3].Cells[0].Paragraphs.First().Append("ΤΗΛ: 210 3300 294").Alignment = Alignment.center;
        //    t.Rows[3].Cells[1].Paragraphs.First().Append("");
        //    t.Rows[4].Cells[0].Paragraphs.First().Append("Π.Μιχοπούλου: 6986413493").Alignment = Alignment.center;
        //    t.Rows[4].Cells[1].Paragraphs.First().Append("ΦΠΑ 24%: " + form.Zone.Tax.ToString("F"));
        //    t.Rows[5].Cells[0].Paragraphs.First().Append("Μ.Ζούζουλα: 6955119261").Alignment = Alignment.center;
        //    t.Rows[5].Cells[1].Paragraphs.First().Append("");
        //    t.Rows[6].Cells[0].Paragraphs.First().Append("email: odee.pmz@gmail.com").Alignment = Alignment.center;
        //    t.Rows[6].Cells[1].Paragraphs.First().Append("ΣΥΝΟΛΟ: " + form.Zone.TaxedValue.ToString("F"));

        //    var color = Color.AntiqueWhite;
        //    t.Rows[0].Cells[0].FillColor = color;
        //    t.Rows[0].Cells[1].FillColor = color;
        //    t.Rows[1].Cells[0].FillColor = color;
        //    t.Rows[1].Cells[1].FillColor = color;
        //    t.Rows[2].Cells[0].FillColor = color;
        //    t.Rows[2].Cells[1].FillColor = color;
        //    t.Rows[3].Cells[0].FillColor = color;
        //    t.Rows[3].Cells[1].FillColor = color;
        //    t.Rows[4].Cells[0].FillColor = color;
        //    t.Rows[4].Cells[1].FillColor = color;
        //    t.Rows[5].Cells[0].FillColor = color;
        //    t.Rows[5].Cells[1].FillColor = color;
        //    t.Rows[6].Cells[0].FillColor = color;
        //    t.Rows[6].Cells[1].FillColor = color;

        //    doc.InsertTable(t);
        //    #endregion
        //}

        public string EpiloghGenousKatw(Gender gender)
        {
            if (gender == Gender.Man)
                return "του ";
            else
                return "της ";
        }

        public string EpiloghGenousPanw(Gender gender)
        {
            if (gender == Gender.Man)
                return "τον ";
            else if (gender == Gender.Woman)
                return "την ";
            else
                return "την ";
        }

        public string EpiloghGenousOfeileti(Gender gender)
        {
            if (gender == Gender.Man)
                return " οφειλέτη ";
            else if (gender == Gender.Woman)
                return " οφειλέτιδος ";
            else
                return "οφειλέτριας ";
        }

        public string DisplayEpwnumiaEtaireias(Gender gender)
        {
            if (gender == Gender.Etaireia)
                return "εταιρείας με την επωνυμία ";
            else
                return "";
        }

        public string IsBankEmpty(bool isBankEmpty)
        {
            if (isBankEmpty)
            {
                return "";
            }
            else
            {
                return " μετά από επίσπευση της Εθνικής Τράπεζας της Ελλάδος Α.Ε.";
            }
        }

        public string isPinakas(bool isPinakas)
        {
            if (isPinakas)
            {
                return "(ΠΙΝΑΚΑ ΚΑΤΑΤΑΞΗΣ ΔΑΝΕΙΣΤΩΝ - ΠΡΟΣΚΛΗΣΗΣ ΔΑΝΕΙΣΤΩΝ)";
            }
            else
            {
                return "(ΠΡΟΣΚΛΗΣΗΣ ΔΑΝΕΙΣΤΩΝ)";
            }
        }

        public string KeimenoPraxis(LegalEntity legalEntity)
        {
            string praxh = null;
            switch (legalEntity)
            {
                case LegalEntity.EllinikoDimosio:
                    praxh = "Αφού δεν βρήκα τον ίδιο στην έδρα του Νομικού Συμβουλίου του Κράτους επί της οδού Ακαδημίας & Χαρ. Τρικούπη, όπου σύμφωνα με τον Νόμο γίνονται οι επιδόσεις προς αυτόν, ούτε Διευθυντή ή συνεργάτη του, αλλά τον εξουσιοδοτημένο γιά την παραλαβή Πάρεδρο Ν.Σ.Κ. ............................................, επέδωσα σ΄ αυτόν το άνω δικόγραφο.";
                    break;
                case LegalEntity.EFka:
                    praxh = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο του άνω Ν.Π.Δ.Δ. στην έδρα του επί της οδού  Αγίου Κωνσταντίνου αρ. 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτού …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. ";
                    break;
                case LegalEntity.LoipesUpirisies:
                    praxh = "Αφού δεν βρήκα στην έδρα της άνω υπηρεσίας στην οδό ………………., τον Διευθυντή αυτής, ούτε Προϊστάμενο ή συνεργάτη του, αλλά τ… εξουσιοδοτημέν.. για την παραλαβή υπάλληλο …………………………………………, όπως μου δήλωσε, επέδωσα σ΄αυτ.. το άνω δικόγραφο.";
                    break;
                case LegalEntity.Olp:
                    praxh = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο του άνω Ν.Π.Δ.Δ.στην οδό Αγίου Κωνσταντίνου αρ. 16 ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. ";
                    break;
                case LegalEntity.Tel:
                    praxh = "Αφού δεν βρήκα στην έδρα της άνω υπηρεσίας στην οδό ………………., τον Διευθυντή αυτής, ούτε Προϊστάμενο ή συνεργάτη του, αλλά τ… εξουσιοδοτημέν.. για την παραλαβή υπάλληλο …………………………………………, όπως μου δήλωσε, επέδωσα σ΄αυτ.. το άνω δικόγραφο.";
                    break;
                case LegalEntity.Trapezes:
                    praxh = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Αιόλου αρ.86, ούτε Διευθυντή ή συνεργάτη, για τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο";
                    break;
                case LegalEntity.Dimos:
                    praxh = "Και αφού δεν βρήκα τον Δήμαρχο του δήμου αυτού στην έδρα του στην οδό ……………………………………………., ούτε τον αντιδήμαρχο, ούτε διευθυντή ή προϊστάμενο, αλλά τ… εντεταλμέν…  για την παραλαβή δικογράφων υπάλληλο αυτού………………………………………… όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.";
                    break;
                case LegalEntity.FusikoProswpo:
                    break;
                case LegalEntity.Empty:
                    break;
                default:
                    break;
            }
            return praxh;
        }
    }
}

     

   