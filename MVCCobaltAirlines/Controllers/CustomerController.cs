using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCobaltAirlines.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerPurchaseForm(string fName, string payment, string cName)
        {
            if (fName == "")
                fName = "joe";
            ViewBag.message = "Thank you for your wonderful payment of " + payment;
            ViewBag.message += ".  The city of" + cName + " will be fun to explore!";
            return View("ConfirmCustomerPurchase");
        }
        public ActionResult CustomerPurchaseForm()
        {
            return View();
        }
        public ActionResult CustomerNumber(string customerNumber)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Your temporary customer number is: " + customerNumber);
            return View();
        }
    }
}      