using APIHelper;
using StudyPortalCLI.Models;

namespace StudyPortalCLI.Endpoints;

public class PlacementEndpoints
{
    private readonly string _token;
    
    public PlacementEndpoints(string token)
    {
        _token = token;
    }

    internal async Task<IEnumerable<Placement>> GetCollectionOfReports()
    {
        var getModel = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/reports"
        };
        var request = await HttpHelper.GetRequest<DataGetter<IEnumerable<Placement>>>(getModel);
        var data = request.Data;
        return data;
    }

    internal async Task<Placement> GetReportById(int id)
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/report/" + id
        };
        var request = await HttpHelper.GetRequest<DataGetter<Placement>>(get);
        var data = request.Data;
        return data;
    }

    internal async Task<IEnumerable<Placement>> GetReportsByUserId(int userId)
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/reports/user/" + userId
        };
        var request = await HttpHelper.GetRequest<DataGetter<IEnumerable<Placement>>>(get);
        var data = request.Data;
        return data;
    }

    internal async Task<IEnumerable<Placement>> GetReportsByPostId(int postId)
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/reports/post/" + postId
        };
        var request = await HttpHelper.GetRequest<DataGetter<IEnumerable<Placement>>>(get);
        var data = request.Data;
        return data;
    }
}