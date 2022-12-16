using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Placement
{
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
    [JsonPropertyName("company")] public string Company { get; set; } = null!;
    [JsonPropertyName("location")] public string Location { get; set; } = null!;
    [JsonPropertyName("role")] public string Role { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("slug")] public string Slug { get; set; } = null!;
    [JsonPropertyName("open")] public bool Open { get; set; }
    [JsonPropertyName("active")] public bool Active { get; set; }
    [JsonPropertyName("closing")] public string Closing { get; set; } = null!;
}