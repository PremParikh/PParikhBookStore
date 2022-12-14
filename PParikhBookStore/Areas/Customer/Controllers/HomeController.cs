using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PParikhBooks.DataAccess.Models;
using PParikhBookStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PParikhBookStore.Area.Customer.Controllers
{

    [Area("Customer")]
    public class HomeController : Controller
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly ILogger<HomeController> _logger;
#pragma warning restore IDE0052 // Remove unread private members

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
