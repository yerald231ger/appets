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
    public class AccountController : Controller
    { 

        public AccountController()
        {
            
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}