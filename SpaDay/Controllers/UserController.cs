using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //[Route("/User/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/User/Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (verify == newUser.Password)
            {
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                //ViewBag.dt = newUser.DateTime;
                return View("~/Views/User/Index.cshtml");
            }
            else
            {
                ViewBag.email = newUser.Email;
                ViewBag.username = newUser.Username;
                ViewBag.error = "Your passwords did not match. Please try again.";
                return View("~/Views/User/Add.cshtml");
            }
        }
    }
}
