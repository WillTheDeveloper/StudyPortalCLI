using System.Text.Json.Serialization;

namespace APIHelper;

public class DataGetter<T>
{
    [JsonPropertyName("data")]
    public T Data { get; set; }
}