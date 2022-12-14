using System.Text.Json.Serialization;

namespace StudyPortalCLI.Models;

public class Institution
{
    [JsonPropertyName("institution")]
    public string InstitutionName { get; set; }
    [JsonPropertyName("joincode")]
    public string Joincode { get; set; }
}