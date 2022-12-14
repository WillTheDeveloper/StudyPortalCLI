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
                await GetInstitutionByJoinCode();
                break;
            case 2:
                await GetAllInstitutions();
                break;
        }
    }

    private async Task GetInstitutionByJoinCode()
    {
        Console.Clear();
        Console.WriteLine("Enter join code of the institution:");
        var input = Console.ReadLine();

        var result = await new InstitutionEndpoints(_token).GetInstitutionByJoinCode(input);
        
        Console.WriteLine(result.InstitutionName);
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
            Console.WriteLine(start + " - " + place.InstitutionName + " (" + place.Joincode + ")");
            start++;
        }
    }
}