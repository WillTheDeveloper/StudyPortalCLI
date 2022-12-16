using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Subject
{
    [JsonPropertyName("subject")] public string Subject { get; set; } = null!;
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}