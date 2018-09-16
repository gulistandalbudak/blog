using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;

namespace MvcBlog.Controllers
{
    public class AdminKategoriController : Controller
    {
        mvcblogDB db = new mvcblogDB();
        // GET: AdminKategori
        public ActionResult Index()
        {
            var kategoris = db.Kategoris.ToList();
            return View(kategoris);
        }

        // GET: AdminKategori/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminKategori/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminKategori/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminKategori/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminKategori/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminKategori/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminKategori/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
