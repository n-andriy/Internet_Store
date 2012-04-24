using System.Collections.Generic;
using System.Web.Mvc;
using MobileStore.Models.Interfaces;
using MobileStore.Service.Interfaces;

namespace MobileStore.Controllers.Abstract
{
    public abstract class BaseController<T> : Controller where T : class, IBase, new()
    {
        // Object working with data
        protected IBaseService<T> service;

        // Parametrize constructor
        public BaseController(IBaseService<T> _service)
        {
            service = _service;
        }

        // Get list of objects
        public virtual ActionResult Index()
        {
            IEnumerable<T> objs = service.Get();
            return View(objs);
        }

        // Get object by ID
        public virtual ActionResult Details(int id)
        {
            T obj = service.Get(id);
            return obj == null ? View("NotFound") : View(obj);
        }

        // Creating object
        public virtual ActionResult Create()
        {
            return View();
        }

        // Handling data from input form
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                var obj = new T();
                ChangeFormCollectionValues(obj, collection);
                UpdateModel(obj, collection);
                
                service.Add(obj);
                service.Save();
                return OnCreated(obj);
            }

            return View();
        }

        // Editing form
        public virtual ActionResult Edit(int id)
        {
            var obj = service.Get(id);
            return obj == null ? View("NotFound") : View(obj);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var obj = service.Get(id);
            
            if (ModelState.IsValid)
            {
                ChangeFormCollectionValues(obj, collection);
                UpdateModel(obj, collection);
                service.Save();

                return OnEdited(obj);
            }

            return View(obj);
        }

        // Deleting form
        public virtual ActionResult Delete(int id)
        {
            var obj = service.Get(id);
            return obj == null ? View("NotFound") : View(obj);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var obj = service.Get(id);
            if (obj == null) return View("NotFound");

            if (!obj.CanBeDeleted()) return View("DeleteFail", obj);

            var onDeleted = OnDeleted(obj);

            OnDelete(obj);
            service.Delete(obj);
            service.Save();
            return onDeleted;
        }

        // Changing values getting from create/input form
        protected virtual void ChangeFormCollectionValues(T obj, FormCollection collection)
        {
        }

        // Adding properties of object which aren't getting from creating object's form
        protected virtual void AddValuesOnCreate(T obj)
        {
        }

        // Actions when removing an object
        protected virtual void OnDelete(T obj)
        {
        }

        // Redirection to page with list of objects
        protected virtual ActionResult ReturnToList(T obj)
        {
            return RedirectToAction("Index");
        }

        // Redirection to page of object
        protected virtual ActionResult ReturnToObject(T obj)
        {
            return RedirectToAction("Details", new { id = obj.ID });
        }

        // Redirection after creating object
        protected virtual ActionResult OnCreated(T obj)
        {
            return ReturnToObject(obj);
        }

        // Redirection after editing object
        protected virtual ActionResult OnEdited(T obj)
        {
            return ReturnToObject(obj);
        }

        // Redirection after deleting object
        protected virtual ActionResult OnDeleted(T obj)
        {
            return ReturnToList(obj);
        }
    }
}