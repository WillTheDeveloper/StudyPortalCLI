using System.Diagnostics;
using APIHelper;
using StudyPortalCLI.Actions;
using StudyPortalCLI.Endpoints;
using StudyPortalCLI.Models;
using StudyPortalCLI.Helpers;

var token = "Bearer dZoPjwfABDnxJCeKtAwzVZTO5hyIYxzeiJ1p5mPE";

Console.WriteLine("========================================");
Console.WriteLine("Welcome to the Study Portal CLI (API v1)");
Console.WriteLine("========================================");

if (token == null)
{
    Debug.WriteLine("No token found.");
    Console.WriteLine("Please enter your token:");
    token = Console.ReadLine();
    Console.WriteLine("Attempting authentication...");
    Authenticate();
}
else
{
    Debug.WriteLine("Token found.");
    Console.WriteLine("Token found... attempting authentication...");
    Authenticate();
    Menu();
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

void Menu()
{
    Console.WriteLine("============Study Portal CLI============");
    Console.WriteLine("Enter a name of a model you would like to interact with:");
    var input = Console.ReadLine();

    switch (input)
    {
        case "User":
            new UserAction(token).UserOperator();
            break;
        case "Assignment":
            new AssignmentAction(token).AssignmentOperator();
            break;
        case "Institution":
            new InstitutionAction(token).InstitutionOperator();
            break;
        case "Post":
            new PostAction(token).PostOperator();
            break;
        case "Subject":
            new SubjectAction(token).SubjectOperator();
            break;
    }
}
