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
                // Add additional team members here-Patricia Echoles
                 new TeamInfo
                {
                    Name = "Patricia Echoles",
                    Birthdate = "03-21-1991",
                    CollegeProgram = "Information Tech-Associates Degree",
                    YearInProgram = "Sophomore"
                },
            };

            return View(teamMembers);
        }
        // New Controller for FavoriteVideoGame- Patricia Echoles
        public class FavoriteVideoGameController : Controller
        {
            public IActionResult Index()
            {
                var favoriteGames = new List<FavoriteVideoGame>
                {
                  new FavoriteVideoGame
                    {
                        Id = 1,
                        Title = "God of War: Ragnarok",
                        Genre = "Action",
                        Platform = "PlayStation 4",
                        ReleaseYear = "2022"
                    },
                };
                return View(favoriteGames);
            }
        }
    }
}