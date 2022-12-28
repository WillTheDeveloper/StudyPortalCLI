namespace StudyPortalCLI.Models;

public class Timetable
{
    public Subject Subject { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Day { get; set; }
    public string Room { get; set; }
}