using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simple_Activity_2.Models;

namespace Simple_Activity_2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProdIndex()
        {
            return View();
        }
        public IActionResult Create(Customer c)
        {
            if (ModelState.IsValid)
            {
                CustomerDBContext dBContext = new CustomerDBContext();
                dBContext.Add(c);
                dBContext.SaveChanges();
                return Content("Your Registration is Success");
            }
            return View("ProdIndex");
        }
    }
}
