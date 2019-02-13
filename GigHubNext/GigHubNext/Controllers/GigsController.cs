using GigHubNext.Data;
using GigHubNext.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GigHubNext.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _dbContext;

        public GigsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _dbContext.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}