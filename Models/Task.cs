using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Task
{
    [JsonPropertyName("task")] public string Task { get; set; }
    [JsonPropertyName("details")] public string? Details { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("due")] public DateTime Due { get; set; }
    [JsonPropertyName("completed")] public bool Completed { get; set; }
}