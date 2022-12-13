using APIHelper;
using StudyPortalCLI.Endpoints;
using StudyPortalCLI.Models;
using StudyPortalCLI.Helpers;

var token = "Bearer dZoPjwfABDnxJCeKtAwzVZTO5hyIYxzeiJ1p5mPE";

Console.WriteLine("========================================");
Console.WriteLine("Welcome to the Study Portal CLI (API v1)");
Console.WriteLine("========================================");

if (token == null)
{
    Console.WriteLine("Please enter your token:");
    token = Console.ReadLine();
    Console.WriteLine("Attempting authentication...");
    Authenticate();
}
else
{
    Console.WriteLine("Token found... attempting authentication...");
    Authenticate();
}

Task<User> Authenticate()
{
    var xx = new UserEndpoints(token).GetCurrentUser();
    Console.WriteLine("Name: "+ xx.Result.Name);
    if (xx.Result.Admin)
    {
        Console.WriteLine("Note: Authenticated user is also an admin.");
    }
    return xx;
}
