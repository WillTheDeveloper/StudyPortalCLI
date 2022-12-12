using APIHelper;
using StudyPortalCLI.Endpoints;

var token = "Bearer dZoPjwfABDnxJCeKtAwzVZTO5hyIYxzeiJ1p5mPE";

var xx = new UserEndpoints(token).GetUserById(1);
Console.WriteLine(xx.Result.Name);