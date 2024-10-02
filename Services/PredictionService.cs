using System.Text.Json;
using lnn_ui.Models;
using Microsoft.AspNetCore.Components;

namespace lnn_ui.Services;

public class PredictionService(HttpClient client)
{
    public async Task<LnnOutput> GetPrediction()
    {
        var response = client.GetAsync("http://localhost:5000/");
        var result = await response;
        return JsonSerializer.Deserialize<LnnOutput>(await result.Content.ReadAsStringAsync());
    }
}