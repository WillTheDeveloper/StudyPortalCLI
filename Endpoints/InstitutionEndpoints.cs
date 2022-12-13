using APIHelper;
using StudyPortalCLI.Models;

namespace StudyPortalCLI.Endpoints;

internal class InstitutionEndpoints
{
    private readonly string _token;

    public InstitutionEndpoints(string token)
    {
        _token = token;
    }

    internal async Task<IEnumerable<Institution>> GetListOfInstitutions()
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/institutions"
        };
        var request = await HttpHelper.GetRequest<DataGetter<IEnumerable<Institution>>>(get);
        var institutions = request.Data;

        return institutions;
    }

    internal async Task<Institution> GetInstitutionByJoinCode(string JoinCode)
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/institution/" + JoinCode
        };
        var request = await HttpHelper.GetRequest<DataGetter<Institution>>(get);
        var data = request.Data;

        return data;
    }
}
