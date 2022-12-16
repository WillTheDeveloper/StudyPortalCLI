using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Comment
{
    [JsonPropertyName("comment")] public string Commentt { get; set; } = null!;
    [JsonPropertyName("user")] public string User { get; set; } = null!;
    [JsonPropertyName("post")] public Post Post { get; set; } = null!;
    [JsonPropertyName("commented")] public DateTime Commented { get; set; }
}