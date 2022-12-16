using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Tag
{
    [JsonPropertyName("tag")] public string Tagg { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
}