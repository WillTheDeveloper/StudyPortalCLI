namespace StudyPortalCLI.Models;

public class Blog
{
    public string Title { get; set; }
    public string Body { get; set; }
    public string Type { get; set; }
    public DateTime Posted { get; set; }
    public User CreatedBy { get; set; }
    public string Slug { get; set; }
    public Uri Image { get; set; }
}