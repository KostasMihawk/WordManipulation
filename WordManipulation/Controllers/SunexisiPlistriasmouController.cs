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
            Form form = new Form();

            form.Sumbolaiografos = generator.GetNotaries().SingleOrDefault(n => n.Id == vm.Notary);
            form.Zone = generator.GetZones().SingleOrDefault(z => z.Id == vm.Zone);
            form.DocumentType = new DocumentType();
            form.DocumentType.DocumentNumber = vm.CaseNumber;
            form.DocumentType.Ofeileths = vm.Debtor;
            form.Gender = vm.Gender;
            form.Place = vm.Location;
            form.Defender = new Defender();
            form.Defender.Epispeudon = vm.Epispeudon??"";
            

            var ZipFiles = new List<EkthesiEpidoshsModel>();
            ZipFiles = generator.GetZipFiles();           
            using(MemoryStream stream = new MemoryStream())
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
                        zip.AddEntry(doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(form));
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", vm.Debtor + ".zip");
            }            
        }
    }
}