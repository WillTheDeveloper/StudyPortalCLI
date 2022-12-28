using System.Diagnostics;
using StudyPortalCLI.Errors;
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

    internal async Task UserOperator()
    {
        Console.Clear();
        Console.WriteLine("Available user actions:");
        Console.WriteLine("1. Get a user by their ID");
        Console.WriteLine("2. Get current user");

        if (admin)
        {
            Console.WriteLine("3. Get all users");
        }

        var selection = Console.ReadLine();

        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                await FindAUserByTheirId();
                break;
            case 2:
                await GetCurrentUser();
                break;
        }
    }

    private async Task GetCurrentUser()
    {
        Console.Clear();
        var user = await new UserEndpoints(_token).GetCurrentUser();
        
        Console.WriteLine("Name: " + user.Name);
        if (admin)
        {
            Console.WriteLine("Email: " + user.Email);
        }
        Console.WriteLine("Username: " + user.Username);
        Console.WriteLine("Bio: " + user.Bio);
        Console.WriteLine("Created: " + user.Created.ToLongDateString());
        Console.WriteLine("Admin: " + new BoolHelpers().BoolToString(user.Admin));
    }
    
    private async Task FindAUserByTheirId()
    {
        Console.Clear();
        Console.WriteLine("Enter ID of user:");
        var number = Console.ReadLine();

        var convert = Convert.ToInt32(number);

        var user = await new UserEndpoints(_token).GetUserById(convert);

        if (user != null)
        {
            Console.WriteLine("Name: " + user.Name);
            if (admin)
            {
                Console.WriteLine("Email: " + user.Email);
            }
            Console.WriteLine("Username: " + user.Username);
            Console.WriteLine("Bio: " + user.Bio);
            Console.WriteLine("Created: " + user.Created.ToLongDateString());
            Console.WriteLine("Admin: " + new BoolHelpers().BoolToString(user.Admin));
        }
    }
}