using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CF_Skill_Card.Models.Class;
namespace CF_Skill_Card.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            
            var degerler = context.Skills.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult newSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult newSkill(Skill s)
        {
            context.Skills.Add(s);
            context.SaveChanges();
            return View();
        }

       public ActionResult deleteSkill (int id)
        {
            var deger = context.Skills.Find(id);
            context.Skills.Remove(deger);
            context.SaveChanges();
            return RedirectToAction("Index");
       }
        [HttpGet]
        public ActionResult updateSkill(int id)
        {
            var deger = context.Skills.Find(id);
            
            return View("updateSkill",deger);    
        }
        [HttpPost]
        public ActionResult updateSkill(Skill s )
        {
            var x = context.Skills.Find(s.skillID);
            x.skillDescription =s.skillDescription;
            x.skillValue = s.skillValue;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}