using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSub.Models;

namespace FormSub.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser){
            if (ModelState.IsValid){
                return View("Register", newUser);
            } else {
                return View("Index");
            }
        }

        [HttpGet("registered")]
        public IActionResult Registered(User newUser){
            if (ModelState.IsValid){
                return View("Register", newUser);
            } else {
                return RedirectToAction("Index");
            }
        }
    }
}
