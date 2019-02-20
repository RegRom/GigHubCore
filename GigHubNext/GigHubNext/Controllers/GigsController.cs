using GigHubNext.Data;
using GigHubNext.Models;
using GigHubNext.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace GigHubNext.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public GigsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Authorize]
        public IActionResult Attending()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var gigs = _dbContext.Attendances
                .Where(a => a.AttendeeId == userId)
                .Select(a => a.Gig)
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .ToList();

            var viewModel = new GigsViewModel()
            {
                UpcomingGigs = gigs,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Gigs I'm Attending"
            };

            return View("Gigs", viewModel);
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _dbContext.Genres.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GigFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = _dbContext.Genres.ToList();
                return View("Create", viewModel);
            }

            var gig = new Gig
            {
                ArtistId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                DateTime = viewModel.GetDateTime(),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };
            _dbContext.Gigs.Add(gig);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}