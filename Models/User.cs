using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class User
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
}