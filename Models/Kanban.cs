namespace StudyPortalCLI.Models;

public class Kanban
{
    public string Name { get; set; }
    public string Description { get; set; }
    public User User { get; set; }
    public DateTime Created { get; set; }
}