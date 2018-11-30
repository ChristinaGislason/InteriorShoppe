using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InteriorShoppe.Controllers
{
    [Authorize(Policy = "EduEmailPolicy")]
    public class DormRoomController : Controller
    {
        /// <summary>
        /// Takes user to Dorm Room if they have an .edu email address
        /// </summary>
        /// <returns>Dorm Room View</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}