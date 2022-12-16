using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Product
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("description")] public string Description { get; set; } = null!;
    [JsonPropertyName("image")] public string Image { get; set; } = null!;
    [JsonPropertyName("slug")] public string Slug { get; set; }= null!;
    [JsonPropertyName("user")] public User User { get; set; } = null!;
    [JsonPropertyName("price")] public decimal Price { get; set; }
    [JsonPropertyName("shipping")] public decimal Shipping { get; set; }
    [JsonPropertyName("active")] public bool Active { get; set; }
    [JsonPropertyName("created")] public DateTime Created { get; set; }
}