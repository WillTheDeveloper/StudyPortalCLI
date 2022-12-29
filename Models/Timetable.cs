namespace StudyPortalCLI.Models;

public class Timetable
{
    public Subject Subject { get; set; } = null!;
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Day { get; set; } = null!;
    public string Room { get; set; } = null!;
}