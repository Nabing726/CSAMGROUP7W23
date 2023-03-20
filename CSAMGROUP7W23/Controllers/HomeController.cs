using CSAMGROUP7W23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSAMGROUP7W23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Repository().Students);
        }
    }
}