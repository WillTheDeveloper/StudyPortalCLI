using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Ticket
{
    [JsonPropertyName("question")] public string Question { get; set; }
    [JsonPropertyName("details")] public string Details { get; set; }
    [JsonPropertyName("student")] public User Student { get; set; }
    [JsonPropertyName("tutor")] public User Tutor { get; set; }
    [JsonPropertyName("subject")] public Subject Subject { get; set; }
    [JsonPropertyName("status")] public string Status { get; set; }
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}