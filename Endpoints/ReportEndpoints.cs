using APIHelper;
using StudyPortalCLI.Models;

namespace StudyPortalCLI.Endpoints;

public class ReportEndpoints
{
    private readonly string _token;

    public ReportEndpoints(string token)
    {
        _token = token;
    }

    internal async Task<IEnumerable<Report>> GetACollectionOfReports()
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/reports"
        };
        var request = await HttpHelper.GetRequest<DataGetter<IEnumerable<Report>>>(get);
        var data = request.Data;

        return data;
    }

    internal async Task<Report> GetReportById(int id)
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/report/" + id,
        };

        var request = await HttpHelper.GetRequest<DataGetter<Report>>(get);
        var data = request.Data;

        return data;
    }
}