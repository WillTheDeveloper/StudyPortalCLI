namespace StudyPortalCLI.Models;

public class Webhook
{
    public string Name { get; set; }
    public Uri Url { get; set; }
    public User User { get; set; }
    public Boolean Active { get; set; }
    public Triggers Triggers { get; set; }
}

public class Triggers
{
    public Post Posts { get; set; }
    public Comment Comments { get; set; }
    public Assignment Assignments { get; set; }
    public Blog Blogs { get; set; }
}