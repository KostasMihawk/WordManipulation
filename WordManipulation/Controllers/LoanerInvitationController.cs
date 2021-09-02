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

            var LoanerInvitationModel = new LoanerInvitationModel(vm);           

            var ZipFiles = new List<EkthesiEpidoshsModel>();
            ZipFiles = generator.GetZipFiles();


            using (MemoryStream stream = new MemoryStream())
            {                
                using(ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach (var doc in ZipFiles)
                    {
                        LoanerInvitationModel.fillZipEntries(doc);
                        zip.AddEntry(doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));                       
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", "test.zip");
            }
        }

       


    }
}