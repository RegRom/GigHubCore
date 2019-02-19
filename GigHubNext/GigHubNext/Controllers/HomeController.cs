using GigHubNext.Data;
using GigHubNext.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using GigHubNext.ViewModels;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace GigHubNext.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var upcomingGigs = _dbContext.Gigs
                .Include(g => g.Artist)
                .Where(g => g.DateTime > DateTime.Now);

            return View(upcomingGigs);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
