using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CustomersController : Controller
    {
        private SchoolContext db = new SchoolContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        public JsonResult InsertCustomers(List<Customer> customers)
        {
            
            
                //Truncate Table to delete all old records.
               // db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Customers]");

                //Check for NULL.
                if (customers == null)
                {
                    customers = new List<Customer>();
                }

                //Loop and insert records.
                foreach (Customer customer in customers)
                {
                    db.Customers.Add(customer);
                }
                int insertedRecords = db.SaveChanges();
                return Json(insertedRecords);
            
        }
    }
}