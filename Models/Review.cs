using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Review
{
    [JsonPropertyName("review")] public string Revieww { get; set; }
    [JsonPropertyName("rating")] public int Rating { get; set; }
    [JsonPropertyName("product")] public Product Product { get; set; } = null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
}