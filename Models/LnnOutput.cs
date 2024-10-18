using System.Text.Json.Serialization;

namespace lnn_ui.Models;

public class LnnOutput
{
    [JsonPropertyName("index")] public int Index { get; init; }
    [JsonPropertyName("nature")] public double Nature { get; init; }
    [JsonPropertyName("intensity")] public double Intensity { get; init; }
    [JsonPropertyName("month")] public double Month { get; init; }
    [JsonPropertyName("day")] public double Day { get; init; }
    [JsonPropertyName("hour")] public double Hour { get; init; }
    [JsonPropertyName("lat")] public double Latitude { get; init; }
    [JsonPropertyName("lon")] public double Longitude { get; init; }
    [JsonPropertyName("wind")] public double Wind { get; init; }
    [JsonPropertyName("pres")] public double Pressure { get; init; }
    [JsonPropertyName("gust")] public double Gust { get; init; }
    [JsonPropertyName("eye")] public double Eye { get; init; }
    [JsonPropertyName("storm_speed")] public double StormSpeed { get; init; }
}