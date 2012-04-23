using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileStore.Models;

namespace MobileStore.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly MobileDbEntities _entities = new MobileDbEntities();
        
        // List of all manufacturers
        public ActionResult Index()
        {
            var manufacturers = _entities.Manufacturers;
            return View(manufacturers);
        }

        // Details of manufacturer
        public ActionResult Details(int id)
        {
            var obj = (from item in _entities.Manufacturers where item.ID == id select item).FirstOrDefault();
            return obj == null ? View("NotFound") : View(obj);
        }

        // Creating manufacturer
        public ActionResult Create()
        {
            return View();
        }

        // Handling data from input form
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                var obj = new Manufacturer();
                UpdateModel(obj, collection);
                _entities.Manufacturers.AddObject(obj);
                _entities.SaveChanges();
                return RedirectToAction("Details", new { id = obj.ID });
            }
           
            return View();
        }

        // Editing form
        public ActionResult Edit(int id)
        {
            var obj = (from item in _entities.Manufacturers where item.ID == id select item).FirstOrDefault();
            return obj == null ? View("NotFound") : View(obj);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var obj = (from item in _entities.Manufacturers where item.ID == id select item).FirstOrDefault();
            if (obj == null) return View("NotFound");

            if (ModelState.IsValid)
            {
                UpdateModel(obj, collection);
                _entities.SaveChanges();
                return RedirectToAction("Details", new {id = obj.ID});
            }

            return View(obj);
        }

        // Deleting form
        public ActionResult Delete(int id)
        {
            var obj = (from item in _entities.Manufacturers where item.ID == id select item).FirstOrDefault();
            return obj == null ? View("NotFound") : View(obj);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var obj = (from item in _entities.Manufacturers where item.ID == id select item).FirstOrDefault();
            if (obj == null) return View("NotFound");
            _entities.Manufacturers.DeleteObject(obj);
            _entities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
