using Lab3.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class AccountController : Controller
    {
        private int id;

        public int ID { get; private set; }

        // GET: Account
        public ActionResult Index()
        {
            Advance_DatabaseEntities db = new Advance_DatabaseEntities();
            var data = db.Accounts.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Account s)
        {
            if (ModelState.IsValid)
            {
                Advance_DatabaseEntities db = new Advance_DatabaseEntities();
                db.Accounts.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Add(int id)
        {
            var db = new Advance_DatabaseEntities();
            var data = (from d in db.Accounts where d.ID == id select d).SingleOrDefault();

            return View(data);

        }
        [HttpPost]
        public ActionResult Add(Account s)
        {
            var db = new Advance_DatabaseEntities();
            var user = (from d in db.Accounts where d.ID == s.ID select d).FirstOrDefault();
            user.Name = s.Name;
            user.Email = s.Email;
            user.Date_of_Birth = s.Date_of_Birth;
            user.Address = s.Address;
            user.Mobile_Number = s.Mobile_Number;
            try
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException n)
            {
                return View(s);
            }
        }
        public ActionResult Delete(int ID)
        {
            var db = new Advance_DatabaseEntities();
            var s = (from d in db.Accounts where d.ID == ID select d).SingleOrDefault();
            db.Accounts.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}