using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project01Group4.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project01Group4.Controllers
{
    public class AccountController : Controller
    {
        MyDbContext db = new MyDbContext();
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        

        public ActionResult Validate(Person person)
        {
            var _person = db.People.Where(s => s.Email == person.Email);
            if (_person.Any())
            {
                if (_person.Where(s => s.Password == person.Password).Any())
                {

                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }

    }
}
