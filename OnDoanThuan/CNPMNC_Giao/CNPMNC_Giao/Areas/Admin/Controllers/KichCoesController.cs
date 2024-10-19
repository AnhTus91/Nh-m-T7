using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CNPMNC_Giao.Models;

namespace CNPMNC_Giao.Areas.Admin.Controllers
{
    public class KichCoesController : Controller
    {
        private DAPM_1Entities1 db = new DAPM_1Entities1();

        // GET: Admin/KichCoes
        public ActionResult Index()
        {
            var kichCo = db.KichCo.Include(k => k.SanPham).Include(k => k.SanPham);
            return View(kichCo.ToList());
        }

        // GET: Admin/KichCoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KichCo kichCo = db.KichCo.Find(id);
            if (kichCo == null)
            {
                return HttpNotFound();
            }
            return View(kichCo);
        }

        // GET: Admin/KichCoes/Create
        public ActionResult Create()
        {
            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham");
            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham");
            return View();
        }

        // POST: Admin/KichCoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKichCo,MaSanPham,SoKichCo,SoLuong")] KichCo kichCo)
        {
            if (ModelState.IsValid)
            {
                db.KichCo.Add(kichCo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham", kichCo.MaSanPham);
            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham", kichCo.MaSanPham);
            return View(kichCo);
        }

        // GET: Admin/KichCoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KichCo kichCo = db.KichCo.Find(id);
            if (kichCo == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham", kichCo.MaSanPham);
            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham", kichCo.MaSanPham);
            return View(kichCo);
        }

        // POST: Admin/KichCoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKichCo,MaSanPham,SoKichCo,SoLuong")] KichCo kichCo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kichCo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham", kichCo.MaSanPham);
            ViewBag.MaSanPham = new SelectList(db.SanPham, "MaSanPham", "TenSanPham", kichCo.MaSanPham);
            return View(kichCo);
        }

        // GET: Admin/KichCoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KichCo kichCo = db.KichCo.Find(id);
            if (kichCo == null)
            {
                return HttpNotFound();
            }
            return View(kichCo);
        }

        // POST: Admin/KichCoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KichCo kichCo = db.KichCo.Find(id);
            db.KichCo.Remove(kichCo);
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