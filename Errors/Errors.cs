namespace StudyPortalCLI.Errors;

internal static class Errors
{
    internal static void HandleError(this Exception e)
    {
        /*Console.WriteLine(e.HResult switch
        {
            -2146233088 => "Error 404",
            _ => e.Message
        });*/
        Console.WriteLine("Something went wrong");
    }
}