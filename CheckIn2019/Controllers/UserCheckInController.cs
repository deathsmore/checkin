using CheckIn2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckIn2019.Controllers
{
    public class UserCheckInController : Controller
    {
        // GET: UserCheckIn
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(UserCheckInModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new CustomerFormViewModel
            //    {
            //        Customer = customer,
            //        MembershipTypes = _context.MembershipTypes.ToList()
            //    };
            //    return View("CustomerForm", viewModel);
            //}
            //if (customer.Id == 0)
            //{
            //    _context.Customers.Add(customer);
            //}
            //else
            //{
            //    var customerFromDB = _context.Customers.Find(customer.Id);
            //    customerFromDB.Name = customer.Name;
            //    customerFromDB.Birthdate = customer.Birthdate;
            //    customerFromDB.MembershipTypeId = customer.MembershipTypeId;
            //    customerFromDB.IsSubscribledToNewsletter = customer.IsSubscribledToNewsletter;
            //}

            //_context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}