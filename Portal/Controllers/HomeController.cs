using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Account;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountStorage _accountStorage;

        public HomeController(AccountStorage accountStorage)
        {
            _accountStorage = accountStorage;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = $"Your application description page. {_accountStorage.DoSomethingWithAnAccount()}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
