using GigHubNext.Data;
using GigHubNext.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;
using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;

namespace GigHubNext.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AttendancesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<GigUser> _userManager;

        public AttendancesController(ApplicationDbContext dbContext, UserManager<GigUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IActionResult Attend(int? id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.GigId == id))
                return BadRequest("The attendance already exists.");

            var attendance = new Attendance
            {
                GigId = (int)id,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}