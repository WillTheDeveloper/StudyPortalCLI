namespace StudyPortalCLI.Models;

public class Webhook
{
    public string Name { get; set; } = null!;
    public Uri Url { get; set; } = null!;
    public User User { get; set; } = null!;
    public Boolean Active { get; set; }
    public Triggers Triggers { get; set; } = null!;
}

public class Triggers
{
    public Post Posts { get; set; } = null!;
    public Comment Comments { get; set; } = null!;
    public Assignment Assignments { get; set; } = null!;
    public Blog Blogs { get; set; } = null!;
}