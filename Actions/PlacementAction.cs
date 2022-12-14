using StudyPortalCLI.Endpoints;

namespace StudyPortalCLI.Actions;

internal class PlacementAction
{
    private readonly string _token;
    private readonly bool admin;
    
    public PlacementAction(string token)
    {
        _token = token;

        admin = new UserEndpoints(_token).GetCurrentUser().Result.Admin;
    }

    internal async Task PlacementOperator()
    {
        Console.Clear();
        Console.WriteLine("Available placement actions:");
        Console.WriteLine("1. Get a collection of reports");
        Console.WriteLine("2. Get a report by Id");
        Console.WriteLine("3. Get reports by user Id");
        Console.WriteLine("4. Get reports by post Id");

        var selection = Console.ReadLine();

        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                break;
        }
    }

    private async Task GetACollectionOfReports()
    {
        Console.Clear();
        Console.WriteLine("List of reports:");

        var collection = await new PlacementEndpoints(_token).GetCollectionOfReports();

        foreach (var item in collection)
        {
            // Console.WriteLine(collection.Title);
        }
    }
}