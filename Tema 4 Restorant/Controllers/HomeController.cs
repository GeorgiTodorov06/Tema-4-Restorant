using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tema_4_Restorant.Data;
using Tema_4_Restorant.Models;

namespace Tema_4_Restorant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            int TablesCount = _context.Table.Count();
            int CustomersCount = _context.Customer.Count();
            int PassedReservations = 0;
            int UpcomingReservations = 0;
            foreach (var item in _context.Reservation)
            {
                if (item.DataTime < DateTime.Now)
                {
                    PassedReservations++;
                }
                else 
                {
                    UpcomingReservations++;
                }
            }
            ViewData["TablesCount"] = TablesCount;
            ViewData["CustomersCount"] = CustomersCount;
            ViewData["PassedReservations"] = PassedReservations;
            ViewData["UpcomingReservations"] = UpcomingReservations;
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