using Microsoft.AspNetCore.Mvc;

namespace GigHubNext.Controllers
{
    public class GigsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}