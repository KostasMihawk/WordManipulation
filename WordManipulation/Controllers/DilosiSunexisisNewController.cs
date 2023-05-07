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
    public class DilosiSunexisisNewController : Controller
    {
        // GET: DilosiSunexisisNew
        public ActionResult CreateDilosi()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult CreateDilosi(DilosiSunexisisVm vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            Summary s = new Summary();
            DilosiSunexisisModel model = new DilosiSunexisisModel(vm);

            var ZipFiles = new List<EkthesiEpidoshsModel>();
            ZipFiles = generator.GetZipFiles();
            using (MemoryStream stream = new MemoryStream())
            {
                using (ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach (var doc in ZipFiles)
                    {

                        model.fillZipEntries(doc);
                        if (doc.Name.Contains("Εφοριες"))
                        {
                            zip.AddEntry("Εφορίες/" + doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                        else if (doc.Name.Contains("Cepal"))
                        {
                            zip.AddEntry("Cepal/" + doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                        else if (doc.Name.Contains("doValue"))
                        {
                            zip.AddEntry("doValue/" + doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                        else if (doc.Name.Contains("Intrum"))
                        {
                            zip.AddEntry("Intrum/" + doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                        else if (doc.Name.Contains("QQuant"))
                        {
                            zip.AddEntry("QQuant/" + doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                        else if (doc.Name.Contains("ALfa"))
                        {
                            zip.AddEntry("Αλφα/" + doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                        else if (doc.Name.Contains("pqh"))
                        {
                            zip.AddEntry("pqh/" + doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                        else
                        {
                            zip.AddEntry(doc.Name + ".docx", s.CreateDilosiSunexisis(model));
                        }
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", vm.Debtor + ".zip");
            }
        }
    }
}