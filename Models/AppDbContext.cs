using Microsoft.EntityFrameworkCore;
using IT3045C_final.Models;

//Added DbContext for Entity Framework Core-Patricia Echoles
namespace IT3045C_final.Models
{ 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<TeamInfo> TeamInfos { get; set; }
        public DbSet<FavoriteVideoGame> FavoriteVideoGames { get; set; }
    }
}
