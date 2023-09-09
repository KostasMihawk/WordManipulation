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
        // public ActionResult LoanerInvitation()
        // {
        //     return View();
        // }

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
                        if(doc.Name.Contains("Εφοριες"))
                        {    
                            zip.AddEntry("Εφορίες/" + doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                        else if(doc.Name.Contains("Cepal"))
                        {
                            zip.AddEntry("Cepal/" + doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                        else if (doc.Name.Contains("doValue"))
                        {
                            zip.AddEntry("doValue/" + doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                        else if (doc.Name.Contains("Intrum"))
                        {
                            zip.AddEntry("Intrum/" + doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                        else if (doc.Name.Contains("QQuant"))
                        {
                            zip.AddEntry("QQuant/" + doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                        else if (doc.Name.Contains("ALfa"))
                        {
                            zip.AddEntry("Αλφα/" + doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                        else if(doc.Name.Contains("pqh")){
                            zip.AddEntry("Pqh/" + doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                        else
                        {
                            zip.AddEntry(doc.Name + ".docx", s.CreateSunexisiPlistiriasmou(LoanerInvitationModel));
                        }
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", vm.Debtor + ".zip");
            }
        }

       


    }
}