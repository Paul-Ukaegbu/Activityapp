using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coolproject.Models;
using Microsoft.AspNetCore.Http;

namespace coolproject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]//login page
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("process")]//session tracking the user
        public IActionResult Process(User newUser){
            if(ModelState.IsValid){
                
                HttpContext.Session.SetString("FirstName", newUser.FirstName);
                HttpContext.Session.SetString("LastName", newUser.LastName);

                return RedirectToAction("Success");
            }
            else{
                return View("Index");
            }
        }


        [HttpGet("logout")]//logout button
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return Redirect("/");//once clicked it redirects to login
        }


        [HttpGet("success")]//success page
        public IActionResult Success(){
            if(HttpContext.Session.GetString("FirstName") == null){
                return RedirectToAction("Logout");
            }

            ViewBag.FirstName = HttpContext.Session.GetString("FirstName");
            ViewBag.LastName = HttpContext.Session.GetString("LastName");
            return View();
        }


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
