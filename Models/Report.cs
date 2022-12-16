using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Report
{
    [JsonPropertyName("post")] public Post Post { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("reason")] public string? Severity { get; set; }
    [JsonPropertyName("comment")] public string? Comment { get; set; }
    [JsonPropertyName("reported")] public DateTime Reported { get; set; }
    [JsonPropertyName("resolved")] public bool Resolved { get; set; }
}