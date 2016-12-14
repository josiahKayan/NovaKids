using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NovaKids.Infra.Data.Context;
using NovaKidsMvc.ViewModels;
using NovaKids.Application.Interface;
using NovaKids.Application;

namespace NovaKidsMvc.Controllers
{
    public class PresencaController : Controller
    {

        private readonly IPresencaAppService _presencaAppService;

        public PresencaController(PresencaAppService presencaAppService)
        {
            _presencaAppService = presencaAppService;
        }



        // GET: PresencaViewModels
        public ActionResult Index()
        {
            /*return View(db.PresencaViewModels.ToList());*/
            return HttpNotFound();
        }

        // GET: PresencaViewModels/Details/5
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //PresencaViewModel presencaViewModel = db.PresencaViewModels.Find(id);
            //if (presencaViewModel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(presencaViewModel);
            return HttpNotFound();
        }

        // GET: PresencaViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PresencaViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data,Hora")] PresencaViewModel presencaViewModel)
        {
            //if (ModelState.IsValid)
            //{
            //    db.PresencaViewModels.Add(presencaViewModel);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            return View(presencaViewModel);
        }

        // GET: PresencaViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //PresencaViewModel presencaViewModel = db.PresencaViewModels.Find(id);
            //if (presencaViewModel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(presencaViewModel);

            return HttpNotFound();
        }

        // POST: PresencaViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data,Hora")] PresencaViewModel presencaViewModel)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(presencaViewModel).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(presencaViewModel);
            return HttpNotFound();
        }

        // GET: PresencaViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //PresencaViewModel presencaViewModel = db.PresencaViewModels.Find(id);
            //if (presencaViewModel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(presencaViewModel);
            return HttpNotFound();
        }

        // POST: PresencaViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //PresencaViewModel presencaViewModel = db.PresencaViewModels.Find(id);
            //db.PresencaViewModels.Remove(presencaViewModel);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
