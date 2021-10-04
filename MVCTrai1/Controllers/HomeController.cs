using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTrai1.Models;
using MVCTrai1.BoolShit;

namespace MVCTrai1.Controllers
{
    public class HomeController : Controller
    {
        DBContext db = new DBContext();
        public ActionResult Index()
        {
            ViewBag.Toys = db.Toys;
            ViewBag.purchases = db.purchases;
            return View();
        }

        public string Multi(int i, int j)
        {
            return "<h2>" + (i * j) + "</h2>";
        }
        public ActionResult GetHTML()
        {
            //https://i.ibb.co/vqXQ4cn/1578383531339.jpg
            return new HtmlResult("<h2>ты пидор</h2>");
        }
        public ActionResult GetOneIMG()
        {            
            return new GetOneIMG("https://i.ibb.co/vqXQ4cn/1578383531339.jpg");
        }
        public string Multi2()
        {
            //if (Request.Params.Count != 2)
            //{
            //    string resoult = "";
            //    for (int n = 0; n< Request.Params.Count;n++ )
            //    {
            //        resoult += "<p>" +Request.Params[n] + "</p>";
            //    }
            //    return resoult +"Говна въебал? " + Request.Params.Count;
            //    //https://localhost:44366/Home/Multi2?i=4&j=5
            //}
            string resoult = "";
            if (Request.Params["y"] == null)
                resoult += "<p>y is Null</p>";
            int i = Int32.Parse(Request.Params["i"]);
            int j = Int32.Parse(Request.Params["j"]);
            return resoult +"<h2>" + (i * j) + "</h2>";
        }
        public ActionResult SomeURl()
        {
            if (Request.Params.Count > 2)
                return RedirectToAction("Multi2",new {i = Request.Params[0], j = Request.Params[1] });
            return Redirect("/Home/GetOneIMG");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Buy(int Id)
        {
            ViewBag.ToyId = Id;
            return View();

        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо, " + purchase.Customer + ", за покупку!";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}