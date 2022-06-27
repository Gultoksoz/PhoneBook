using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phonebook.Controllers
{
    public class PhonebookController : Controller
    {
        private DataAccess da = new DataAccess();

        public ActionResult Listing()
        {
            var result = da.GetAll();

            return View(result);
        }

        public ActionResult Edit(String id)
        {
            var result = da.Edit(id);

            return View(result);
        }

        public ActionResult Delete(String id)
        {
            da.Delete(id);

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Record record)
        {

            if (ModelState.IsValid)
            {
                da.Create(record);

                return RedirectToAction("Listing");
            }
            else
            {
                return View();
            }
            
        }

    }
}
