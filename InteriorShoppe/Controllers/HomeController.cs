using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace InteriorShoppe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /// <summary>
            /// Takes user to the Home page
            /// </summary>
            /// <returns>Home View</returns>
            return View();
        }
    }
}
