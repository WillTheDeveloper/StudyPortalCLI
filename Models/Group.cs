using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Group
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("subject")] public Subject Subject { get; set; } = null!;
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}