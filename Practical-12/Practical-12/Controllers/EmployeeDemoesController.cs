using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practical_12.Data;
using Practical_12.Models;

namespace Practical_12.Controllers
{
    public class EmployeeDemoesController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: EmployeeDemoes
        public ActionResult Index()
        {
            return View(db.EmployeeDemoes.ToList());
        }

        // GET: EmployeeDemoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDemo employeeDemo = db.EmployeeDemoes.Find(id);
            if (employeeDemo == null)
            {
                return HttpNotFound();
            }
            return View(employeeDemo);
        }

        // GET: EmployeeDemoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeDemoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,DOB,Age")] EmployeeDemo employeeDemo)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDemoes.Add(employeeDemo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeDemo);
        }

        // GET: EmployeeDemoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDemo employeeDemo = db.EmployeeDemoes.Find(id);
            if (employeeDemo == null)
            {
                return HttpNotFound();
            }
            return View(employeeDemo);
        }

        // POST: EmployeeDemoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,DOB,Age")] EmployeeDemo employeeDemo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeDemo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeDemo);
        }

        // GET: EmployeeDemoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDemo employeeDemo = db.EmployeeDemoes.Find(id);
            if (employeeDemo == null)
            {
                return HttpNotFound();
            }
            return View(employeeDemo);
        }

        // POST: EmployeeDemoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeDemo employeeDemo = db.EmployeeDemoes.Find(id);
            db.EmployeeDemoes.Remove(employeeDemo);
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
