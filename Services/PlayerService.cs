
using DoublesMatch2.Models;

namespace DoublesMatch2.Services;

public class PlayerService
{
    public IEnumerable<string> AvailableLists => new[] { "Default", "Location A", "Location B" };

    public IEnumerable<Player> GetPlayers(string list)
    {
        var seed = new List<Player>
        {
            new Player { Name = "Robin", Rating = 3.5, XPlayed = 2, LastCourt = "2", Booked = "No", Sex = "M" },
            new Player { Name = "Alex",  Rating = 4.0, XPlayed = 4, LastCourt = "5", Booked = "Yes", Sex = "F" },
            new Player { Name = "Sam",   Rating = 3.0, XPlayed = 1, LastCourt = "1", Booked = "No", Sex = "M" },
            new Player { Name = "Jess",  Rating = 4.2, XPlayed = 3, LastCourt = "3", Booked = "No", Sex = "F" }
        };
        return seed;
    }
}
