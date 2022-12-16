using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Note
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("description")] public string? Description { get; set; }
    [JsonPropertyName("note")] public long Notee { get; set; }
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("private")] public bool Private { get; set; }
    [JsonPropertyName("created")] public DateTime Created { get; set; }
    [JsonPropertyName("updated")] public DateTime Updated { get; set; }
}