using System.Text.Json.Serialization;

namespace lnn_ui.Models;

public class LnnOutput
{
    [JsonPropertyName("index")] public int Index { get; init; }
    [JsonPropertyName("prediction")] public double Prediction { get; init; }
    [JsonPropertyName("temperature")] public int Temperature { get; init; }
    [JsonPropertyName("vorticity")] public int Vorticity { get; init; }
}