using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Kanban
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("description")] public string Description { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}