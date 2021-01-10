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
using WordManipulation.ViewModels;

namespace WordManipulation.Controllers.API
{
    public class AutoCompleteController : ApiController
    {
        private object agent;

        public string Get(int bailif=1, int notary=1, string docNum = "123/20", string ofeileths ="γιαννης", string place ="", int gender = 0, int keao = 0, bool praxh = false)
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
            form.Gender = (Gender)gender;
            form.Place = place;
            form.Praxh = praxh;
            form.KEAO = (KEAO)keao;
            //ylopoihsh me dictionary h tupple
            //se ka8e adikeimeno st lista na fortwnei diaforetiko bool(form.praxh)
            Dictionary<string, LegalEntity> foreis = new Dictionary<string, LegalEntity> {
                { "προς το Ν.Π.Δ.Δ. με την επωνυμία e-ΕΦΚΑ που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα", LegalEntity.EFka},
                { "προς τον κ. Διοικητή Της Ανεξάρτητης Αρχής Δημοσίων Εσόδων (Α.Α.Δ.Ε.) ως εκπρόσωπο του Ελληνικού Δημοσίου κατοικοεδρεύοντα στην Αθήνα", LegalEntity.EllinikoDimosio },
                { "προς την επισπεύδουσα ανώνυμη τραπεζική εταιρεία με την επωνυμία «Εθνική Τράπεζα της Ελλάδος Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα με ΑΦΜ 094014201", LegalEntity.Trapezes },
                { "προς τον προϊστάμενο της αναγγελθείσας ΔΟΥ .",LegalEntity.LoipesUpirisies },
                { "προς το " + EpilogiKeaoA(form.KEAO) + "Περιφερειακό ΚΕΑΟ " + EpilogiKeaoB(form.KEAO), LegalEntity.LoipesUpirisies },
                { "προς "  + s.EpiloghGenousPanw(form.Gender) +  ofeileths, LegalEntity.FusikoProswpo },
                { " " ,LegalEntity.Empty} };



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
                form.Defender.Text = doc.Key;
                form.Defender.legalEntity = doc.Value;
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
        public string EpilogiKeaoA(KEAO keao)
        {
            if (keao == KEAO.AAthina)
                return " A ";
            else if (keao == KEAO.BAthina)
                return " B ";
            else
                return "";
        }

        public string EpilogiKeaoB(KEAO keao)
        {
            if (keao == KEAO.AAthina)
                return " Αθήνας ";
            else if (keao == KEAO.BAthina)
                return " Αθήνας ";
            else if (keao == KEAO.Peireas)
                return  " Πειραιά ";
            else
                return " Ελευσίνας ";
        }

    }
}
