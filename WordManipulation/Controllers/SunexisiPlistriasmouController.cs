﻿using Ionic.Zip;
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
    public class SunexisiPlistriasmouController : Controller
    {
        // GET: SunexisiPlistriasmou
        public ActionResult CreateSunexisiPlistiriasmou()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult CreateSunexisiPlistiriasmou(SunexisiPlistirasmouViewmodel vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            Summary s = new Summary();

            SunexisiPlistiriasmouModel model = new SunexisiPlistiriasmouModel(vm);
            
            

            var ZipFiles = new List<EkthesiEpidoshsModel>();
            ZipFiles = generator.GetZipFiles();           
            using(MemoryStream stream = new MemoryStream())
            {
                using(ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach (var doc in ZipFiles)
                    {
                        model.fillZipEntries(doc);
                        zip.AddEntry(doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", vm.Debtor + ".zip");
            }            
        }
    }
}