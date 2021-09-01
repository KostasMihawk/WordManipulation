using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordManipulation.Models;
using WordManipulation.ViewModels;
using System.IO.Compression;




namespace WordManipulation.Controllers
{
    public class LoanerInvitationController : Controller
    {
        // GET: LoanerInvitation
        public ActionResult LoanerInvitation()
        {
            return View();
        }

        public ActionResult CreateLoanerInvitation()
        {
            return View();
        }

        [HttpPost()]       
        public ActionResult CreateLoanerInvitation(LoanerInvitationViewmodel vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            Summary s = new Summary();

            var form = new Form();
            form.DocumentT = DocumentT.DilwshSunexisisPlirstiasmou;
            form.Bailif = generator.GetBaillifs().SingleOrDefault(b => b.Id == vm.Baillif);
            form.Sumbolaiografos = generator.GetNotaries().SingleOrDefault(n => n.Id == vm.Notary);
            form.Zone = generator.GetZones().SingleOrDefault(a => a.Id == vm.Zone);
            form.DocumentType = new DocumentType();
            form.DocumentType.DocumentNumber = vm.CaseNumber;
            form.DocumentType.Ofeileths = vm.Debtor;
            form.Gender = vm.Gender;
            form.Place = vm.Location;
            form.Praxh = vm.FinishText;
            form.KEAO = vm.KEAO;
            form.IsPinakas = vm.IsTable;
            form.IsBankEmpty = vm.IsBank;
            form.KEAO = vm.KEAO;  

            form.Defender = new Defender();

            var ZipFiles = new List<EkthesiEpidoshsModel>();
            ZipFiles = generator.GetZipFiles();


            using (MemoryStream stream = new MemoryStream())
            {                
                using(ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach (var doc in ZipFiles)
                    {
                        form.Defender.Text = doc.Perigrafh;
                        form.Defender.IsFusikoProsopo = doc.FusikoProswpo;
                        form.Defender.Praxi = doc.Praxh;
                        form.Defender.Address = doc.Location;
                        form.Defender.KeimenoPraxis = doc.Kleisimo;
                        zip.AddEntry(doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(form));                       
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", "test.zip");
            }
        }

       
    }
}