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
    public class ActivityController : Controller{

        [HttpGet("home")]
        public IActionResult createActivity(){


            return View();
        }

        
        [HttpPost("new")]//session tracking the user
        public IActionResult Process(User newActivity){
        //     if(ModelState.IsValid){
                
        //         HttpContext.Session.SetString("Title", newActivity.Title);
        //         HttpContext.Session.SetString("LastName", newActivity.Description);

        //         return RedirectToAction("Show");
        //     }
        //     else{
                return View();
        //     }
        }
   

    }
}
