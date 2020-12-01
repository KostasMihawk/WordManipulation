using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Controls;
using WordManipulation.Models;

namespace WordManipulation.Controllers.API
{
    public class AutoCompleteController : ApiController
    {
        private object agent;

        public string Get(int bailif=1, int notary=1, string docNum = "123/20", string ofeileths ="γιαννης", string place ="")
        {
            DropDownGenerator generator = new DropDownGenerator();
            Summary s = new Summary();
            
            var form = new Form();
            form.DocumentT = DocumentT.DilwshSunexisisPlirstiasmou;
            form.Bailif = generator.GetBaillifs().SingleOrDefault(b => b.Id == bailif);
            form.Sumbolaiografos = generator.GetNotaries().SingleOrDefault(n => n.Id == notary);
            form.Zone = generator.GetZones().SingleOrDefault(a => a.Id == 1);
            form.DocumentType = new DocumentType();
            form.DocumentType.DocumentNumber = docNum;
            form.DocumentType.Ofeileths = ofeileths;
            form.Place = place;
            List<string> foreis = new List<string> { "προς το Ν.Π.Δ.Δ. με την επωνυμία e-ΕΦΚΑ που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                "προς τον κ. Διοικητή Της Ανεξάρτητης Αρχής Δημοσίων Εσόδων ως εκπρόσωπο του Ελληνικού Δημοσίου κατοικοεδρεύοντα στην Αθήνα",
            "προς την επισπεύδουσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «Εθνική Τράπεζα της Ελλάδος Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα με ΑΦΜ 094014201",
            "Προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ                     .",
            "προς " };


            //form = agent.TranslateFormVm(vm);
            //agent.ManageText(form, vm.DocumentEnum);

            form.Defender = new Defender();

            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            string fileName;
            Process p = new Process();
            foreach (var doc in foreis)
            {
                form.Defender.Text = doc;
                fileName = s.CreateSunexisiPlistiriasmou(form);
                Process.Start("WINWORD.EXE", fileName);
                info.FileName = fileName;
              
                //p.StartInfo = info;
                //p.Start();

                //p.WaitForInputIdle();
                //System.Threading.Thread.Sleep(3000);
                
            }

          
          


            return "Hello World";
        }
    }
}
