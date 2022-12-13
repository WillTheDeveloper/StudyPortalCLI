using APIHelper;

namespace StudyPortalCLI.Endpoints;

using StudyPortalCLI.Models;

internal class AssignmentEndpoints
{
    private readonly string _token;

    public AssignmentEndpoints(string token)
    {
        _token = token;
    }

    internal async Task<Assignment> GetAssignmentById(int id)
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/assignment/" + id
        };
        var request = await HttpHelper.GetRequest<DataGetter<Assignment>>(get);
        var data = request.Data;

        return data;
    }
}