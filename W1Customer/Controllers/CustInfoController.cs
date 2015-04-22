using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W1Customer.Models;

namespace W1Customer.Controllers
{
    public class CustInfoController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: CustInfo
        public ActionResult Index()
        {
            return View(db.vw_CustInfo.ToList());
        }

        // GET: CustInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustInfo/Create
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

        // GET: CustInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustInfo/Edit/5
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

        // GET: CustInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustInfo/Delete/5
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
