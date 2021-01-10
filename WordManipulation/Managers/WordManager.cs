using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using WordManipulation.Models;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace WordManipulation.Managers
{
    public class WordManager
    {
        public void CreateDocumentHeader(DocX doc, Zone zone)
        {
            Table t = doc.AddTable(7, 2);            

            t.SetColumnWidth(0, 350d);
            t.SetColumnWidth(1, 110d);
            t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.AntiqueWhite));
            t.Alignment = Alignment.center;


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
        }
        public void CreateIndex(DocX doc)
        {
            string header = "ΕΚΘΕΣΗ ΕΠΙΔΟΣΗΣ";
            string fontFamily = "Times new roman";
            var headerFormat = new Formatting
            {
                FontFamily = new Xceed.Document.NET.Font("Times new roman"),
                Size = 13D,
                Bold = true,
                UnderlineStyle = UnderlineStyle.singleLine,
                Spacing = 1.2
            };
            Paragraph headParagraph = doc.InsertParagraph("", false, headerFormat);
            headParagraph.AppendLine();
            headParagraph.AppendLine();
            Paragraph headerTextParagraph = doc.InsertParagraph(header, false, headerFormat);
            headerTextParagraph.Alignment = Alignment.both;
            headerTextParagraph.Append("                                                                            ");
            headerTextParagraph.Append("Αριθμός.............").Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(12D).Spacing(1.2).Font(fontFamily).Alignment = Alignment.right;


        }
    }
}