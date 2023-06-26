using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Starting with a base of $50/month
                decimal baseAmount = 50;

                // Calculating the monthly total by either adding the base amount to the user input or the base amount
                decimal monthlyTotal = insuree.Quote > 0 ? insuree.Quote + baseAmount : baseAmount;

                // Adding $100 to the monthly total If the user is 18 or under
                if (CalculateAge(insuree.DateOfBirth) <= 18)
                {
                    monthlyTotal += 100;
                }

                // Adding $50 to the monthly total if the user is from 19 to 25
                else if (CalculateAge(insuree.DateOfBirth) >= 19 && CalculateAge(insuree.DateOfBirth) <= 25)
                {
                    monthlyTotal += 50;
                }

                // Adding $25 to the monthly total if the user is 26 or older
                else
                {
                    monthlyTotal += 25;
                }


                // Adding $25 to the monthly total if the car's year is before 2000, 
                if (insuree.CarYear < 2000)
                {
                    monthlyTotal += 25;
                }

                // Adding $25 to the monthly total if the car's year is after 2015,
                else if (insuree.CarYear > 2015)
                {
                    monthlyTotal += 25;
                }

                // Add $25 to the quote if the car's Make is a Porsche,
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    monthlyTotal += 25;

                    // Addding an additional $25 to the quote if the car's Make is a Porsche and its model is a 911 Carrera
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        monthlyTotal += 25;
                    }
                }

                // Adding $10 to the monthly total for every speeding ticket the user has
                monthlyTotal += insuree.SpeedingTickets * 10;

                // Adding 25% to the total if the user has ever had a DUI
                if (insuree.DUI)
                {
                    monthlyTotal += monthlyTotal * 0.25m;
                }

                // Adding 50% to the total if the user wants full coverage
                if (insuree.CoverageType)
                {
                    monthlyTotal += monthlyTotal * 0.5m;
                }


                // Assigning the calculated quote to the Insuree object
                insuree.Quote = monthlyTotal;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // Helper method to calculate age based on DateOfBirth
        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (DateTime.Today < dateOfBirth.AddYears(age))
            {
                age--;
            }
            return age;
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
          
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        //2.	Modify the Create View so that the user does not see the “Quote” input field.
        //3.	Add an Admin View for a site administrator to the Insuree Views.This page must show all quotes issued, along with the user's first name, last name, and email address.


        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Other actions...

        public ActionResult Admin()
        {
            var quotes = (from insuree in db.Insurees
                          select new QuoteViewModel
                          {
                              FirstName = insuree.FirstName,
                              LastName = insuree.LastName,
                              EmailAddress = insuree.EmailAddress,
                              Quote = insuree.Quote
                          }).ToList();

            return View(quotes);
        }

        // Other actions...

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    public class QuoteViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Quote { get; set; }
    }
}
