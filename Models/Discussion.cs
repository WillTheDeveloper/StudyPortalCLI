using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Discussion
{
    [JsonPropertyName("title")] public string Title { get; set; }
    [JsonPropertyName("body")] public string Body { get; set; }
    [JsonPropertyName("group")] public Models.Group Group { get; set; }
    [JsonPropertyName("locked")] public bool Locked { get; set; }
    [JsonPropertyName("user")] public User User { get; set; }
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}