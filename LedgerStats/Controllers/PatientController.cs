using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LedgerStats.Models;

namespace LedgerStats.Controllers
{
    public class PatientController : Controller
    {
        private MyLedgerDb db = new MyLedgerDb();

        // GET: Patient
        public ActionResult Index()
        {
            var patient = from p in db.Patient select p;

            return View(patient);
        }
    }
}