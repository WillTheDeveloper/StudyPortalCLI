using APIHelper;
using StudyPortalCLI.Endpoints;

var token = "Bearer dZoPjwfABDnxJCeKtAwzVZTO5hyIYxzeiJ1p5mPE";

Console.WriteLine("========================================");
Console.WriteLine("Welcome to the Study Portal CLI");
Console.WriteLine("========================================");
Console.WriteLine("Beta Version 0.1");
Console.WriteLine("========================================");

if (token == null)
{
    Console.WriteLine("Please enter your token:");
    token = Console.ReadLine();
}
else
{
    Console.WriteLine("Getting user ID of 1:");
    var xx = new UserEndpoints(token).GetUserById(1);
    Console.WriteLine("Name: "+ xx.Result.Name);
}


