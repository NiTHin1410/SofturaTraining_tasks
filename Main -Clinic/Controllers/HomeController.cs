using Clinic_Main.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Clinic_Main.DAL;

namespace Clinic1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult CancelAppoint()
        {
            ClinicDAL clDAL = new ClinicDAL();
            List<Appointment> appointments = new List<Appointment>();
            appointments = clDAL.GetAllDoctor();
            return View(appointments);
        }
        public IActionResult viewuser()
        {
            ClinicDAL clDAL = new ClinicDAL();
            List<Login> appointments = new List<Login>();
            appointments = clDAL.users();
            return View(appointments);
        }
        public IActionResult DoctList()
        {
            ClinicDAL clDAL = new ClinicDAL();
            List<Doctor> appointments = new List<Doctor>();
            appointments = clDAL.DoctorList();
            return View(appointments);
        }
        public IActionResult patlist()
        {
            ClinicDAL clDAL = new ClinicDAL();
            List<Patient> appointments = new List<Patient>();
            appointments = clDAL.PatList();
            return View(appointments);
        }
        //public IActionResult specs(Doctor d)
        //{
        //    ClinicDAL obj = new ClinicDAL();
        //        int r = obj.spec(d);
        //    if (r != null)
        //    {
        //        ViewBag.data = r;
        //    }
        //    return View();
        //}
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Deleting(int id)
        {
            ClinicDAL cobj = new ClinicDAL();
            int result = cobj.CancelAppoint(id);
            //  return RedirectToAction("Home", A);
            return RedirectToAction("Cancelled");
        }
        public IActionResult shbydate(string str)
        {
            ClinicDAL cobj = new ClinicDAL();
            int result = cobj.CancelByDate(str);
            return View();
        }
        public IActionResult Cancelled()
        {
            return View();
        }
        public IActionResult AddDoctor()
        {
            return View();
        }
        public IActionResult AddDoctorList(Doctor c)
        {
            ClinicDAL cobj = new ClinicDAL();
            int result = cobj.InsertDoctor(c);
            // Response.Writer("<script>alert('hello')</script>");
            //return Content("Ooppsssss itsssss Successssssssssssss");//"AddDoctor", c);
            return RedirectToAction("success");
        }
        public IActionResult success()
        {
            return View();
        }
        public IActionResult AddPatient()
        {
            return View();
        }
        public IActionResult AddPatientList(Patient c)
        {
            ClinicDAL cobj = new ClinicDAL();
            int result = cobj.InsertPatient(c);
            // return Content("Oppsssss itsssss Successssssssssssss");//"AddDoctor", c);
            return RedirectToAction("success");

        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Verify(Login l)
        {
            // string Password = l.Password;
            ClinicDAL obj = new ClinicDAL();
            int log = obj.validatelogin(l);
            if (log == 1)
            {
                TempData["msgg"] = "<script>alert('Logged in Successfully');</script>";
                return RedirectToAction("Home");
            }
            else
            {
                //TempData["msg"]="<script>alert('Invalid UserName or password');</script>";
                ViewBag.alertmsg = "Incorrect username or password!";
                return View("Login");
            }
        }
        public IActionResult ScheduleAppoint()
        {
            return View();
        }
        public IActionResult Appoint(Appointment A)
        {
            try
            {
                ClinicDAL cobj = new ClinicDAL();
                int result = cobj.ScheduleAppoint(A);
                if (result == 1)
                {
                    // return RedirectToAction("success");
                    return View("success");
                }
                else
                {
                    return RedirectToAction("success");
                }
            }
            catch
            {
               // ViewBag.alert = "Incorrect ID";
                TempData["msg"]="<script>alert('Patient ID not Found!');</script>";
                return RedirectToAction("ScheduleAppoint");
            }
        }
        public IActionResult LoginEX()
        {
            return View();
        }
       // [RequireHttps]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
