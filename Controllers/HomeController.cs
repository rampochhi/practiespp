using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using practiespp.Data;
using practiespp.Models;
using System.Diagnostics;


namespace practiespp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

      

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_context = context;
        }

        
        public IActionResult Index()
        {
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
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