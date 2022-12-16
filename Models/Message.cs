using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Message
{
    [JsonPropertyName("message")] public string Messagee { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}