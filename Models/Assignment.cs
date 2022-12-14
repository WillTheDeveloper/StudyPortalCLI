using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Assignment
{
    [JsonPropertyName("title")] public string Title { get; set; } = null!;
    [JsonPropertyName("details")] public string Details { get; set; } = null!;
    [JsonPropertyName("due")] public DateTime Due { get; set; }
    [JsonPropertyName("set")] public DateTime Set { get; set; }
    [JsonPropertyName("subject")] public Subject Subject { get; set; } = null!;
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}