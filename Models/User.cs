using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class User
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("email")] public string Email { get; set; } = null!;
    [JsonPropertyName("username")] public string? Username { get; set; }
    [JsonPropertyName("bio")] public string? Bio { get; set; }
    [JsonPropertyName("created")] public DateTime Created { get; set; }
    [JsonPropertyName("admin")] public bool Admin { get; set; }
}