using StudyPortalCLI.Helpers;

namespace StudyPortalCLI.Actions;

using StudyPortalCLI.Endpoints;

internal class UserAction
{
    private readonly string _token;
    private readonly bool admin;
    
    internal UserAction(string token)
    {
        _token = token;

        admin = new UserEndpoints(_token).GetCurrentUser().Result.Admin;
    }

    internal void UserOperator()
    {
        Console.Clear();
        Console.WriteLine("Available user actions:");
        Console.WriteLine("1. Get a user by their ID");

        var selection = Console.ReadLine();

        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                FindAUserByTheirId();
                break;
        }
    }
    
    private void FindAUserByTheirId()
    {
        Console.Clear();
        Console.WriteLine("Enter ID of user:");
        var number = Console.ReadLine();

        var convert = Convert.ToInt32(number);

        var request = new UserEndpoints(_token).GetUserById(convert);
        
        Console.WriteLine("Name: " + request.Result.Name);
        if (admin)
        {
            Console.WriteLine("Email: " + request.Result.Email);
        }
        Console.WriteLine("Username: " + request.Result.Username);
        Console.WriteLine("Bio: " + request.Result.Bio);
        Console.WriteLine("Created: " + request.Result.Created.ToLongDateString());
        Console.WriteLine("Admin: " + new BoolHelpers().BoolToString(request.Result.Admin));
    }
}