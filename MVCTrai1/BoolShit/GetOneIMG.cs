using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTrai1.BoolShit
{
    public class GetOneIMG : ActionResult
    {
        private string adress;
        public GetOneIMG(string adress)
        {
            this.adress = adress;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            string resoult = "<div class=\"container\"><img class=\"align - content - lg - around\" src = " + adress + "/></div>";
            context.HttpContext.Response.Write(resoult);
        }
    }
}