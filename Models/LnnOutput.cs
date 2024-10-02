using System.Text.Json.Serialization;

namespace lnn_ui.Models;

public class LnnOutput
{
    [JsonPropertyName("prediction")] public string Prediction { get; set; } = "";
    [JsonPropertyName("temperature")] public string Temperature { get; set; } = "";
    [JsonPropertyName("vorticity")] public string Vorticity { get; set; } = "";
}