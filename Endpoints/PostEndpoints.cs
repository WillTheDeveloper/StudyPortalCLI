using APIHelper;
using StudyPortalCLI.Actions;
using StudyPortalCLI.Models;

namespace StudyPortalCLI.Endpoints;

internal class PostEndpoints
{
    private readonly string _token;

    internal PostEndpoints(string token)
    {
        _token = token;
    }

    internal async Task<IEnumerable<Post>> GetCollectionOfPosts()
    {
        var getPosts = new GetModel()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/posts"
        };
        var postsRequest = await HttpHelper.GetRequest<DataGetter<IEnumerable<Post>>>(getPosts);
        var data = postsRequest.Data;
        return data;
    }

    /*internal async Task<Post> GetAPostBySlug(string slug)
    {
        
    }*/

    internal async Task<Post> CreateNewPost(Post post)
    {
        var newpost = new PostModel<Post>()
        {
            Bearer = _token,
            Uri = "https://studyportal.cloud/api/post/new",
            Content =
            {
                Title = post.Title,
                Body = post.Body,
                Subject = post.Subject,
                Tag = post.Tag
                /*User = new UserEndpoints(_token).GetCurrentUser().Result.Name*/
            }
        };

        var request = await HttpHelper.PostRequest<Post, Post>(newpost);

        return request;
    }
}