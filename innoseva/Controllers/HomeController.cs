using innoseva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileHelpers;
using System.IO;

namespace innoseva.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Welcome()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Welcome([Bind(Include = "id,first_name,last_name,phone_number,address")] Book1 book1)
        {
            if (ModelState.IsValid)
            {   
                Book1 b = new Book1();
                var reader = new StreamReader("cust.csv");
                while(!reader.EndOfStream)
                {
                      var ln = reader.ReadLine();
                      var val = ln.Split(',');
     
                        if((book1.first_name == val[1])&&(book1.last_name == val[2])&&(book1.phone_number == val[3])&&(book1.address == val[4]))
                        { return RedirectToAction("Index");}

                }
                return RedirectToAction("sorry");

       

                
            }

           return RedirectToAction("Sorry");
        }
        public ActionResult Sorry()
        {
            return View();

        }
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult About()
        {
          

            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }
    }
}