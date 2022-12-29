using StudyPortalCLI.Endpoints;
using StudyPortalCLI.Errors;

namespace StudyPortalCLI.Actions;

internal class AssignmentAction
{
    private readonly string _token;
    private readonly bool admin;

    internal AssignmentAction(string token)
    {
        _token = token;

        admin = new UserEndpoints(_token).GetCurrentUser().Result.Admin;
    }

    internal async Task AssignmentOperator()
    {
        Console.Clear();
        Console.WriteLine("Available assignment actions:");
        Console.WriteLine("1. Get an assignment by its ID");

        var selection = Console.ReadLine();

        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                GetAssignmentByTheId().Wait();
                break;
        }
    }

    private async Task GetAssignmentByTheId()
    {
        Console.Clear();
        Console.WriteLine("Enter the ID of the assignment:");
        var input = Console.ReadLine();

        var convert = Convert.ToInt32(input);

        try
        {
            var assignment = await new AssignmentEndpoints(_token).GetAssignmentById(convert);
            
            Console.WriteLine(assignment.Title);
        }
        catch (Exception e)
        {
            e.HandleError();
            await AssignmentOperator();
        }
    }
}