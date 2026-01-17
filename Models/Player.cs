
namespace DoublesMatch2.Models;

public class Player
{
    public string Name { get; set; } = string.Empty;
    public double Rating { get; set; }
    public int XPlayed { get; set; }
    public string LastCourt { get; set; } = "";
    public string Booked { get; set; } = "No";
    public string Sex { get; set; } = "M";
    public bool Playing { get; set; }
}
