using StudyPortalCLI.Errors;

namespace StudyPortalCLI.Endpoints;

using APIHelper;
using StudyPortalCLI.Models;
using StudyPortalCLI.Helpers;

internal class UserEndpoints
{
    private readonly string _token;
    
    internal UserEndpoints(string token)
    {
        _token = token;
    }

    internal async Task<Models.User> GetCurrentUser()
    {
        var getModel = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/user/me"
        };
        var userRequest = await HttpHelper.GetRequest<DataGetter<Models.User>>(getModel);
        var data = userRequest.Data;
        return data;
    }

    internal async Task<Models.User> GetUserById(int id)
    {
        var getModel = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/user/" + id
        };
        var userRequest = await HttpHelper.GetRequest<DataGetter<User>>(getModel);
        var data = userRequest.Data;

        return data;
    }

    internal async Task<IEnumerable<Models.User>> GetCollectionOfUsers()
    {
        var getUsers = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/users"
        };
        var usersrequest = await HttpHelper.GetRequest<DataGetter<IEnumerable<Models.User>>>(getUsers);
        var users = usersrequest.Data;

        return users;
    }
}