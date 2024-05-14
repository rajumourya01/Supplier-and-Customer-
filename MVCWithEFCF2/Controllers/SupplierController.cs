using MVCWithEFCF2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF2.Controllers
{
    public class SupplierController : Controller
    {
        CompanyDbContext dc = new CompanyDbContext();
        public ActionResult Index()
        {
            return View(dc.Suppliers);
        }
    }
}