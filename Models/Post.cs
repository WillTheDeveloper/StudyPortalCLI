using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Post
{
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
    [JsonPropertyName("body")] public string Body { get; set; } = null!;
    [JsonPropertyName("user")] public string User { get; set; } = null!;
    [JsonPropertyName("subject")] public string Subject { get; set; } = null!;
    [JsonPropertyName("views")] public int Views { get; set; }
    [JsonPropertyName("tag")] public string? Tag { get; set; }
}