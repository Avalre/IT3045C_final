namespace IT3045C_final.Models;

public class TeamInfo
{
    public string Name { get; set; }
    public string Birthdate { get; set; }
    public string CollegeProgram { get; set; }
    public string YearInProgram { get; set; }   
}
// New model for FavoriteVideoGame- Patricia Echoles
public class  FavoriteVideoGame
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Platform { get; set; }
    public string ReleaseYear { get; set; }

}

