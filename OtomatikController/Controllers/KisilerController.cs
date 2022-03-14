﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OtomatikController.Controllers
{
    public class KisilerController : Controller
    {
        private TestEntities db = new TestEntities();

        // GET: Kisiler
        public ActionResult Index()
        {
            return View(db.Kisiler.ToList());
        }

        // GET: Kisiler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisiler kisiler = db.Kisiler.Find(id);
            if (kisiler == null)
            {
                return HttpNotFound();
            }
            return View(kisiler);
        }

        // GET: Kisiler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kisiler/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Isim,Soyisim,Adres,Yas")] Kisiler kisiler)
        {
            if (ModelState.IsValid)
            {
                db.Kisiler.Add(kisiler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kisiler);
        }

        // GET: Kisiler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisiler kisiler = db.Kisiler.Find(id);
            if (kisiler == null)
            {
                return HttpNotFound();
            }
            return View(kisiler);
        }

        // POST: Kisiler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Isim,Soyisim,Adres,Yas")] Kisiler kisiler) 
            //include ile belirtilen alanlar modele dahil edilir.
            //Exclude ile belirtilen alanlar modelden çıkarılır.
        {
            if (ModelState.IsValid)
            {
                db.Entry(kisiler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kisiler);
        }

        // GET: Kisiler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisiler kisiler = db.Kisiler.Find(id);
            if (kisiler == null)
            {
                return HttpNotFound();
            }
            return View(kisiler);
        }

        // POST: Kisiler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kisiler kisiler = db.Kisiler.Find(id);
            db.Kisiler.Remove(kisiler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
