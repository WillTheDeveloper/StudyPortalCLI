namespace StudyPortalCLI.Models;

public class Discussion
{
    public string Title { get; set; }
    public string Body { get; set; }
    public Models.Group Group { get; set; }
    public bool Locked { get; set; }
    public User User { get; set; }
    public DateTime Created { get; set; }
}