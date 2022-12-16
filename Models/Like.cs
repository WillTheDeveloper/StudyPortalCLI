using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Like
{
    [JsonPropertyName("post")] public Post Post { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
}