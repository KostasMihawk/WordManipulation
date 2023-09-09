using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordManipulation.Models;
using WordManipulation.ViewModels;

namespace WordManipulation.Controllers
{
    public class KatasxetiriaController : Controller
    {
        // GET: Katasxetiria
        // public ActionResult Index()
        // {
        //     return View();
        // }

        public ActionResult CreateKatasxetirio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateKatasxetirio(KatasxetirioViewModel vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            Summary s = new Summary();

            var KatasxetirioModel = new KatasxetirioModel(vm);            
            var zipFiles = generator.GetZipFilesForKatasxetiria();

            using(MemoryStream stream = new MemoryStream())
            {
                using(ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach(var doc in zipFiles)
                    {
                        KatasxetirioModel.fillZipEntries(doc);
                        zip.AddEntry(doc.Name + ".docx", s.CreateKatasxetiria(KatasxetirioModel));
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", "test.zip");
            }


            
        }
    }
}