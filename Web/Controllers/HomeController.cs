using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccess;

namespace MixedLang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

        public IActionResult Test()
        {
            //Tuple
            var user1 = DataAccess.UserGetter.GetUserById("James");
            var name1 = user1.Item1;
            var age1 = user1.Item2;
            //Record Type
            var user2 = DataAccess.UserGetter.Get("James");
            var b = (user2.Name, user2.Age);
            //Record Type from Type provider
            //var user3 = DataAccess.UserGetter.GetUserByAge(12);

            

            return View();
        }
    }
}
