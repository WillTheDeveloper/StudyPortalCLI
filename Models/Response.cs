using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Response
{
    [JsonPropertyName("response")] public string Responsee { get; set; }
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}