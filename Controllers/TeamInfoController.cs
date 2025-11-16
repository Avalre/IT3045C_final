using Microsoft.AspNetCore.Mvc;
using IT3045C_final.Models;

namespace IT3045C_final.Controllers
{
    public class TeamInfoController : Controller
    {
        public IActionResult Index()
        {
            var teamMembers = new List<TeamInfo>
            {
                new TeamInfo
                {
                    Name = "Ben Stewart",
                    Birthdate = "02-28-2002",
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Junior"
                },
            };

            return View(teamMembers);
        }
    }
}