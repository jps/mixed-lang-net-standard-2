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
            //Tuple - 
            var returnedName1 = DataAccess.UserGetter.GetUserById("James");
            var name1 = returnedName1.Item1;
            var age1 = returnedName1.Item2;
            //Record Type
            var returnedName2 = DataAccess.UserGetter.Get("James");
            var b = (returnedName2.Name, returnedName2.Age);
            return View();
        }
    }
}
