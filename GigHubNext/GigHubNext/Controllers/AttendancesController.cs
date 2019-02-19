using GigHubNext.Data;
using GigHubNext.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private ApplicationDbContext _dbContext;
        private readonly UserManager<GigUser> _userManager;

        public AttendancesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Attend([FromBody] int gigId)
        {
            var attendance = new Attendance
            {
                GigId = gigId,
                AttendeeId = _userManager.GetUserId(ClaimsPrincipal.Current)
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}