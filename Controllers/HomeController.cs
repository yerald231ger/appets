using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApPets.Models;
using Microsoft.AspNetCore.Identity;
using ApPets.Data;

namespace ApPets.Controllers
{
    public class HomeController : Controller
    {
        public SignInManager<ApPetsUser> _signInManager { get; set; } 
        public UserManager<ApPetsUser> _userManager { get; set; } 

        public HomeController(SignInManager<ApPetsUser> signInManager, UserManager<ApPetsUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
