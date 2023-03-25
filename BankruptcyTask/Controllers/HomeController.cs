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
        private readonly IDebtorService _debtorService;

        public HomeController(ILogger<HomeController> logger, IEstateService estateService, IDebtorService debtorService)
        {
            _estateService = estateService;
            _logger = logger;
            _debtorService = debtorService;
        }

        public async Task<IActionResult> Index()
        {

            var responseEstate = await _estateService.GetEstates();
            var responseDebtor = await _debtorService.GetDebtors();
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