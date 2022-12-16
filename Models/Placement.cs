namespace StudyPortalCLI.Models;

public class Placement
{
    public string Title { get; set; } = null!;
    public string Company { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Role { get; set; } = null!;
    public User User { get; set; } = null!;
    public string Slug { get; set; } = null!;
    public bool Open { get; set; }
    public bool Active { get; set; }
    public string Closing { get; set; } = null!;
}