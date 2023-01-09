using StudyPortalCLI.Endpoints;

namespace StudyPortalCLI.Actions;

public class ReportAction
{
    private readonly string _token;
    private readonly bool admin;

    public ReportAction(string token)
    {
        _token = token;

        admin = new UserEndpoints(_token).GetCurrentUser().Result.Admin;
    }

    internal async Task ReportOperator()
    {
        Console.Clear();
        Console.WriteLine("Available report actions:");
        Console.WriteLine("1. Get a collection of reports");
        Console.WriteLine("2. Get a report by ID");

        var selection = Console.ReadLine();

        var option = Convert.ToInt32(selection);

        switch (option)
        {
            case 1:
                CollectionOfReports().Wait();
                break;
            case 2:
                break;
        }
    }

    private async Task CollectionOfReports()
    {
        Console.Clear();
        Console.WriteLine("Here are all reports:");

        var collection = await new ReportEndpoints(_token).GetACollectionOfReports();

        int start = 1;

        foreach (var r in collection)
        {
            Console.WriteLine(start + ": " + r.Post + " - " + r.Comment + " - " + r.User.Name);
        }
    }
}