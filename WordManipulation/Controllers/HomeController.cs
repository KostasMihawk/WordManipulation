using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordManipulation.BML;
using WordManipulation.Models;
using WordManipulation.ViewModels;
using Microsoft.Office.Interop.Word;

namespace WordManipulation.Controllers
{
    public class HomeController : Controller
    {
        private Agent agent = new Agent();
        public ActionResult Index()
        {
            var vm = new CreateVM();
            vm.SelectTime = SelectTime.Today;
            vm.Praxh = true;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(CreateVM vm)
        {
           
            if (ModelState.IsValid)
            {
                Summary s = new Summary();
                var form = new Form();
                form = agent.TranslateFormVm(vm);
                agent.ManageText(form, vm.DocumentEnum);                               
                Process.Start("WINWORD.EXE", s.CreateWordDocument(form));
                
            }
            return RedirectToAction("Arxiki");
        }

        public ActionResult Arxiki()
        {
            return View();
        }        

        public ActionResult Plistiriamsos()
        {
            var vm = new CreateVM();
            vm.SelectTime = SelectTime.Today;
            vm.Praxh = true;
            return View(vm);
        }
        [HttpPost]
        public ActionResult Plistiriamsos(CreateVM vm)
        {
            if (ModelState.IsValid)
            {

                Summary s = new Summary();
                var form = new Form();
                form = agent.TranslateFormVm(vm);
                agent.ManageText(form, vm.DocumentEnum);
                //Process.Start("WINWORD.EXE", s.CreateSunexisiPlistiriasmou(form));
               
                
            }
            return RedirectToAction("Arxiki");
        }

        public ActionResult AutoCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AutoCreate(AutoCreate ac)
        {
            if (ModelState.IsValid)
            {

                Summary s = new Summary();
                var form = new Form();
            }
            return View();
        }
    }
}