using System.Text.Json.Serialization;

namespace lnn_ui.Models;

public class LnnOutput
{
    [JsonPropertyName("prediction")] public double Prediction { get; set; }
    [JsonPropertyName("temperature")] public int Temperature { get; set; }
    [JsonPropertyName("vorticity")] public int Vorticity { get; set; }
}