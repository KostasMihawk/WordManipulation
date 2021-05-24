using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xceed.Document.NET;

namespace WordManipulation.BML
{
    public class DocXConstructor
    {
        private double fontSize = 12;
        private string fontFamily = "Times new roman";
        public Paragraph AddToParagraph(Paragraph paragraph, string text)
        {
            paragraph.Append(text).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }
        public Paragraph AddToParagraph(Paragraph paragraph, string text, double fontSize, string fontFamily)
        {
            paragraph.Append(text).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }

        public Paragraph AddNewLine(Paragraph paragraph)
        {
            return paragraph.AppendLine();
        }
      
        public Paragraph AddToParagraphBoldText(Paragraph paragraph, string text)
        {
            paragraph.Append(text).Bold().FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }

        public Paragraph AddToParagraphBoldAndUnderlinedText(Paragraph paragraph, string text)
        {
            paragraph.Append(text).Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }
    }
}