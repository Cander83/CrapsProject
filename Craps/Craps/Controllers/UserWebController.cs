using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Craps.Controllers
{
    public class UserWebController : Controller
    {
        // GET: User
        [HttpGet("[controller]/[action]")]
        public IActionResult GetCurrentUser()
        {
            return Json("Coulter");
        }

        // GET: User/Details/5
        [Route("{userName}")]
        public ActionResult CreateUser(string userName)
        {
            return Json("");
        }

        // GET: 
        [Route("{userName}")]
        public ActionResult LogOff(string userName)
        {
            return Json("");
        }

        // GET: 
        [Route("{userName}")]
        public ActionResult LogOn(string userName)
        {
            return Json("");
        }


    }
    
}