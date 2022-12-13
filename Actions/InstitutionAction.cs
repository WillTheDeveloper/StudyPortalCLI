using StudyPortalCLI.Endpoints;

namespace StudyPortalCLI.Actions;

public class InstitutionAction
{
    private readonly string _token;
    private readonly bool admin;

    internal InstitutionAction(string token)
    {
        _token = token;
        
        admin = new UserEndpoints(_token).GetCurrentUser().Result.Admin;
    }

    internal async Task InstitutionOperator()
    {
        Console.Clear();
        Console.WriteLine("Available institution actions:");
        Console.WriteLine("1. Get institution by the join code");
        Console.WriteLine("2. List all institutions");

        var selection = Console.ReadLine();

        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                GetInstitutionByJoinCode();
                break;
            case 2:
                GetAllInstitutions();
                break;
        }
    }

    private async Task GetInstitutionByJoinCode()
    {
        Console.Clear();
        Console.WriteLine("Enter joincode of the institution:");
        var input = Console.ReadLine();

        var result = await new InstitutionEndpoints(_token).GetInstitutionByJoinCode(input);
        
        Console.WriteLine(result.Insitution);
        Console.WriteLine(result.Joincode);
    }

    private async Task GetAllInstitutions()
    {
        Console.Clear();
        Console.WriteLine("List of institutions:");
        int start = 1;

        var collection = await new InstitutionEndpoints(_token).GetListOfInstitutions();

        foreach (var place in collection)
        {
            Console.WriteLine(start + " - " + place.Insitution + " (" + place.Joincode + ")");
            start++;
        }
    }
}