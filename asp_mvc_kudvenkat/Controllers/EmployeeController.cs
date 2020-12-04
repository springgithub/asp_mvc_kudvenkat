using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_mvc_kudvenkat.Models;

namespace asp_mvc_kudvenkat.Controllers
{
    public class EmployeeController: Controller
    {

        public ActionResult Details()
        {
            Employee x = new Employee()
            {
                EmployeeId = 12,
                Name = "John",
                Gender = "Male",
                City = "Twin peaks"
            };
            return View(x);

        }
    }
}