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
        
              
        public ActionResult Arxiki()
        {
            return View();
        }        

        
    }
}