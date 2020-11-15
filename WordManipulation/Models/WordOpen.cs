using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.Office;
using Newtonsoft.Json;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Formatting = Xceed.Document.NET.Formatting;
using System.Drawing;


namespace WordManipulation.Models
{
    public class WordOpen
    {
        public void OpenDocument()
        {
            string fileName = "Example.docx";
            var doc = DocX.Create(fileName);
            doc.InsertParagraph("Hi everyone");

            string title = "Title of the document";

            var titleFormat = new Formatting();
            titleFormat.FontFamily = new Xceed.Document.NET.Font("Times new roman");
            titleFormat.Size = 15D;
            titleFormat.Position = 40;
            titleFormat.FontColor = Color.BlueViolet;
            titleFormat.UnderlineColor = Color.Gray;
            titleFormat.Italic = true;

            string textParagraph = "Dear Friends, " + Environment.NewLine +
                                   "lorem ipsum";

            var textParagraphFormat = new Formatting();
            textParagraphFormat.FontFamily = new Xceed.Document.NET.Font("Century Gothic");
            textParagraphFormat.Size = 12;
            textParagraphFormat.Spacing = 2;

            Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;

            doc.InsertParagraph(textParagraph, false, textParagraphFormat);

            doc.Save();
            Process.Start("WINWORD.EXE",fileName);
        }
    }
}