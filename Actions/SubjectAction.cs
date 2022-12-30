using StudyPortalCLI.Endpoints;

namespace StudyPortalCLI.Actions;

public class SubjectAction
{
    private readonly string _token;
    private readonly bool admin;
    
    internal SubjectAction(string token)
    {
        _token = token;
        
        admin = new UserEndpoints(_token).GetCurrentUser().Result.Admin;
    }

    internal async Task SubjectOperator()
    {
        Console.Clear();
        Console.WriteLine("Available subject actions:");
        Console.WriteLine("1. Get a subject by its ID");
        Console.WriteLine("2. Get a collection of subjects");

        if (admin)
        {
            Console.WriteLine("3. Create a new subject");
            Console.WriteLine("4. Delete a subject with its ID");
        }

        var selection = Console.ReadLine();

        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                GetAnSubjectByItsId().Wait();
                break;
            case 2:
                CollectionOfSubjects().Wait();
                break;
        }
    }

    private async Task GetAnSubjectByItsId()
    {
        Console.Clear();
        Console.WriteLine("Enter the ID of the subject");

        var input = Console.ReadLine();

        var number = Convert.ToInt32(input);
        
        Console.Clear();

        var result = await new SubjectEndpoints(_token).GetSubjectById(number);
        
        Console.WriteLine("Subject: " + result.Subjectt);
    }

    private async Task CollectionOfSubjects()
    {
        Console.Clear();
        Console.WriteLine("**These are not IDs**");
        Console.WriteLine("All subjects: ");

        var collection = await new SubjectEndpoints(_token).GetACollectionOfSubjects();

        int start = 1;

        foreach (var subject in collection)
        {
            Console.WriteLine(start + ". " + subject.Subjectt);
            start++;
        }
    }
}