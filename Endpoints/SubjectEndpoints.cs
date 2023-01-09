using APIHelper;
using StudyPortalCLI.Models;

namespace StudyPortalCLI.Endpoints;

internal class SubjectEndpoints
{
    private readonly string _token;
    
    public SubjectEndpoints(string token)
    {
        _token = token;
    }

    internal async Task<IEnumerable<Subject>> GetACollectionOfSubjects()
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/subjects"
        };
        var request = await HttpHelper.GetRequest<DataGetter<IEnumerable<Subject>>>(get);
        var data = request.Data;

        return data;
    }

    internal async Task<Subject> GetSubjectById(int id)
    {
        var get = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/subject/" + id
        };
        var request = await HttpHelper.GetRequest<DataGetter<Subject>>(get);
        var data = request.Data;

        return data;
    }

    internal async Task<Subject> CreateNewSubject(Subject subject)
    {
        var create = new PostModel<Subject>()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/subject/new",
            Content =
            {
                Created = DateTime.Now,
                Subjectt = subject.Subjectt
            }
        };

        var request = await HttpHelper.PostRequest<Subject, Subject>(create);

        return request;
    }
}