﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASLBarcoding.Models;
using Microsoft.AspNet.Identity;

namespace ASLBarcoding.Controllers
{
    public class SampleTypeController : Controller
    {
        private ASLBarcodingDBEntities db = new ASLBarcodingDBEntities();

        // GET: SampleType
        public ActionResult Index()
        {
            var sampleType = db.SampleType.Include(s => s.TestType);
            return View(sampleType.ToList());
        }

        // GET: SampleType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleType sampleType = db.SampleType.Find(id);
            if (sampleType == null)
            {
                return HttpNotFound(); 
            }
            return View(sampleType);
        }

        // GET: SampleType/Create
        public ActionResult Create()
        {
            ViewBag.TestType_Id = new SelectList(db.TestType, "Id", "Name");
            return View();
        }

        // POST: SampleType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,Name,TestType_Id")] SampleType sampleType)
        {
            if (ModelState.IsValid)
            {

                var manager = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
                var currentUser = manager.FindById(User.Identity.GetUserId());
                //barcodecs objbar = new barcodecs();

                if (currentUser != null)
                    sampleType.createdBy = currentUser.UserName;
                else
                    sampleType.createdBy = User.Identity.Name;

                sampleType.createdDate = DateTime.Now;


                db.SampleType.Add(sampleType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TestType_Id = new SelectList(db.TestType, "Id", "Name", sampleType.TestType_Id);
            return View(sampleType);
        }

        // GET: SampleType/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleType sampleType = db.SampleType.Find(id);
            if (sampleType == null)
            {
                return HttpNotFound();
            }
            ViewBag.TestType_Id = new SelectList(db.TestType, "Id", "Name", sampleType.TestType_Id);
            return View(sampleType);
        }

        // POST: SampleType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,Name,TestType_Id")] SampleType sampleType)
        {
            if (ModelState.IsValid)
            {

                var manager = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
                var currentUser = manager.FindById(User.Identity.GetUserId());

                if (currentUser != null)
                    sampleType.updatedBy = currentUser.UserName;
                else
                    sampleType.updatedBy = User.Identity.Name;

                sampleType.updatedDate = DateTime.Now;

                db.Entry(sampleType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TestType_Id = new SelectList(db.TestType, "Id", "Name", sampleType.TestType_Id);
            return View(sampleType);
        }

        // GET: SampleType/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleType sampleType = db.SampleType.Find(id);
            if (sampleType == null)
            {
                return HttpNotFound();
            }
            return View(sampleType);
        }

        // POST: SampleType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            SampleType sampleType = db.SampleType.Find(id);
            db.SampleType.Remove(sampleType);
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
