using BankruptcyTask.DAL.Interfaces;
using BankruptcyTask.DAL;
using BankruptcyTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BankruptcyTask.Service.Interfaces;

namespace BankruptcyTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEstateService _estateService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IEstateService estateService)
        {
            _estateService = estateService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _estateService.GetEstates();
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