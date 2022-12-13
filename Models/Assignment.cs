namespace StudyPortalCLI.Models;

public class Assignment
{
    public string Title { get; set; }
    public string Details { get; set; }
    public DateTime Due { get; set; }
    public DateTime Set { get; set; }
    public Subject Subject { get; set; }
    public DateTime Created { get; set; }
}