using StudyPortalCLI.Endpoints;
using StudyPortalCLI.Models;
using Task = System.Threading.Tasks.Task;

namespace StudyPortalCLI.Actions;

internal class PostAction
{
    private readonly string _token;
    
    internal PostAction(string token)
    {
        _token = token;
    }

    internal async Task PostOperator()
    {
        Console.Clear();
        Console.WriteLine("Available post actions:");
        Console.WriteLine("1. Create a new post");
        Console.WriteLine("2. Get a collection of posts");

        var selection = Console.ReadLine();

        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                CreateANewPostForm().Wait();
                break;
            case 2:
                CollectionOfPosts().Wait();
                break;
        }
    }

    private async Task CreateANewPostForm()
    {
        Console.Clear();

        Console.WriteLine("Creating a new post.");
        
        Console.WriteLine("Enter the title of your new post:");
        var title = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Enter the body of your new post:");
        var body = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Enter the name of the subject associated:");
        var subject = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("*Nullable*");
        Console.WriteLine("Enter a tag for the post:");
        var tag = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Creating post....");

        var npost = new Post()
        {
            Body = body!,
            Title = title!,
            Subject = subject!,
            Tag = tag
        };

        var postpost = await new PostEndpoints(_token).CreateNewPost(npost);
        
        Console.WriteLine("Post created by " + postpost.User + " titled " + postpost.Title);
    }

    private async Task CollectionOfPosts()
    {
        Console.Clear();
        Console.WriteLine("List of posts:");

        var all = await new PostEndpoints(_token).GetCollectionOfPosts();

        int start = 1;

        foreach (var p in all)
        {
            Console.WriteLine(start + ": " + p.Title);
            start++;
        }
    }
}