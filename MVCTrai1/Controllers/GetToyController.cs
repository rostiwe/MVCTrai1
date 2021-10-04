using MVCTrai1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTrai1.Controllers
{
    public class GetToyController : Controller
    {
        DBContext db = new DBContext();
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public string Form(string Name/*, string Manufacturer*/)
        {
            var i = db.Toys.FirstOrDefault(x=> x.Name == Name /*&& x.Manufacturer == Manufacturer*/);
            if (i != null)
                return i.Name + " " + i.Manufacturer + "  " + i.Price.ToString();
            else return "нихера нет";
        }
        public ActionResult GetToy(string Name)
        {
            var toys = db.Toys.Where(x => x.Name == Name);
            ViewBag.ToysSet = toys;
            return View();
        }

    }
}