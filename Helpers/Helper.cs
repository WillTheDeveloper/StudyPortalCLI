using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using StudyPortalCLI.Errors;

namespace APIHelper
{
    internal static class HttpHelper
    {
        internal static async Task<TOut> PostRequest<TIn, TOut>(PostModel<TIn> model)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    if (model.Bearer != null)
                    {
                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", model.Bearer);
                    }

                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                    var serialized = new StringContent(JsonSerializer.Serialize(model.Content), Encoding.UTF8, "application/json");

                    using (HttpResponseMessage response = await client.PostAsync(model.Uri, serialized))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        return JsonSerializer.Deserialize<TOut>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }

        internal static async Task<T> GetRequest<T>(GetModel model)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    if (model.Bearer != null)
                    {
                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", model.Bearer);
                    }
                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                    using (HttpResponseMessage response = await client.GetAsync(model.Uri))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        return JsonSerializer.Deserialize<T>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
    }

    internal class PostModel<TIn>
    {
        internal string Uri { get; set; } = null!;
        internal TIn Content { get; set; }
        internal string Bearer { get; set; } = null!;
    }

    internal class GetModel
    {
        internal string Uri { get; set; } = null!;
        internal string Bearer { get; set; } = null!;
    }
}