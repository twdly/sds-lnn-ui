using System.Text.Json;
using lnn_ui.Models;

namespace lnn_ui.Services;

public class PredictionService(HttpClient client)
{
    public async Task<LnnOutput> GetPrediction()
    {
        var response = client.GetAsync("http://127.0.0.1:5000/get");
        var result = await response;
        return JsonSerializer.Deserialize<LnnOutput>(await result.Content.ReadAsStringAsync()) ?? new LnnOutput();
    }
}