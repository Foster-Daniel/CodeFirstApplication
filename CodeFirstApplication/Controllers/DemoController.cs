using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApplication.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public string StrPrint()
        {

            ViewBag.VBSTR = "This is from ViewBag Data.";
            ViewData["VDSTR"] = "This is from ViewData object.";
            TempData["TMPSTR"] = "This is Temp data.";
            //Response.Write($"{ViewBag.VBSTR}<br>{ViewData["VDSTR"]}<br>{TempData["TMPSTR"]}<br>");
            return "Welcome to My Demo";
        }

        public string[] ListOfStringsToPrintOrSomethingIDK()
        {

            var T1 = TempData["TMPSTR"];
            TempData.Keep();
            
            Response.Write($"{T1} <br>");
            Response.Write($"{T1} <br>");
            Response.Write($"{T1} <br>");




            string[] Stringything = new string[5];
            for(byte i = 0; i < Stringything.Length; i++)
            {Stringything[i] = $"{i} Carrots";}
            return Stringything;
        }

        public ActionResult ActualListOfStringsToPrintOrSomethingIDK()
        {

            string[] Stringything = new string[5];
            for (byte i = 0; i < Stringything.Length; i++)
            {
                if(i == 0) Stringything[i] = $"{i + 1} Carrot";
                else Stringything[i] = $"{i + 1} Carrots";
            }
            ViewBag.Name = Stringything.ToList();

            return View(ViewBag.Name);
            
        }


    }
}