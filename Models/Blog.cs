using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Blog
{
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
    [JsonPropertyName("body")] public string Body { get; set; } = null!;
    [JsonPropertyName("type")] public string Type { get; set; } = null!;
    [JsonPropertyName("posted")] public DateTime Posted { get; set; }
    [JsonPropertyName("created")] public User CreatedBy { get; set; } = null!;
    [JsonPropertyName("slug")] public string Slug { get; set; } = null!;
    [JsonPropertyName("image")] public Uri Image { get; set; } = null!;
}