using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CF_Skill_Card.Models.Class;
namespace CF_Skill_Card.Controllers
{
    public class DefaultController : Controller
    {

        
        // GET: Default
        public ActionResult Index()
        {
            Context context = new Context();
            var degerler = context.Skills.ToList();
            return View(degerler);
        }
    }
}